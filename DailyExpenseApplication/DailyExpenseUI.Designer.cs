namespace DailyExpenseApplication
{
    partial class DailyExpenseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoryComboBoxD = new System.Windows.Forms.ComboBox();
            this.perticularTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showButtonSummary = new System.Windows.Forms.Button();
            this.maxExpenseTextBox = new System.Windows.Forms.Label();
            this.maximumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.expenseListBox = new System.Windows.Forms.ListBox();
            this.showButtonExpense = new System.Windows.Forms.Button();
            this.categoryComboBoxV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalExpenseTextBoxE = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.categoryComboBoxD);
            this.groupBox1.Controls.Add(this.perticularTextBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(196, 191);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // categoryComboBoxD
            // 
            this.categoryComboBoxD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBoxD.FormattingEnabled = true;
            this.categoryComboBoxD.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBoxD.Location = new System.Drawing.Point(85, 60);
            this.categoryComboBoxD.Name = "categoryComboBoxD";
            this.categoryComboBoxD.Size = new System.Drawing.Size(186, 21);
            this.categoryComboBoxD.TabIndex = 2;
            // 
            // perticularTextBox
            // 
            this.perticularTextBox.Location = new System.Drawing.Point(85, 96);
            this.perticularTextBox.Multiline = true;
            this.perticularTextBox.Name = "perticularTextBox";
            this.perticularTextBox.Size = new System.Drawing.Size(186, 84);
            this.perticularTextBox.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(85, 26);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(186, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Particular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showButtonSummary);
            this.groupBox2.Controls.Add(this.maxExpenseTextBox);
            this.groupBox2.Controls.Add(this.maximumTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.totalExpenseTextBox);
            this.groupBox2.Location = new System.Drawing.Point(21, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summary";
            // 
            // showButtonSummary
            // 
            this.showButtonSummary.Location = new System.Drawing.Point(196, 19);
            this.showButtonSummary.Name = "showButtonSummary";
            this.showButtonSummary.Size = new System.Drawing.Size(75, 23);
            this.showButtonSummary.TabIndex = 5;
            this.showButtonSummary.Text = "Show";
            this.showButtonSummary.UseVisualStyleBackColor = true;
            this.showButtonSummary.Click += new System.EventHandler(this.showButtonSummary_Click);
            // 
            // maxExpenseTextBox
            // 
            this.maxExpenseTextBox.AutoSize = true;
            this.maxExpenseTextBox.Location = new System.Drawing.Point(15, 89);
            this.maxExpenseTextBox.Name = "maxExpenseTextBox";
            this.maxExpenseTextBox.Size = new System.Drawing.Size(95, 13);
            this.maxExpenseTextBox.TabIndex = 0;
            this.maxExpenseTextBox.Text = "Maximum Expense";
            // 
            // maximumTextBox
            // 
            this.maximumTextBox.Location = new System.Drawing.Point(117, 86);
            this.maximumTextBox.Name = "maximumTextBox";
            this.maximumTextBox.Size = new System.Drawing.Size(154, 20);
            this.maximumTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Expense";
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(117, 52);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(154, 20);
            this.totalExpenseTextBox.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.expenseListBox);
            this.groupBox3.Controls.Add(this.showButtonExpense);
            this.groupBox3.Controls.Add(this.categoryComboBoxV);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.totalExpenseTextBoxE);
            this.groupBox3.Location = new System.Drawing.Point(342, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 395);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Categorywise Expense";
            // 
            // expenseListBox
            // 
            this.expenseListBox.FormattingEnabled = true;
            this.expenseListBox.Location = new System.Drawing.Point(77, 85);
            this.expenseListBox.Name = "expenseListBox";
            this.expenseListBox.Size = new System.Drawing.Size(261, 251);
            this.expenseListBox.TabIndex = 10;
            // 
            // showButtonExpense
            // 
            this.showButtonExpense.Location = new System.Drawing.Point(263, 53);
            this.showButtonExpense.Name = "showButtonExpense";
            this.showButtonExpense.Size = new System.Drawing.Size(75, 23);
            this.showButtonExpense.TabIndex = 9;
            this.showButtonExpense.Text = "Show";
            this.showButtonExpense.UseVisualStyleBackColor = true;
            this.showButtonExpense.Click += new System.EventHandler(this.showButtonExpense_Click);
            // 
            // categoryComboBoxV
            // 
            this.categoryComboBoxV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBoxV.FormattingEnabled = true;
            this.categoryComboBoxV.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBoxV.Location = new System.Drawing.Point(113, 26);
            this.categoryComboBoxV.Name = "categoryComboBoxV";
            this.categoryComboBoxV.Size = new System.Drawing.Size(225, 21);
            this.categoryComboBoxV.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category";
            // 
            // totalExpenseTextBoxE
            // 
            this.totalExpenseTextBoxE.Location = new System.Drawing.Point(232, 350);
            this.totalExpenseTextBoxE.Name = "totalExpenseTextBoxE";
            this.totalExpenseTextBoxE.Size = new System.Drawing.Size(106, 20);
            this.totalExpenseTextBoxE.TabIndex = 11;
            // 
            // DailyExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 431);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DailyExpenseForm";
            this.Text = "Daily Expense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox categoryComboBoxD;
        private System.Windows.Forms.TextBox perticularTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButtonSummary;
        private System.Windows.Forms.Label maxExpenseTextBox;
        private System.Windows.Forms.TextBox maximumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.ComboBox categoryComboBoxV;
        private System.Windows.Forms.Button showButtonExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalExpenseTextBoxE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox expenseListBox;
    }
}

