using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingPongPower
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Activated(object sender, EventArgs e)
        {
            try
            {
                smtpHost.Text = Properties.Settings.Default.smtpHost;
                smtpPort.Text = Properties.Settings.Default.smtpPort.ToString();
                mailDestination.Text = Properties.Settings.Default.mailDestination;
            }
            //catch (Exception ex)
            catch
            {
                /* smtpHost.Text = "";
                smtpPort.Text = "";
                mailDestination.Text = "";
                MessageBox.Show(ex.Message, "An exception occured");
                */
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.smtpHost = smtpHost.Text;
                Properties.Settings.Default.smtpPort = int.Parse(smtpPort.Text);
                Properties.Settings.Default.mailDestination = mailDestination.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("{0}\r\n\r\n\r\nIs the port number correct?",ex.Message), "An Exception has occured");
            }
        }
    }
}
