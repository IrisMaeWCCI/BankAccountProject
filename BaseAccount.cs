using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

#region
namespace BankAccountProject
{
    public class BaseAccount
    {
        //fields are private or protected
        //methods are public
        //2fields

            
         public void ClientName()
        {
            Console.WriteLine("What is your name?");
        }

        public void ClientAccountType()
        {
            Console.WriteLine("Which account would you like to select, press 1 for Checking 2 for Savings or 3 for Reserve Account");
        }
        public void ClientAccountNumber()
        {
            Console.WriteLine("What is your account number.");
        }

        private string clientName ;
        private string accountType ;
        private int accountNumber ;


    //    private string clientName = Console.ReadLine();
    //    private string accountType = Console.ReadLine();
    //    private int accountNumber = int.Parse(Console.ReadLine());


        //2properties

        public BaseAccount()
        {
            this.accountType = accountType;//is this correct
            this.accountNumber = accountNumber;// is this correct
            this.clientName = clientName;
            //or are these doing the same thing as whats happening below
            //whats the difference between Console ReadLine, this.type=type, and the value keyword
        }

        public BaseAccount(string accountType, int accountNumber, string clientName)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.clientName = clientName;
        }

        //1constructor, but I put in 2

        public string KindOfAccount
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public int AccountVerficationNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public virtual void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw today? Please select an amount.");
        }
        public virtual void Deposit()
        {
            Console.WriteLine("How much would you like to deposit//InsertNameHere?");
        }

        public virtual void DisplayClientInfo()
        {
            Console.WriteLine(clientName + accountType + accountNumber);
        }

            
    }
}




   









  
        // public string SeeInfo()
       // {
       //     get
       //     {
       //         return SeeInfo;
       //     }
       //     set
       //     {

       //     }
       //     }
       // }
       //// Dictionary<string, int> ClientInfoListed = new Dictionary<string, int>();//purpose of my dictionary

       // static virtual void ViewAccountBalance() 
       //     //private methods always going to be void because they are invisible anyway...so its like how can you return something that is unseen
       // {
       //     double viewAccountBalance;
       //     double viewOverDraftFees;
       //     double viewWithdrawls;
       //     double viewDeposits;
       //     double viewCalculatedInterest;
       // }

       // static virtual void MakeATransaction()
       // {
       //     double PayAFee;
       //     double WithdrawFunds;
       //     double DepositFunds;

       // }

       // static virtual void ExitAccount()
       // {
       //     Console.WriteLine("Please type exit, to leave.");
       //     Console.ReadLine();
       //  }
     
 
#endregion