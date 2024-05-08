namespace Lab03
{
    partial class Lab_3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bai1 = new Button();
            bai2 = new Button();
            bai3 = new Button();
            bai6 = new Button();
            SuspendLayout();
            // 
            // bai1
            // 
            bai1.Location = new Point(51, 53);
            bai1.Name = "bai1";
            bai1.Size = new Size(100, 45);
            bai1.TabIndex = 0;
            bai1.Text = "Bài 1";
            bai1.UseVisualStyleBackColor = true;
            bai1.Click += bai1_Click;
            // 
            // bai2
            // 
            bai2.Location = new Point(237, 53);
            bai2.Name = "bai2";
            bai2.Size = new Size(100, 45);
            bai2.TabIndex = 1;
            bai2.Text = "Bài 2";
            bai2.UseVisualStyleBackColor = true;
            bai2.Click += bai2_Click;
            // 
            // bai3
            // 
            bai3.Location = new Point(51, 151);
            bai3.Name = "bai3";
            bai3.Size = new Size(100, 45);
            bai3.TabIndex = 2;
            bai3.Text = "Bài 3";
            bai3.UseVisualStyleBackColor = true;
            bai3.Click += bai3_Click;
            // 
            // bai6
            // 
            bai6.Location = new Point(237, 151);
            bai6.Name = "bai6";
            bai6.Size = new Size(100, 45);
            bai6.TabIndex = 3;
            bai6.Text = "Bài 6";
            bai6.UseVisualStyleBackColor = true;
            bai6.Click += bai6_Click_1;
            // 
            // Lab_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 237);
            Controls.Add(bai6);
            Controls.Add(bai3);
            Controls.Add(bai2);
            Controls.Add(bai1);
            Name = "Lab_3";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bai1;
        private Button bai2;
        private Button bai3;
        private Button bai6;
    }
}
