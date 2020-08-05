using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.Logging;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;
using System.Threading;
using System.IO;

namespace Multiple_concurrencia
{
    class Pool
    {
        private List<pgConnect> con_list = new List<pgConnect>();
        private int NCnn, MaxCnn, TCnnD, TCnnE, Grw;

        public Pool()
        {
            var AppSettings = ConfigurationManager.AppSettings;

            NCnn = int.Parse(AppSettings["NCnn"]);
            MaxCnn = int.Parse(AppSettings["MaxCnn"]);
            TCnnD = int.Parse(AppSettings["TCnnD"]);
            TCnnE = int.Parse(AppSettings["TCnnE"]);
            Grw = int.Parse(AppSettings["Grw"]);

            for (int i = 0; i < NCnn; i++)
            {
                pgConnect conn = new pgConnect();
                con_list.Add(conn);
            }
        }

        public bool Connections_available()
        {
            if (TCnnD > 0)
                return true;
            else
                return false;
        }

        public bool Can_grow()
        {
            if (NCnn < MaxCnn)
                return true;
            else
                return false;
        }

        public pgConnect Give_con()
        {
            pgConnect temp;

            if (con_list.Count == 0)
            {
                return CreateNGive();
            }
            else
            {
                temp = con_list.ElementAt(0);
                con_list.RemoveAt(0);

                TCnnD = con_list.Count;
                TCnnE = NCnn - con_list.Count;

                return temp;
            }
        }

        public pgConnect CreateNGive()
        {
            pgConnect temp;

            for (int i = 0; i < Grw; i++)
            {
                pgConnect conn = new pgConnect();
                con_list.Add(conn);
            }

            temp = con_list.ElementAt(0);
            con_list.RemoveAt(0);

            NCnn += Grw;
            TCnnD = con_list.Count;
            TCnnE = NCnn - TCnnD;

            return temp;
        }

        public void EndConn(pgConnect Conn)
        {
            con_list.Add(Conn);

            TCnnD = con_list.Count;
            TCnnE = NCnn - TCnnD;
        }
    }
}
