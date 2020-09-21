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
            this.Chats = new System.Windows.Forms.ListBox();
            this.messagesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.Window;
            this.input.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.input.Location = new System.Drawing.Point(138, 395);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(569, 52);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.chatsBox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.Window;
            this.SendButton.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(713, 395);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 52);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Chats
            // 
            this.Chats.BackColor = System.Drawing.SystemColors.Window;
            this.Chats.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chats.FormattingEnabled = true;
            this.Chats.ItemHeight = 28;
            this.Chats.Location = new System.Drawing.Point(12, 23);
            this.Chats.Name = "Chats";
            this.Chats.Size = new System.Drawing.Size(120, 424);
            this.Chats.TabIndex = 2;
            this.Chats.SelectedIndexChanged += new System.EventHandler(this.chatsBox_SelectedIndexChanged);
            // 
            // messagesBox
            // 
            this.messagesBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesBox.FormattingEnabled = true;
            this.messagesBox.ItemHeight = 23;
            this.messagesBox.Location = new System.Drawing.Point(138, 23);
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.Size = new System.Drawing.Size(650, 349);
            this.messagesBox.TabIndex = 3;
            this.messagesBox.SelectedIndexChanged += new System.EventHandler(this.messagesBox_SelectedIndexChanged);
            // 
            // PatrioChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messagesBox);
            this.Controls.Add(this.Chats);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.input);
            this.Name = "PatrioChat";
            this.Text = "PatrioChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox Chats;
        private System.Windows.Forms.ListBox messagesBox;
    }
}

