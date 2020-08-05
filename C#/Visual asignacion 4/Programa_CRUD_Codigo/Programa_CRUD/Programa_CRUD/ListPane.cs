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
using Npgsql;

namespace Programa_CRUD
{
    public partial class ListPane : UserControl
    {
        private DBComponent Component;

        public ListPane()
        {
            InitializeComponent();
        }

        public void GetComponent(DBComponent Comp)
        {
            Component = Comp;
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            DataSet Dts = new DataSet("data");
            NpgsqlDataAdapter NpAdapter = new NpgsqlDataAdapter();

            if (!FiltersCheck.Checked)
            {
                Component.A.ClearParams();
                NpAdapter.SelectCommand = new NpgsqlCommand(Component.A.GetSentence("q2", Component.A.GetParams(), "productos"), Component.A.GetConnection());
                NpAdapter.Fill(Dts, "data");
                var Dsource = Dts.Tables["data"];
                dataGridView1.DataSource = Dsource;
            }
            else
            {
                Component.A.ClearParams();

                if (IDRB.Checked)
                {
                    Component.A.AddParam("*");
                    Component.A.AddParam("product_id");
                    Component.A.AddParam(IDBox.Text);
                }

                else if (NameRB.Checked)
                {
                    Component.A.AddParam("*");
                    Component.A.AddParam("product_name");
                    Component.A.AddParam(NameBox.Text);
                }

                else if (ERB.Checked)
                {
                    Component.A.AddParam("*");
                    Component.A.AddParam("product_existence");
                    Component.A.AddParam(EBox.Text);
                }

                else
                {
                    Component.A.AddParam("*");
                    Component.A.AddParam("product_brand");
                    Component.A.AddParam(BrandBox.Text);
                }

                NpAdapter.SelectCommand = new NpgsqlCommand(Component.A.GetSentence("q2", Component.A.GetParams(), "productos"), Component.A.GetConnection());
                NpAdapter.Fill(Dts, "data");
                var Dsource = Dts.Tables["data"];
                dataGridView1.DataSource = Dsource;
            }
            Component.A.ReturnConn();
        }

        private void ReturnLbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FiltersCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltersCheck.Checked)
            {
                BrandRB.Enabled = true;
                ERB.Enabled = true;
                NameRB.Enabled = true;
                IDRB.Enabled = true;
            }
            else
            {
                BrandRB.Enabled = false;
                ERB.Enabled = false;
                NameRB.Enabled = false;
                IDRB.Enabled = false;
                BrandRB.Checked = false;
                ERB.Checked = false;
                NameRB.Checked = false;
                IDRB.Checked = false;
            }
        }

        private void IDRB_CheckedChanged(object sender, EventArgs e)
        {
            if (IDRB.Checked)
                IDBox.Enabled = true;
            else
                IDBox.Enabled = false;
        }

        private void NameRB_CheckedChanged(object sender, EventArgs e)
        {
            if (NameRB.Checked)
                NameBox.Enabled = true;
            else
                NameBox.Enabled = false;
        }

        private void ERB_CheckedChanged(object sender, EventArgs e)
        {
            if (ERB.Checked)
                EBox.Enabled = true;
            else
                EBox.Enabled = false;
        }

        private void BrandRB_CheckedChanged(object sender, EventArgs e)
        {
            if (BrandRB.Checked)
                BrandBox.Enabled = true;
            else
                BrandBox.Enabled = false;
        }
    }
}
