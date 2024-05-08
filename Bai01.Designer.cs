namespace Lab03
{
    partial class Bai01
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
            btnUDPServer = new Button();
            btnUDPClient = new Button();
            SuspendLayout();
            // 
            // btnUDPServer
            // 
            btnUDPServer.Location = new Point(61, 86);
            btnUDPServer.Name = "btnUDPServer";
            btnUDPServer.Size = new Size(143, 46);
            btnUDPServer.TabIndex = 0;
            btnUDPServer.Text = "UDP Server";
            btnUDPServer.UseVisualStyleBackColor = true;
            btnUDPServer.Click += btnUDPServer_Click;
            // 
            // btnUDPClient
            // 
            btnUDPClient.Location = new Point(329, 86);
            btnUDPClient.Name = "btnUDPClient";
            btnUDPClient.Size = new Size(160, 46);
            btnUDPClient.TabIndex = 1;
            btnUDPClient.Text = "UDP Client";
            btnUDPClient.UseVisualStyleBackColor = true;
            btnUDPClient.Click += btnUDPClient_Click;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 217);
            Controls.Add(btnUDPClient);
            Controls.Add(btnUDPServer);
            Name = "Bai01";
            Text = "Bai01";
            Load += Bai01_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUDPServer;
        private Button btnUDPClient;
    }
}