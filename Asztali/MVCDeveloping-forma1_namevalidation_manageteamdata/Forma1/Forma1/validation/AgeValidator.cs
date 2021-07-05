using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    /// <summary>
    /// Az életkor minage és maxage közé kell essen
    /// Készítse el a validation metódust, amely ellenőrzi a feltételt
    /// Adjon vissza igaz értéket, ha az age megfelelő.
    /// <exception name="AgeIsLessThanMinAgeExeption">Ha az age kisebb mint a minage</exception>
    /// <exception name="AgeIsLessThanMaxAgeExeption">Ha az age nagyobb mint a maxage</exception>
    /// </summary>
    public class AgeValidator
    {
        private int age;
        private int minage;
        private int maxage;

        public AgeValidator(int age, int minage, int maxage)
        {
            this.age = age;
            this.minage = minage;
            this.maxage = maxage;
        }
        public void validation()
        {
            if (IsEmptyAge())
                throw new AgeIsEmptyException("A kor nem lehet üres!");
            if (LessAgeThanMin())
                throw new AgeIsLessThanMinException("A kor nem lehet kevesebb mint a minage");
            if (MoreThanMaxAge())
                throw new AgeIsMoreThanMaxException("A kor nem lehet nagyobb mint a maxage");
        }
        private bool IsEmptyAge()
        {
            if (age == null)
                return true;
            else
                return false;
        }
        private bool LessAgeThanMin()
        {
            if (age < minage)
                return true;
            else
                return false;
        }
        private bool MoreThanMaxAge()
        {
            if (age > maxage)
                return true;
            else
                return false;
        }
    }
}
