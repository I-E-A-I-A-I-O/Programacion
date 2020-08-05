namespace Programa_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPane1 = new Programa_CRUD.MainPane();
            this.updatePane1 = new Programa_CRUD.UpdatePane();
            this.listPane1 = new Programa_CRUD.ListPane();
            this.addPane1 = new Programa_CRUD.AddPane();
            this.deletePane1 = new Programa_CRUD.DeletePane();
            this.SuspendLayout();
            // 
            // mainPane1
            // 
            this.mainPane1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mainPane1.Location = new System.Drawing.Point(0, -1);
            this.mainPane1.Name = "mainPane1";
            this.mainPane1.Size = new System.Drawing.Size(800, 449);
            this.mainPane1.TabIndex = 0;
            // 
            // updatePane1
            // 
            this.updatePane1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.updatePane1.Location = new System.Drawing.Point(0, -1);
            this.updatePane1.Name = "updatePane1";
            this.updatePane1.Size = new System.Drawing.Size(800, 449);
            this.updatePane1.TabIndex = 3;
            this.updatePane1.Visible = false;
            // 
            // listPane1
            // 
            this.listPane1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listPane1.Location = new System.Drawing.Point(0, -1);
            this.listPane1.Name = "listPane1";
            this.listPane1.Size = new System.Drawing.Size(800, 449);
            this.listPane1.TabIndex = 2;
            this.listPane1.Visible = false;
            // 
            // addPane1
            // 
            this.addPane1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addPane1.Location = new System.Drawing.Point(0, -1);
            this.addPane1.Name = "addPane1";
            this.addPane1.Size = new System.Drawing.Size(800, 449);
            this.addPane1.TabIndex = 1;
            this.addPane1.Visible = false;
            // 
            // deletePane1
            // 
            this.deletePane1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.deletePane1.Location = new System.Drawing.Point(0, -1);
            this.deletePane1.Name = "deletePane1";
            this.deletePane1.Size = new System.Drawing.Size(800, 449);
            this.deletePane1.TabIndex = 4;
            this.deletePane1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.mainPane1);
            this.Controls.Add(this.deletePane1);
            this.Controls.Add(this.updatePane1);
            this.Controls.Add(this.listPane1);
            this.Controls.Add(this.addPane1);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.ResumeLayout(false);

        }

        #endregion

        private MainPane mainPane1;
        private AddPane addPane1;
        private ListPane listPane1;
        private UpdatePane updatePane1;
        private DeletePane deletePane1;
    }
}

