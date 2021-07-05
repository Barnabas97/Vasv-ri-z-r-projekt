using Forma1.validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1Tests.validation
{
    [TestClass()]
    public class SalaryValidatorTests
    {
        [TestMethod()]
        public void validationTestAgeEmpty()
        {
            try
            {
                SalaryValidator nv = new SalaryValidator(1);
                nv.validation();
            }
            catch (IsDigitExceptionExceptio ffs)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Nem számmal kezdődik a fizetés");
            }
            Assert.Fail("Nem számmal kezdődik a fizetés!");
        }

    }
}