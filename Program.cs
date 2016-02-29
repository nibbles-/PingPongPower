using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PingPongPower
{
    static class Program
    {

        //Setup the mailclient
        public static System.Net.Mail.SmtpClient mailer = new System.Net.Mail.SmtpClient();
        public static System.Net.Mail.MailMessage mailmessage = new System.Net.Mail.MailMessage();

        [STAThread]
        static void Main()
        {
            //Hardcoded from address for the mailer
            mailmessage.From = new System.Net.Mail.MailAddress(String.Format("PingPongPower@{0}",System.Net.Dns.GetHostName()));
           
            //Setup the logging-function
            System.Diagnostics.Trace.Listeners.Add(new System.Diagnostics.TextWriterTraceListener("logg.txt"));
            System.Diagnostics.Trace.AutoFlush = true;

            //Application.EnableVisualStyles(); // Disabled so that the progressbar works as it should
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
