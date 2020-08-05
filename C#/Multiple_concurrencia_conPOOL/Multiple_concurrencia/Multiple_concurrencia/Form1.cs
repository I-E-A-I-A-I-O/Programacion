using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Multiple_concurrencia
{
    public partial class MainWindow : Form
    {

        private List<Thread> thread_list = new List<Thread>();
        private Pool p;
        delegate void SetTextCallback(string text);

        public MainWindow()
        {
            InitializeComponent();
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            p = new Pool();

            settings["TCnnD"].Value = settings["NCnn"].Value;
            settings["TCnnE"].Value = "0";

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberOfThreads.Value; i++)
            {
                Pool_Manager pm = new Pool_Manager(p);
                user_thread us = new user_thread(pm, this);
                Thread t = new Thread(new ThreadStart(us.Run));
                t.Name = "Thread " + i;
                t.Start();
                thread_log.AppendText(t.Name + " " + t.ThreadState + Environment.NewLine);
            }
        }

        public void AppendTextBox(string value)
        {
            if (thread_log.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText);
                thread_log.BeginInvoke(d, new object[] { value });
            }
        }

        private void setText(string text)
        {
            thread_log.AppendText(text + Environment.NewLine);
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < thread_list.Count; n++)
            {
                thread_list.ElementAt(n).Abort();
            }
        }
    }
}
