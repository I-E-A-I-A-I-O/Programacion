using System;
using Npgsql;

namespace DB_Component
{
    class Conection_conf
    {
        private String ConString;
        private NpgsqlConnection Con;

        public void OpenConn()
        {
            Con = new NpgsqlConnection(ConString);
            Con.Open();
        }

        public void SetConString(String Connection_String)
        {
            ConString = Connection_String;
        }

        public NpgsqlConnection GetConnection()
        {
            return Con;
        }
    }
}
