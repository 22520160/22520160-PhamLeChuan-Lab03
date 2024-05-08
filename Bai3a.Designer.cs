namespace Lab03
{
    partial class Bai3a
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
            btnListen.Location = new Point(539, 12);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // listViewCommand
            // 
            listViewCommand.Location = new Point(12, 56);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(621, 212);
            listViewCommand.TabIndex = 1;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            listViewCommand.View = View.List;
            // 
            // Bai3a
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 283);
            Controls.Add(listViewCommand);
            Controls.Add(btnListen);
            Name = "Bai3a";
            Text = "Bai3a";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private ListView listViewCommand;
    }
}