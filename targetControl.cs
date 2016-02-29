using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingPongPower
{
    public partial class targetControl : UserControl
    {

        bool TargetAlive = true;
        System.Net.NetworkInformation.Ping pingrequest = new System.Net.NetworkInformation.Ping();
        System.Net.NetworkInformation.PingReply pingreply;
        
        // event-hantering 
        public delegate void targetResponseHandler (object sender, targetArgs ta);
        public event targetResponseHandler targetResponseEvent;
        
        public targetControl()
        {
            InitializeComponent();           
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (true)
            {
                try
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    
                    targetStatus.Invoke((MethodInvoker)delegate
                    {
                        targetStatus.ForeColor = Color.Orange;
                        targetStatus.PerformStep();
                    });
                    pingreply = pingrequest.Send(targetBox.Text,int.Parse(pingTimeout.Text));
                    
                    
                    if (pingreply.Status != System.Net.NetworkInformation.IPStatus.Success)
                    {
                    #region Handles the ping-reply
                        // Invoke delegat för att uppdatera kontroller från andra trådar.
                        targetStatus.Invoke((MethodInvoker)delegate
                        {
                            targetStatus.ForeColor = Color.Red;
                            
                            if (targetStatus.Value >= targetStatus.Maximum)
                                targetStatus.Value = 0;
                            targetStatus.PerformStep();
                        });

                        // Ska det mailas?
                        if (mailAlert.Checked)
                        {
                        #region Send mail handling
                            if (TargetAlive)
                                {
                                    try
                                    {
                                        Program.mailmessage.To.Clear();
                                        Program.mailmessage.To.Add(Properties.Settings.Default.mailDestination);
                                        Program.mailmessage.Subject = String.Format("{0} has connectivity issues", targetBox.Text);
                                        Program.mailmessage.Body = String.Format("Ping check to {0} failed with {1} \r\n/PingPongPower", targetBox.Text, pingreply.Status.ToString());
                                        Program.mailer.Host = Properties.Settings.Default.smtpHost;
                                        Program.mailer.Send(Program.mailmessage);
                                        TargetAlive = false;
                                    }
                                    catch (Exception ex)
                                    {
                                        System.Diagnostics.Trace.WriteLine(String.Format("{0} The following exception occured during mailsending: {1}", DateTime.Now.ToString(), ex.Message));
                                    }
                                }
                        #endregion
                        }
                        
                    }
                    else
                    {
                        // Invoke delegat för att uppdatera kontroller från andra trådar.
                        targetStatus.Invoke((MethodInvoker)delegate
                        {
                            targetStatus.ForeColor = Color.Green;
                            if (targetStatus.Value >= targetStatus.Maximum)
                                targetStatus.Value = 0;
                            targetStatus.PerformStep();
                            targetLastTimeStamp.Text = DateTime.Now.ToString();
                        });

                        // Ska det mailas?
                        if (mailAlert.Checked)
                        {
                        #region Send mail handling
                            if (!TargetAlive)
                            {
                                try
                                {
                                    Program.mailmessage.To.Clear();
                                    Program.mailmessage.To.Add(Properties.Settings.Default.mailDestination);
                                    Program.mailmessage.Subject = String.Format("{0} is alive", targetBox.Text);
                                    Program.mailmessage.Body = String.Format("Ping check to {0} respoded with {1} \r\n/PingPongPower", targetBox.Text, pingreply.Status.ToString());
                                    Program.mailer.Host = Properties.Settings.Default.smtpHost;
                                    Program.mailer.Send(Program.mailmessage);
                                    TargetAlive = true;
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.Trace.WriteLine(String.Format("{0} The following exception occured during mailsending: {1}", DateTime.Now.ToString(), ex.Message));
                                }
                            }
                        #endregion
                        }
                    #endregion
                    }
                    
                    // Ska det loggas?
                    if(loggingActive.Checked)
                        System.Diagnostics.Trace.WriteLine(String.Format("{0} Host:{1} PingReply:{2}",DateTime.Now.ToString(),targetBox.Text,pingreply.Status.ToString()));

                    // Aktivera response event
                    worker.ReportProgress(0,pingreply);

                    // Ping intervall
                    System.Threading.Thread.Sleep(int.Parse(pingIntervall.Text) * 1000);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine(String.Format("{0} The following exception occured: {1}\n{2}", DateTime.Now.ToString(),ex.Message, ex.InnerException));
                    bool Debug=true;
                    if(Debug)
                        System.Diagnostics.Trace.WriteLine(String.Format("{1}", DateTime.Now.ToString(),ex.StackTrace));
                    // Stoppa vid exceptions eller inte?
                    if(!pingUninterruptible.Checked)
                    {
                        worker.CancelAsync();
                        startStopButton.Invoke((MethodInvoker)delegate
                        {
                            startStopButton.Text = "Start";
                            targetBox.Enabled = true;
                        });
                    }
                }
            }
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            // Starta om stoppad
            if(!worker.IsBusy)
            {
                worker.RunWorkerAsync();
                targetStatus.Step = 10;
                startStopButton.Text = "Stop";
                targetBox.Enabled = false;
            }
            // Stoppa om startad
            else 
            {
                worker.CancelAsync();
                targetStatus.Step = 0;
                startStopButton.Text = "Start";
                targetBox.Enabled = true;
            }
        }

        private void deleteTarget_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
            worker.Dispose();
            this.Dispose();
        }
        
        void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // MessageBox.Show(pingreply.Status.ToString());
            targetArgs ta=new targetArgs(pingreply, targetBox.Text);
            if (targetResponseEvent != null)
                targetResponseEvent(this, ta);
        }
        
        void WorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
