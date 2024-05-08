namespace Lab03
{
    partial class Bai1a
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
            label1 = new Label();
            label2 = new Label();
            tbPort = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 78);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Port";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 1;
            label2.Text = "Received Message";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(109, 75);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(223, 27);
            tbPort.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 210);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 228);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(545, 73);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Listen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnListen_Click;
            // 
            // Bai1a
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(tbPort);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai1a";
            Text = "Bai1a";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbPort;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}