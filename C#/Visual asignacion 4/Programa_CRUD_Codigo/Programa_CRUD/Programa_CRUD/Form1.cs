using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Component;

namespace Programa_CRUD
{
    public partial class Form1 : Form
    {
        DBComponent Component;

        public Form1()
        {
            InitializeComponent();
            mainPane1.VisibleChanged += MainPane1_VisibleChanged;
            addPane1.VisibleChanged += AddPane1_VisibleChanged;
            listPane1.VisibleChanged += ListPane1_VisibleChanged;
            updatePane1.VisibleChanged += UpdatePane1_VisibleChanged;
            deletePane1.VisibleChanged += DeletePane1_VisibleChanged;
            Component = new DBComponent();
            Component.A.LoadPool("DB1");
            Component.A.LoadSentences();
            listPane1.GetComponent(Component);
            addPane1.GetComponent(Component);
            updatePane1.GetComponent(Component);
            deletePane1.GetComponent(Component);
        }

        private void DeletePane1_VisibleChanged(object sender, EventArgs e)
        {
            if (!deletePane1.Visible)
                mainPane1.Visible = true;
        }

        private void UpdatePane1_VisibleChanged(object sender, EventArgs e)
        {
            if (!updatePane1.Visible)
                mainPane1.Visible = true;
        }

        private void ListPane1_VisibleChanged(object sender, EventArgs e)
        {
            if (!listPane1.Visible)
                mainPane1.Visible = true;
        }

        private void AddPane1_VisibleChanged(object sender, EventArgs e)
        {
            if (!addPane1.Visible)
                mainPane1.Visible = true;
        }

        private void MainPane1_VisibleChanged(object sender, EventArgs e)
        {
            if (!mainPane1.Visible)
            {
                if (mainPane1.GetWichPane() == 1)
                    addPane1.Visible = true;
                else if (mainPane1.GetWichPane() == 2)
                    listPane1.Visible = true;
                else if (mainPane1.GetWichPane() == 3)
                    updatePane1.Visible = true;
                else
                    deletePane1.Visible = true;
            }
        }
    }
}
