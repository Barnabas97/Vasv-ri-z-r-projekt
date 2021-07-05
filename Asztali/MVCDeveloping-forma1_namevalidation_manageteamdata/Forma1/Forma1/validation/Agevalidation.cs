
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    public class Agevalidation
    {
        private int age;
        private int minage;
        private int maxage;


        public Agevalidation(int age, int minage, int maxage)
        {
            this.age = age;
            this.minage = minage;
            this.maxage = maxage;
        }

        public void agevalidation()
        {
            if (isAgeNull())
                throw new NameNotValidNameIsEmptyException("A név nem lehet üres!");
            if (isFistLetterNotUppercase())

                throw new NameNotValidFirstLetterProblemException("A név nagy kezdőbetűvel kell kezdőjön!");
            if (isNextToFirstLetterIsNotLower())
                throw new NextToFirstLetterIsNotLowerException("A nagybetűk után kis betűket");
        }


        private bool isEmtyAge()
        {
            if (string.IsNullOrEmpty(Convert.ToString(age)))

                return true;
            else

                return false;

        }
    }
}
