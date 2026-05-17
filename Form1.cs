using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool membershipType(out decimal membershipRate)
        {
            membershipRate = 0m;

            if (radAdult.Checked)
            {
                membershipRate = 40m;
            }
            else if (radChild.Checked)
            {
                membershipRate = 20m;
            }
            else if (radStudent.Checked)
            {

                membershipRate = 25m;
            }
            else if (radSenior.Checked)
            {
                membershipRate = 30m;
            }
            else
            {
                MessageBox.Show("Error select a membership type!");
                return false;
            }
            return true;
        }
        private decimal Options()
        {
            decimal option = 0;
            if (chkYoga.Checked)
            {
                option += 10m;
            }
            if (chkKarate.Checked)
            {
                option += 30m;
            }
            if (chkPersonalTrainer.Checked)
            {
                option += 50m;
            }
            return option;
        }
        private bool amountOfMonths (out int months)
        {
            months = 0;
            if(!int.TryParse(txtMonths.Text, out months))
            {
                MessageBox.Show("Enter a valid number of months!");
                return false;
            }
      

            if(months <= 0)
            {
                MessageBox.Show("Enter valid numbers of months!");
                return false;
            }
            return true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radAdult.Checked = false;
            radChild.Checked = false;
            radStudent.Checked = false;
            radSenior.Checked = false;

            chkYoga.Checked = false;
            chkKarate.Checked = false;
            chkPersonalTrainer.Checked = false;

            txtMonths.Clear();
            txtMonthlyFee.Clear();
            txtTotal.Clear();
            txtMonths.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal membershipRate;
            int months;

            if (!membershipType(out membershipRate))
            {
                return;
            }
            if(!amountOfMonths(out months))
            {
                return;
            }
            decimal totalOptions = Options();
            decimal monthlyFee = membershipRate + totalOptions;
            decimal totalFee = months * monthlyFee;

            txtMonthlyFee.Text = monthlyFee.ToString("c");
            txtTotal.Text = totalFee.ToString("c");
        }
    }
}

