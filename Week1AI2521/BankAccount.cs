using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1AI2521
{
    internal class BankAccount
    {
        public string accountNumber;
        public int balance;
        public Customer owner;

        public BankAccount(string accountNumber, int balance, Customer owner)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.owner = owner;
        }

        public void Withdraw(int amount)
        {
            if(amount < balance || amount == balance)
            {
                balance -= amount;
                Console.WriteLine($"You have withdrawn {amount} from your account. Your new balance is {balance}");
            }else if(balance < amount)
            {
                if(owner.age > 18 && amount - balance <= 500 && owner.isStudent == false)
                {
                    balance -= amount;
                    Console.WriteLine($"You have withdrawn {amount} from your account. Your new balance is {balance}");
                }
                else
                {
                    Console.WriteLine("You cannot withdraw this amount");
                }
            }
            
        }
    }
}
