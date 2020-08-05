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
    public partial class UpdatePane : UserControl
    {
        DBComponent Component;

        public UpdatePane()
        {
            InitializeComponent();
        }

        public void GetComponent(DBComponent Comp)
        {
            Component = Comp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UColumnBox.Text.Equals("") || NDataBox.Text.Equals("") || CColumnBox.Text.Equals("") || ConditionBox.Text.Equals(""))
                MessageBox.Show("Uno o mas campos vacios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Component.A.ClearParams();
                Component.A.AddParam(UColumnBox.Text);
                Component.A.AddParam(NDataBox.Text);
                Component.A.AddParam(CColumnBox.Text);
                Component.A.AddParam(ConditionBox.Text);
                Component.A.ExectueSentence(Component.A.GetSentence("q3", Component.A.GetParams(), "productos"), Component.A.GetConnection());
                Component.A.ReturnConn();
                UColumnBox.Text = "";
                NDataBox.Text = "";
                CColumnBox.Text = "";
                ConditionBox.Text = "";
                MessageBox.Show("Actualizacion exitosa!", "Operacion completada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
