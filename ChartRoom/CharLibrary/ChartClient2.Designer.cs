namespace CharLibrary
{
    partial class ChartClient2
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
            this.SentMessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.SentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SentMessageTextBox
            // 
            this.SentMessageTextBox.Location = new System.Drawing.Point(49, 444);
            this.SentMessageTextBox.Multiline = true;
            this.SentMessageTextBox.Name = "SentMessageTextBox";
            this.SentMessageTextBox.Size = new System.Drawing.Size(231, 84);
            this.SentMessageTextBox.TabIndex = 8;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(49, 31);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(355, 395);
            this.MessageTextBox.TabIndex = 7;
            this.MessageTextBox.Text = "";
            // 
            // SentButton
            // 
            this.SentButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SentButton.Location = new System.Drawing.Point(301, 444);
            this.SentButton.Name = "SentButton";
            this.SentButton.Size = new System.Drawing.Size(103, 81);
            this.SentButton.TabIndex = 6;
            this.SentButton.Text = "Sent";
            this.SentButton.UseVisualStyleBackColor = true;
            // 
            // ChartClient2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 562);
            this.Controls.Add(this.SentMessageTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SentButton);
            this.Name = "ChartClient2";
            this.Text = "ChartClient2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SentMessageTextBox;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Button SentButton;
    }
}