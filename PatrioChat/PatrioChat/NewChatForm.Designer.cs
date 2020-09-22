namespace PatrioChat
{
    partial class NewChatForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chatNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.participantsBox = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 0;
            // 
            // chatNameLabel
            // 
            this.chatNameLabel.AutoSize = true;
            this.chatNameLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatNameLabel.Location = new System.Drawing.Point(12, 9);
            this.chatNameLabel.Name = "chatNameLabel";
            this.chatNameLabel.Size = new System.Drawing.Size(137, 23);
            this.chatNameLabel.TabIndex = 1;
            this.chatNameLabel.Text = "Enter Chat Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose participants:";
            // 
            // participantsBox
            // 
            this.participantsBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantsBox.FormattingEnabled = true;
            this.participantsBox.ItemHeight = 23;
            this.participantsBox.Location = new System.Drawing.Point(162, 62);
            this.participantsBox.Name = "participantsBox";
            this.participantsBox.Size = new System.Drawing.Size(288, 257);
            this.participantsBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(16, 262);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(133, 57);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // NewChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 325);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.participantsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatNameLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "NewChatForm";
            this.Text = "NewChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label chatNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox participantsBox;
        private System.Windows.Forms.Button submitButton;
    }
}