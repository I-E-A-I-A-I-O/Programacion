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
    public partial class DeletePane : UserControl
    {
        DBComponent Component;

        public DeletePane()
        {
            InitializeComponent();
        }

        public void GetComponent(DBComponent Comp)
        {
            Component = Comp;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ColumnBox.Text.Equals("") || ConditionBox.Text.Equals(""))
                MessageBox.Show("Uno o mas campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Component.A.ClearParams();
                Component.A.AddParam(ColumnBox.Text);
                Component.A.AddParam(ConditionBox.Text);
                Component.A.ExectueSentence(Component.A.GetSentence("q4", Component.A.GetParams(), "productos"), Component.A.GetConnection());
                Component.A.ReturnConn();
                ColumnBox.Text = "";
                ConditionBox.Text = "";
                MessageBox.Show("Productos eliminados con exito!", "Operacion completada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
