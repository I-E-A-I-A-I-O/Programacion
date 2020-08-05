using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace DB_Component
{
    class Pool
    {
        private List<Conection_conf> con_list = new List<Conection_conf>();
        private int NCnn, MaxCnn, TCnnD, TCnnE, Grw;
        private string DB_ID;

        public Pool(string DatabaseID)
        {
            DB_ID = DatabaseID;

            var AppSettings = ConfigurationManager.AppSettings;
            var ConnString = ConfigurationManager.ConnectionStrings[DB_ID].ConnectionString;

            NCnn = int.Parse(AppSettings["NCnn"]);
            MaxCnn = int.Parse(AppSettings["MaxCnn"]);
            TCnnD = int.Parse(AppSettings["TCnnD"]);
            TCnnE = int.Parse(AppSettings["TCnnE"]);
            Grw = int.Parse(AppSettings["Grw"]);

            for (int i = 0; i < NCnn; i++)
            {
                Conection_conf conn = new Conection_conf();
                conn.SetConString(ConnString);
                conn.OpenConn();
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

        public Conection_conf Give_con()
        {
            Conection_conf temp;

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

        public Conection_conf CreateNGive()
        {
            Conection_conf temp;
            var ConnString = ConfigurationManager.ConnectionStrings[DB_ID].ConnectionString;

            for (int i = 0; i < Grw; i++)
            {
                Conection_conf conn = new Conection_conf();
                conn.SetConString(ConnString);
                conn.OpenConn();
                con_list.Add(conn);
            }

            temp = con_list.ElementAt(0);
            con_list.RemoveAt(0);

            NCnn += Grw;
            TCnnD = con_list.Count;
            TCnnE = NCnn - TCnnD;

            return temp;
        }

        public void EndConn(Conection_conf Conn)
        {
            con_list.Add(Conn);

            TCnnD = con_list.Count;
            TCnnE = NCnn - TCnnD;
        }
    }
}