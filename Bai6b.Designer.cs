namespace Lab03
{
    partial class Bai6b
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
            button3 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(421, 324);
            button1.Name = "button1";
            button1.Size = new Size(85, 29);
            button1.TabIndex = 0;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 255);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(191, 364);
            button3.Name = "button3";
            button3.Size = new Size(103, 38);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(494, 200);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 324);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 27);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 232);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 301);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Message";
            // 
            // Bai6b
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 414);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai6b";
            Text = "Bai6b";
            Load += Bai4b_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}