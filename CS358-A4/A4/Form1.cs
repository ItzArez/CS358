using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4BankExceptionGUI
{
    public partial class Form1 : Form
    {
        BankAccount myBank;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            try
            {
                decimal amount = decimal.Parse(textBox3.Text);
                myBank = new BankAccount(amount);
                btnBalance.Text = string.Format("{0:C}",amount);
            }
            catch(FormatException ex)
            {
                lbError.Text = "The amount must be numbers";
            }
            catch(NegativeBalanceException ex)
            {
                lbError.Text = ex.Message;//the constructor has the error message
            }
            catch(Exception ex)
            {
                lbError.Text = "The amount must be numbers > 0.0";
            }
        }
        private void displayBalance(decimal balance)
        {
            btnBalance.Text = string.Format("{0:C}", balance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbError.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                //get the amount
                decimal amount = decimal.Parse(textBox2.Text);

                //withdraw the amount
                myBank.Withdraw(amount);
                //update the balance
                displayBalance(myBank.GetBalance());

            }
            catch(FormatException ex)
            {
                lbError.Text = ex.Message;
            }
            catch (NegativeWithdrawException ex)
            {
                lbError.Text = ex.Message;
            }
            catch(Exception ex)
            {
                lbError.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(textBox1.Text);
                myBank.Deposit(amount);
                displayBalance(myBank.GetBalance());
            }
            catch (FormatException ex)
            {
                lbError.Text = ex.Message;
            }
            catch (NegativeWithdrawException ex)
            {
                lbError.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;
            }
        }
    }
}
