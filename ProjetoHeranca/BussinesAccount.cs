using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHeranca
{
    internal class BussinesAccount: Account
    {
        public  double LoanLimit {  get; set; }

        public BussinesAccount() 
        {

        }

        public BussinesAccount(double loanLimit, int number, string holder, double balance) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit) 
            {
                LoanLimit += amount;
            }
        }
        
    }
}
