using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interestCalculator
{
    public partial class Form1 : Form
    {
        double totInterest;
        double months;
        double interest;
        double amount;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(month_txt.Text))|| 
                (String.IsNullOrEmpty(interest_txt.Text))|| 
                (String.IsNullOrEmpty(amount_txt.Text)))
            {
                MessageBox.Show("Invalided!", "Error");
                Close();
            }
            months = Convert.ToDouble(month_txt.Text);
            interest = (Convert.ToDouble(interest_txt.Text))/100;
            amount = Convert.ToDouble(amount_txt.Text);

            totInterest = amount * (Math.Pow(1 + interest, months) - 1);

            MessageBox.Show("Total interest: " + totInterest.ToString("#.##"), "Info");
            Close();
        }
    }
}