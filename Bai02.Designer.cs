namespace Lab03
{
    partial class Bai02
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
            btnListen = new Button();
            listViewCommand = new ListView();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(249, 25);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += StartListen;
            // 
            // listViewCommand
            // 
            listViewCommand.Location = new Point(3, 75);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(600, 189);
            listViewCommand.TabIndex = 1;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            listViewCommand.View = View.List;
            listViewCommand.SelectedIndexChanged += listViewCommand_SelectedIndexChanged;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 268);
            Controls.Add(listViewCommand);
            Controls.Add(btnListen);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private ListView listViewCommand;
    }
}