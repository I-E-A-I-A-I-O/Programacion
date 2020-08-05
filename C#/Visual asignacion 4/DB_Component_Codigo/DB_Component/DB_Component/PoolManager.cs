using System.Threading;
using Npgsql;

namespace DB_Component
{
    class Pool_Manager
    {
        Pool p = null;

        public Pool_Manager(Pool po)
        {
            p = po;
        }

        public Conection_conf GetConnection()
        {
            if (!p.Connections_available())
            {
                if (!p.Can_grow())
                {
                    while (!p.Connections_available())
                        Thread.Sleep(100);
                    return p.Give_con();
                }
                else
                    return p.CreateNGive();
            }
            else
                return p.Give_con();
        }

        public void ReturnConn(Conection_conf Conn)
        {
            p.EndConn(Conn);
        }
    }
}
