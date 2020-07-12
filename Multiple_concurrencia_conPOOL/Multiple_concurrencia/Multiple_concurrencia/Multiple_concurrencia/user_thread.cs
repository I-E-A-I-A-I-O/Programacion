using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_concurrencia
{
    class user_thread
    {
        public void do_select()
        {
            pgConnect cn = new pgConnect();
            cn.do_select();
        }
    }
}
