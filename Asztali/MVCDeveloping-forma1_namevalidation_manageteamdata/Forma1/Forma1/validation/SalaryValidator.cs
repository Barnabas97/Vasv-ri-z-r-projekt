using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    public class SalaryValidator
    {
        private int salary;
        public SalaryValidator(int salary) {
            this.salary = salary;
        }
        public void validation()
        {
            if (IsDigit())
                throw new IsDigitExceptionExceptio("A fizetés csak szám lehet.");
            
        }

        public bool IsDigit()
        {
            char szam = Convert.ToChar(salary);
            if (!char.IsNumber(szam))
                return true;
            else
                return false;
        }
    }
}
