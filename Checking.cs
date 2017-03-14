using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking:BaseAccount
    {

        private string clientName;
        private string accountType;
        private int accountNumber;

        private void ClientInformation()//I'm making this void bc no one is calling it...and yet I'll want to call it in other classes. Is it better to place it inside of main? Do I use a property to gain access to this private method?
        {
            //To display client information
            clientName = Console.ReadLine();
            accountType = Console.ReadLine();
            accountNumber = int.Parse(Console.ReadLine());
        }
        public override void DisplayClientInfo()
        {
            base.DisplayClientInfo();
        }

    }
}
