namespace Programa_CRUD
{
    partial class UpdatePane
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UColumnBox = new System.Windows.Forms.TextBox();
            this.CColumnBox = new System.Windows.Forms.TextBox();
            this.NDataBox = new System.Windows.Forms.TextBox();
            this.ConditionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columna a actualizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nuevo dato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Columna condicion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UColumnBox
            // 
            this.UColumnBox.Location = new System.Drawing.Point(92, 217);
            this.UColumnBox.Name = "UColumnBox";
            this.UColumnBox.Size = new System.Drawing.Size(102, 20);
            this.UColumnBox.TabIndex = 5;
            // 
            // CColumnBox
            // 
            this.CColumnBox.Location = new System.Drawing.Point(387, 217);
            this.CColumnBox.Name = "CColumnBox";
            this.CColumnBox.Size = new System.Drawing.Size(100, 20);
            this.CColumnBox.TabIndex = 6;
            // 
            // NDataBox
            // 
            this.NDataBox.Location = new System.Drawing.Point(240, 217);
            this.NDataBox.Name = "NDataBox";
            this.NDataBox.Size = new System.Drawing.Size(100, 20);
            this.NDataBox.TabIndex = 7;
            // 
            // ConditionBox
            // 
            this.ConditionBox.Location = new System.Drawing.Point(549, 217);
            this.ConditionBox.Name = "ConditionBox";
            this.ConditionBox.Size = new System.Drawing.Size(100, 20);
            this.ConditionBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Condicion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "←";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // UpdatePane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConditionBox);
            this.Controls.Add(this.NDataBox);
            this.Controls.Add(this.CColumnBox);
            this.Controls.Add(this.UColumnBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePane";
            this.Size = new System.Drawing.Size(810, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UColumnBox;
        private System.Windows.Forms.TextBox CColumnBox;
        private System.Windows.Forms.TextBox NDataBox;
        private System.Windows.Forms.TextBox ConditionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
