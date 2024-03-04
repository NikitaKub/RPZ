using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class ParameterizeMethod
    {
        public void Example()
        {
            Accounting accounting = new Accounting(1000);
            accounting.PaySallaryForSenior();
        }

        public void RefactoredExample()
        {
            RefactoringAccounting accounting = new RefactoringAccounting(1000);
            accounting.PaySallary(25);
        }
    }

    //<----------- Ex 2 ----------->

    // Parameterize Method

    class Accounting
    {
        private int sallary;

        public Accounting(int sallary) { this.sallary = sallary; }

        public int PaySallaryForSenior()
        {
            return sallary + ((sallary / 100) * 25);
        }

        public int PaySallaryForJunior()
        {
            return sallary + ((sallary / 100) * 0);
        }
    }

    //<----------- Refactored ----------->

    class RefactoringAccounting
    {
        private int sallary;

        public RefactoringAccounting(int sallary) { this.sallary = sallary; }

        public int PaySallary(int percentage)
        {
            return sallary + ((sallary / 100) * percentage);
        }
    }
}
