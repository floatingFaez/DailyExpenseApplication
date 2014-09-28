using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseApplication
{
    public partial class DailyExpenseForm : Form
    {
        private string fileLocation = @"dailyExpense.csv";
        public DailyExpenseForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != "" && categoryComboBoxD.Text != "" && perticularTextBox.Text != "")
            {
                string amount = amountTextBox.Text;
                string category = categoryComboBoxD.Text;
                string perticular = perticularTextBox.Text;
                List<string> aExpenseRecord = new List<string>();

                FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
                CsvFileWriter aCsvFileWriter = new CsvFileWriter(aFileStream);
                aExpenseRecord.Add(amount);
                aExpenseRecord.Add(category);
                aExpenseRecord.Add(perticular);
                aCsvFileWriter.WriteRow(aExpenseRecord);

                amountTextBox.Text = string.Empty;
                categoryComboBoxD.Text = string.Empty;
                perticularTextBox.Text = string.Empty;
                categoryComboBoxD.Text = string.Empty;
                MessageBox.Show(@"Data has been saved successfully");
                aFileStream.Close();
            }
            else
                MessageBox.Show(@"Fill all of the field");
            
        }

        private void showButtonSummary_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aExpenseRecord = new List<string>();
            List<double> amountM = new List<double>();
            double totalAmount = 0;

            while (aReader.ReadRow(aExpenseRecord))
            {
                int amount = Convert.ToInt32(aExpenseRecord[0]);
                amountM.Add(amount);
                totalAmount+= amount;
            }
            double maximum=amountM.Max();

            totalExpenseTextBox.Text = Convert.ToString(totalAmount);
            maximumTextBox.Text = Convert.ToString(maximum);

            aStream.Close();
        }

        private void showButtonExpense_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation,FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> aExpenseRecord = new List<string>();
            List<string> amount = new List<string>();
            string category = categoryComboBoxV.Text;
            int totalAmount = 0;
            expenseListBox.Items.Clear();
            while (aCsvFileReader.ReadRow(aExpenseRecord))
            {
                if (aExpenseRecord[1] == category)
                {
                    expenseListBox.Items.Add(aExpenseRecord[0]);
                    totalAmount += Convert.ToInt32(aExpenseRecord[0]);
                }
            }
            totalExpenseTextBoxE.Text = Convert.ToString(totalAmount);
  
            aFileStream.Close();
        }
    }
}
