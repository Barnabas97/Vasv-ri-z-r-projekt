using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeValidation.Tests
{
    [TestClass()]
    public class AgevalidationTests
    {
        [TestMethod()]
        public void AgevalidationTest()
        {
         
            try
            {
               Agevalidation av = new Agevalidation(0,0,0);
              av.();
            }
            catch (AgeisnotNull agenull)
            {

                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Üres névre nem dob kivételt!");


            }
        }
    }
}