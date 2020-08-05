using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Multiple_concurrencia
{
    public partial class MainWindow : Form
    {

        List<Thread> thread_list = new List<Thread>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            user_thread us = new user_thread();

            for (int n = 0; n < 10000; n++)
            {
                Thread t = new Thread(new ThreadStart(us.do_select));
                t.Start();
                thread_log.AppendText("Thread number " + n + " started" + Environment.NewLine);
                if (t.IsAlive)
                    thread_log.AppendText("Thread number " + n + " finished" + Environment.NewLine);
            }
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
