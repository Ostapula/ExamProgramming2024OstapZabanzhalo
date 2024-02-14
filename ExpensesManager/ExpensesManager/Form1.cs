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

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var path = textBox1.Text;
                path = "C:\\Users\\ostap\\source\\repos\\ExamProgramming2024OstapZabanzhalo\\ExpensesManager\\expenses.txt";
                var content = File.ReadAllText(path);
                content = content.Replace("|", "\t");
                textBox2.Text = content;

            } catch {
                MessageBox.Show("The file is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var path = textBox1.Text;
                path = "C:\\Users\\ostap\\source\\repos\\ExamProgramming2024OstapZabanzhalo\\ExpensesManager\\expenses.txt";
                var lines = File.ReadAllLines(path);
                decimal totalExpenses = 0;
                var numberOfCategories = 0;
                var totalDatesOfPayments = 0;
                var dates = new List<String>();
                var categories = new List<String>();
                for (int i = 1; i < lines.Length; i++)
                {
                    var line = lines[i];
                    var split = line.Split("|");
                    totalExpenses += decimal.Parse(split[1]);
                    if (!dates.Contains(split[0]))
                    {
                        totalDatesOfPayments++;
                    }
                    if (!categories.Contains(split[2]))
                    {
                        numberOfCategories++;
                    }
                    dates.Add(split[0]);
                    categories.Add(split[2]);
                    
                }
                textBox2.Text = "";
                textBox2.Text = $"Total expenses {totalExpenses}{Environment.NewLine}Number of categories: {numberOfCategories}{Environment.NewLine}Total dates of payment: {totalDatesOfPayments}";

            } catch {
                MessageBox.Show("The file is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
