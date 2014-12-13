using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberEntryAddApp
{
    public partial class numberEntry : Form
    {
        List<double> numbers = new List<double>(); 
        public numberEntry()
        {
            InitializeComponent();
        }

        private void addNumberButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(enterNumberTextBox.Text);
            numbers.Add(number);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (double aNumber in numbers)
            {
                savedNumbersListBox.Items.Add(aNumber);
                total += aNumber;
            }
            sumResultTextBox.Text = total.ToString();

        }
    }
}
