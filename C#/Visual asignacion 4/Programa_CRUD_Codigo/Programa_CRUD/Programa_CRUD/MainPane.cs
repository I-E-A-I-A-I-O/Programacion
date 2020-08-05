using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_CRUD
{
    public partial class MainPane : UserControl
    {
        int WichPane;

        public MainPane()
        {
            InitializeComponent();
        }

        public int GetWichPane()
        {
            return WichPane;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            WichPane = 1;
            this.Visible = false;
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            WichPane = 2;
            this.Visible = false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            WichPane = 3;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WichPane = 4;
            this.Visible = false;
        }
    }
}
