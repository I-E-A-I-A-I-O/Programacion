using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiple_concurrencia
{
    class user_thread
    {
        Pool_Manager PM;
        pgConnect DBConnection = null;
        MainWindow MW;

        public user_thread(Pool_Manager pm, MainWindow mw)
        {
            MW = mw;
            PM = pm;
        }

        public void Run()
        {
            while (DBConnection == null)
                DBConnection = PM.GetConnection();
            DBConnection.do_select();
            PM.ReturnConn(DBConnection);
            MW.AppendTextBox(Thread.CurrentThread.Name + " Finished.");
        }
    }
}
