namespace Programa_CRUD
{
    partial class ListPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDRB = new System.Windows.Forms.RadioButton();
            this.NameRB = new System.Windows.Forms.RadioButton();
            this.ERB = new System.Windows.Forms.RadioButton();
            this.BrandRB = new System.Windows.Forms.RadioButton();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EBox = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.FiltersCheck = new System.Windows.Forms.CheckBox();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.ReturnLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(606, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario";
            // 
            // IDRB
            // 
            this.IDRB.AutoSize = true;
            this.IDRB.Enabled = false;
            this.IDRB.Location = new System.Drawing.Point(86, 296);
            this.IDRB.Name = "IDRB";
            this.IDRB.Size = new System.Drawing.Size(55, 17);
            this.IDRB.TabIndex = 2;
            this.IDRB.TabStop = true;
            this.IDRB.Text = "Por ID";
            this.IDRB.UseVisualStyleBackColor = true;
            this.IDRB.CheckedChanged += new System.EventHandler(this.IDRB_CheckedChanged);
            // 
            // NameRB
            // 
            this.NameRB.AutoSize = true;
            this.NameRB.Enabled = false;
            this.NameRB.Location = new System.Drawing.Point(210, 296);
            this.NameRB.Name = "NameRB";
            this.NameRB.Size = new System.Drawing.Size(79, 17);
            this.NameRB.TabIndex = 3;
            this.NameRB.TabStop = true;
            this.NameRB.Text = "Por nombre";
            this.NameRB.UseVisualStyleBackColor = true;
            this.NameRB.CheckedChanged += new System.EventHandler(this.NameRB_CheckedChanged);
            // 
            // ERB
            // 
            this.ERB.AutoSize = true;
            this.ERB.Enabled = false;
            this.ERB.Location = new System.Drawing.Point(347, 296);
            this.ERB.Name = "ERB";
            this.ERB.Size = new System.Drawing.Size(91, 17);
            this.ERB.TabIndex = 4;
            this.ERB.TabStop = true;
            this.ERB.Text = "Por existencia";
            this.ERB.UseVisualStyleBackColor = true;
            this.ERB.CheckedChanged += new System.EventHandler(this.ERB_CheckedChanged);
            // 
            // BrandRB
            // 
            this.BrandRB.AutoSize = true;
            this.BrandRB.Enabled = false;
            this.BrandRB.Location = new System.Drawing.Point(491, 296);
            this.BrandRB.Name = "BrandRB";
            this.BrandRB.Size = new System.Drawing.Size(73, 17);
            this.BrandRB.TabIndex = 5;
            this.BrandRB.TabStop = true;
            this.BrandRB.Text = "Por marca";
            this.BrandRB.UseVisualStyleBackColor = true;
            this.BrandRB.CheckedChanged += new System.EventHandler(this.BrandRB_CheckedChanged);
            // 
            // IDBox
            // 
            this.IDBox.Enabled = false;
            this.IDBox.Location = new System.Drawing.Point(86, 323);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 20);
            this.IDBox.TabIndex = 6;
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(210, 323);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 7;
            // 
            // EBox
            // 
            this.EBox.Enabled = false;
            this.EBox.Location = new System.Drawing.Point(347, 323);
            this.EBox.Name = "EBox";
            this.EBox.Size = new System.Drawing.Size(100, 20);
            this.EBox.TabIndex = 8;
            // 
            // BrandBox
            // 
            this.BrandBox.Enabled = false;
            this.BrandBox.Location = new System.Drawing.Point(491, 323);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(100, 20);
            this.BrandBox.TabIndex = 9;
            // 
            // FiltersCheck
            // 
            this.FiltersCheck.AutoSize = true;
            this.FiltersCheck.Location = new System.Drawing.Point(703, 163);
            this.FiltersCheck.Name = "FiltersCheck";
            this.FiltersCheck.Size = new System.Drawing.Size(53, 17);
            this.FiltersCheck.TabIndex = 10;
            this.FiltersCheck.Text = "Filtros";
            this.FiltersCheck.UseVisualStyleBackColor = true;
            this.FiltersCheck.CheckedChanged += new System.EventHandler(this.FiltersCheck_CheckedChanged);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(703, 200);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 11;
            this.ShowBtn.Text = "Mostrar";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // ReturnLbl
            // 
            this.ReturnLbl.AutoSize = true;
            this.ReturnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLbl.Location = new System.Drawing.Point(3, 0);
            this.ReturnLbl.Name = "ReturnLbl";
            this.ReturnLbl.Size = new System.Drawing.Size(26, 20);
            this.ReturnLbl.TabIndex = 12;
            this.ReturnLbl.Text = "←";
            this.ReturnLbl.Click += new System.EventHandler(this.ReturnLbl_Click);
            // 
            // ListPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.ReturnLbl);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.FiltersCheck);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.EBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.BrandRB);
            this.Controls.Add(this.ERB);
            this.Controls.Add(this.NameRB);
            this.Controls.Add(this.IDRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListPane";
            this.Size = new System.Drawing.Size(792, 372);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton IDRB;
        private System.Windows.Forms.RadioButton NameRB;
        private System.Windows.Forms.RadioButton ERB;
        private System.Windows.Forms.RadioButton BrandRB;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EBox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.CheckBox FiltersCheck;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Label ReturnLbl;
    }
}
