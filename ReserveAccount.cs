using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class ReserveAccount:BaseAccount


    {
        public ReserveAccount(string accountType, int accountNumber, string clientName)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.clientName = clientName;
        }




        public override void DisplayClientInfo()
        {
            base.DisplayClientInfo();

        }


    }
}
