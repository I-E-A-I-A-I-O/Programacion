namespace Programa_CRUD
{
    partial class MainPane
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ListBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manejo de inventario de productos";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkRed;
            this.AddBtn.Location = new System.Drawing.Point(295, 142);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(67, 34);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Añadir";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ListBtn
            // 
            this.ListBtn.BackColor = System.Drawing.Color.Red;
            this.ListBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListBtn.Location = new System.Drawing.Point(379, 211);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(70, 34);
            this.ListBtn.TabIndex = 2;
            this.ListBtn.Text = "Listado";
            this.ListBtn.UseVisualStyleBackColor = false;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.IndianRed;
            this.UpdateBtn.Location = new System.Drawing.Point(295, 275);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 34);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Modificar";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Location = new System.Drawing.Point(379, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ListBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainPane";
            this.Size = new System.Drawing.Size(818, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button button4;
    }
}
