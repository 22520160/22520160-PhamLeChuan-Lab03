namespace Lab03
{
    partial class Bai1b
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
            tbIP = new TextBox();
            tbPort = new TextBox();
            rtbMessage = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSend = new Button();
            SuspendLayout();
            // 
            // tbIP
            // 
            tbIP.Location = new Point(92, 55);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(316, 27);
            tbIP.TabIndex = 0;
            // 
            // tbPort
            // 
            tbPort.Location = new Point(560, 55);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(125, 27);
            tbPort.TabIndex = 1;
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(9, 164);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(763, 217);
            rtbMessage.TabIndex = 2;
            rtbMessage.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 32);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "IP Remote host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Message";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 32);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = "Port";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 409);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Bai1b
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbMessage);
            Controls.Add(tbPort);
            Controls.Add(tbIP);
            Name = "Bai1b";
            Text = "Bai1b";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIP;
        private TextBox tbPort;
        private RichTextBox rtbMessage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSend;
    }
}