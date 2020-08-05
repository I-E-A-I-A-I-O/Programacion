namespace Programa_CRUD
{
    partial class AddPane
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.EBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(354, 331);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Añadir";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // EBox
            // 
            this.EBox.Location = new System.Drawing.Point(392, 194);
            this.EBox.Name = "EBox";
            this.EBox.Size = new System.Drawing.Size(100, 20);
            this.EBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(239, 194);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 6;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(89, 194);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 20);
            this.IDBox.TabIndex = 7;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(538, 194);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(100, 20);
            this.BrandBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Añade un producto al inventario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "←";
            this.toolTip1.SetToolTip(this.label6, "Volver a la ventana principal");
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPane";
            this.Size = new System.Drawing.Size(825, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox EBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
