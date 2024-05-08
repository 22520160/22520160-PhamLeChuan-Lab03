namespace Lab03
{
    partial class Bai4a
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 26);
            button1.Name = "button1";
            button1.Size = new Size(128, 41);
            button1.TabIndex = 0;
            button1.Text = "Listen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(368, 26);
            button2.Name = "button2";
            button2.Size = new Size(121, 41);
            button2.TabIndex = 1;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 87);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(498, 219);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Bai4a
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 316);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai4a";
            Text = "Bai6a";
            Load += Bai4a_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}