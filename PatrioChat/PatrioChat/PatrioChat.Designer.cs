using System;

namespace PatrioChat
{
    partial class PatrioChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatrioChat));
            this.input = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.chatsBox = new System.Windows.Forms.ListBox();
            this.messagesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.Window;
            this.input.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.input.Location = new System.Drawing.Point(284, 394);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(537, 53);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.chatsBox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.Window;
            this.SendButton.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(827, 394);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 53);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // chatsBox
            // 
            this.chatsBox.BackColor = System.Drawing.SystemColors.Window;
            this.chatsBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatsBox.FormattingEnabled = true;
            this.chatsBox.ItemHeight = 28;
            this.chatsBox.Location = new System.Drawing.Point(12, 23);
            this.chatsBox.Name = "chatsBox";
            this.chatsBox.Size = new System.Drawing.Size(266, 424);
            this.chatsBox.TabIndex = 2;
            this.chatsBox.SelectedIndexChanged += new System.EventHandler(this.chatsBox_SelectedIndexChanged);
            // 
            // messagesBox
            // 
            this.messagesBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesBox.FormattingEnabled = true;
            this.messagesBox.ItemHeight = 23;
            this.messagesBox.Location = new System.Drawing.Point(284, 23);
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.Size = new System.Drawing.Size(618, 349);
            this.messagesBox.TabIndex = 3;
            this.messagesBox.SelectedIndexChanged += new System.EventHandler(this.messagesBox_SelectedIndexChanged);
            // 
            // PatrioChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.messagesBox);
            this.Controls.Add(this.chatsBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatrioChat";
            this.Text = "PatrioChat";
            this.Load += new System.EventHandler(this.PatrioChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox messagesBox;
        private System.Windows.Forms.ListBox chatsBox;
    }
}

