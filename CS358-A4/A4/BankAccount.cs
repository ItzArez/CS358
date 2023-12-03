using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4BankExceptionGUI
{
    class BankAccount
    {
        //data members
        private decimal balance=0.0m;


        //method members
        //constructor
        public BankAccount()
        {//default constructor

        }
        public BankAccount(decimal amount)
        {//customized constructor
            if (amount > 0)
            {
                this.balance = amount;
            }
            else
            {
                //throw an NegativeBalanceException object.
                throw new NegativeBalanceException("The amount must be number > 0.00");
            }
        }
        //operation 1: withdraw
        public void Withdraw(decimal withdrawAmount)
        {
            //problem 1: withdraw a negative amount
            if (withdrawAmount < 0)
            {
                throw new NegativeWithdrawException("You withdrawed a negative amount.");
            }
            //do business logic
            this.balance -= withdrawAmount;

            //problem 2: over withdraw
            if (this.balance < 0)
            {
                this.balance += withdrawAmount;
                throw new NegativeBalanceException("You have less money than the withdrawl amount.");
            }
        }
        //operation 2: deposit
        public void Deposit(decimal depositAmount)
        {
            //problem 1: deposit a negative amount
            if (depositAmount < 0)
            {
                throw new NegativeDepositException("You're not able to deposit a negative amount.");
            }
            // updating the balance
            this.balance += depositAmount;
        }
        // operation 3: get balance
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
