﻿namespace Lab03
{
    partial class Bai06
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(47, 28);
            button1.Name = "button1";
            button1.Size = new Size(334, 44);
            button1.TabIndex = 0;
            button1.Text = "Open Server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(47, 107);
            button2.Name = "button2";
            button2.Size = new Size(334, 44);
            button2.TabIndex = 1;
            button2.Text = "Open new Client";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 188);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai06";
            Text = "Bai06";
            Load += Bai06_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}