﻿namespace Multiple_concurrencia
{
    partial class MainWindow
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
            this.main_pane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.thread_log = new System.Windows.Forms.TextBox();
            this.NumberOfThreads = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.main_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // main_pane
            // 
            this.main_pane.Controls.Add(this.label2);
            this.main_pane.Controls.Add(this.NumberOfThreads);
            this.main_pane.Controls.Add(this.label1);
            this.main_pane.Controls.Add(this.stop_btn);
            this.main_pane.Controls.Add(this.start_btn);
            this.main_pane.Controls.Add(this.thread_log);
            this.main_pane.Location = new System.Drawing.Point(0, 0);
            this.main_pane.Name = "main_pane";
            this.main_pane.Size = new System.Drawing.Size(801, 450);
            this.main_pane.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thread log";
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(243, 400);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(99, 23);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop all threads";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(461, 400);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(97, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start threads";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // thread_log
            // 
            this.thread_log.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.thread_log.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thread_log.Location = new System.Drawing.Point(26, 90);
            this.thread_log.MaxLength = 1000000;
            this.thread_log.Multiline = true;
            this.thread_log.Name = "thread_log";
            this.thread_log.ReadOnly = true;
            this.thread_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.thread_log.Size = new System.Drawing.Size(750, 295);
            this.thread_log.TabIndex = 0;
            // 
            // NumberOfThreads
            // 
            this.NumberOfThreads.Location = new System.Drawing.Point(656, 50);
            this.NumberOfThreads.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumberOfThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfThreads.Name = "NumberOfThreads";
            this.NumberOfThreads.Size = new System.Drawing.Size(120, 20);
            this.NumberOfThreads.TabIndex = 4;
            this.NumberOfThreads.ThousandsSeparator = true;
            this.NumberOfThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of threads";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_pane);
            this.Name = "MainWindow";
            this.Text = "Prueba multiple concurrencia";
            this.main_pane.ResumeLayout(false);
            this.main_pane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfThreads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_pane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox thread_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberOfThreads;
    }
}

