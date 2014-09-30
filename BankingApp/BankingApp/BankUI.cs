using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class BankUI : Form
    {
        private Account anAccount;

        private double amount;

        public BankUI()
        {
            InitializeComponent();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account(accountNumberTextBox.Text,customerNameTextBox.Text);
            MessageBox.Show(@"Account has been created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
           {
                amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Deposit(amount);
                MessageBox.Show(@"Amount has been deposited");
            }
            else
            {
                MessageBox.Show(@"Please create an account first");
            }
        }
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (anAccount!=null)
            {
                amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Withdraw(amount);
                MessageBox.Show(@"Amount has been withdrawn");
            }
            else
            {
                MessageBox.Show(@"Please create an account first");
            }
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.AccountName + " your account no : " +anAccount.AccountNumber + " and it's balance is : " + anAccount.Balance);
        }
    }
}
