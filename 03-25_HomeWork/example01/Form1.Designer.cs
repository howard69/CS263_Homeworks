namespace Example01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.baseSalaryLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.employeeCatagory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.performanceTextBox = new System.Windows.Forms.TextBox();
            this.performanceLabel = new System.Windows.Forms.Label();
            this.SalesCountTextBox = new System.Windows.Forms.TextBox();
            this.SalesCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(372, 170);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 69);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "新增員工";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idLabel.Location = new System.Drawing.Point(40, 46);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(105, 28);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "員工編號:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel.Location = new System.Drawing.Point(40, 85);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(105, 28);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "員工姓名:";
            // 
            // baseSalaryLabel
            // 
            this.baseSalaryLabel.AutoSize = true;
            this.baseSalaryLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.baseSalaryLabel.Location = new System.Drawing.Point(40, 120);
            this.baseSalaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseSalaryLabel.Name = "baseSalaryLabel";
            this.baseSalaryLabel.Size = new System.Drawing.Size(105, 28);
            this.baseSalaryLabel.TabIndex = 3;
            this.baseSalaryLabel.Text = "基本薪資:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idTextBox.Location = new System.Drawing.Point(160, 38);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(108, 36);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(158, 79);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(108, 36);
            this.nameTextBox.TabIndex = 5;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.baseSalaryTextBox.Location = new System.Drawing.Point(158, 118);
            this.baseSalaryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.Size = new System.Drawing.Size(108, 36);
            this.baseSalaryTextBox.TabIndex = 6;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infoRichTextBox.Location = new System.Drawing.Point(45, 243);
            this.infoRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(453, 283);
            this.infoRichTextBox.TabIndex = 7;
            this.infoRichTextBox.Text = "";
            // 
            // employeeCatagory
            // 
            this.employeeCatagory.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.employeeCatagory.FormattingEnabled = true;
            this.employeeCatagory.Items.AddRange(new object[] {
            "一般員工",
            "業務",
            "經理"});
            this.employeeCatagory.Location = new System.Drawing.Point(381, 42);
            this.employeeCatagory.Margin = new System.Windows.Forms.Padding(2);
            this.employeeCatagory.Name = "employeeCatagory";
            this.employeeCatagory.Size = new System.Drawing.Size(108, 32);
            this.employeeCatagory.TabIndex = 8;
            this.employeeCatagory.SelectedIndexChanged += new System.EventHandler(this.employeeCatagory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(272, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "員工類型:";
            // 
            // performanceTextBox
            // 
            this.performanceTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.performanceTextBox.Location = new System.Drawing.Point(158, 158);
            this.performanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.performanceTextBox.Name = "performanceTextBox";
            this.performanceTextBox.Size = new System.Drawing.Size(108, 36);
            this.performanceTextBox.TabIndex = 11;
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.performanceLabel.Location = new System.Drawing.Point(40, 160);
            this.performanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(105, 28);
            this.performanceLabel.TabIndex = 10;
            this.performanceLabel.Text = "業務績效:";
            // 
            // SalesCountTextBox
            // 
            this.SalesCountTextBox.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SalesCountTextBox.Location = new System.Drawing.Point(158, 203);
            this.SalesCountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SalesCountTextBox.Name = "SalesCountTextBox";
            this.SalesCountTextBox.Size = new System.Drawing.Size(108, 36);
            this.SalesCountTextBox.TabIndex = 13;
            // 
            // SalesCountLabel
            // 
            this.SalesCountLabel.AutoSize = true;
            this.SalesCountLabel.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SalesCountLabel.Location = new System.Drawing.Point(40, 206);
            this.SalesCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalesCountLabel.Name = "SalesCountLabel";
            this.SalesCountLabel.Size = new System.Drawing.Size(114, 28);
            this.SalesCountLabel.TabIndex = 12;
            this.SalesCountLabel.Text = "Sales數量:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 566);
            this.Controls.Add(this.SalesCountTextBox);
            this.Controls.Add(this.SalesCountLabel);
            this.Controls.Add(this.performanceTextBox);
            this.Controls.Add(this.performanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeCatagory);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.baseSalaryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SalaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label baseSalaryLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.ComboBox employeeCatagory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox performanceTextBox;
        private System.Windows.Forms.Label performanceLabel;
        private System.Windows.Forms.TextBox SalesCountTextBox;
        private System.Windows.Forms.Label SalesCountLabel;
    }
}

