using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer =
           new StreamWriter("important.txt"))


            BaseAccount AccountAction = new BaseAccount();
            AccountAction.Withdraw();
            AccountAction.DisplayClientInfo();
            BaseAccount Savings = new BaseAccount();
            Savings.Deposit();
            
            BaseAccount Checking = new BaseAccount();
            Checking.Deposit();
            BaseAccount ReserveAccount = new BaseAccount();
            ReserveAccount.Deposit();



        }
         
    }
}
