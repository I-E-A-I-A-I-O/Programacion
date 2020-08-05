using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiple_concurrencia
{
    class Pool_Manager
    {
        Pool p = null;

        public Pool_Manager(Pool po)
        {
            p = po;
        }

        public pgConnect GetConnection()
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

        public void ReturnConn(pgConnect Conn)
        {
            p.EndConn(Conn);
        }
    }
}
