using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Component;

namespace Programa_CRUD
{
    public partial class AddPane : UserControl
    {
        DBComponent Component;

        public AddPane()
        {
            InitializeComponent();
        }

        public void GetComponent(DBComponent Comp)
        {
            Component = Comp;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (IDBox.Text.Equals("") || NameBox.Text.Equals("") || EBox.Text.Equals("") || BrandBox.Text.Equals(""))
            {
                MessageBox.Show("Uno o mas campos estan vacios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Component.A.ClearParams();
                Component.A.AddParam(IDBox.Text);
                Component.A.AddParam(NameBox.Text);
                Component.A.AddParam(EBox.Text);
                Component.A.AddParam(BrandBox.Text);
                Component.A.ExectueSentence(Component.A.GetSentence("q1", Component.A.GetParams(), "productos"), Component.A.GetConnection());
                IDBox.Text = "";
                NameBox.Text = "";
                EBox.Text = "";
                BrandBox.Text = "";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
