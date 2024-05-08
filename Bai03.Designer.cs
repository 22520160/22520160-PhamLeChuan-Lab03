namespace Lab03
{
    partial class Bai03
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
            btnTCPServer = new Button();
            btnTCPClient = new Button();
            SuspendLayout();
            // 
            // btnTCPServer
            // 
            btnTCPServer.Location = new Point(104, 53);
            btnTCPServer.Name = "btnTCPServer";
            btnTCPServer.Size = new Size(362, 41);
            btnTCPServer.TabIndex = 0;
            btnTCPServer.Text = "Open TCP server";
            btnTCPServer.UseVisualStyleBackColor = true;
            btnTCPServer.Click += btnTCPServer_Click;
            // 
            // btnTCPClient
            // 
            btnTCPClient.Location = new Point(104, 139);
            btnTCPClient.Name = "btnTCPClient";
            btnTCPClient.Size = new Size(362, 41);
            btnTCPClient.TabIndex = 1;
            btnTCPClient.Text = "Open new TCP client";
            btnTCPClient.UseVisualStyleBackColor = true;
            btnTCPClient.Click += btnTCPClient_Click;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 227);
            Controls.Add(btnTCPClient);
            Controls.Add(btnTCPServer);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTCPServer;
        private Button btnTCPClient;
    }
}