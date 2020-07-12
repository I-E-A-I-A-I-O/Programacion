using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_concurrencia
{
    class execute_table_filler
    {
        static void Main()
        {
            pgConnect con = new pgConnect();

            for (int n = 0; n < 100; n++)
            {
                con.fill_table();
            }
        }
    }
}
