namespace Lab03
{
    partial class Bai3b
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
            btnConnect = new Button();
            btnSend = new Button();
            btnDisconnect = new Button();
            rtbSend = new RichTextBox();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(531, 37);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(531, 109);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(531, 174);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += button3_Click;
            // 
            // rtbSend
            // 
            rtbSend.Location = new Point(12, 37);
            rtbSend.Name = "rtbSend";
            rtbSend.Size = new Size(472, 166);
            rtbSend.TabIndex = 4;
            rtbSend.Text = "";
            // 
            // Bai3b
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 228);
            Controls.Add(rtbSend);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Name = "Bai3b";
            Text = "Bai3b";
            ResumeLayout(false);
        }

        #endregion
        private Button btnConnect;
        private Button btnSend;
        private Button btnDisconnect;
        private RichTextBox rtbSend;
    }
}