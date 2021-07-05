using Forma1.myexeption;
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
    public class AgeValidatorTests
    {
        [TestMethod()]
        public void validationTestAgeEmpty()
        {
            try
            {
                AgeValidator nv = new AgeValidator(1,1,1);
                nv.validation();
            }
            catch (AgeIsEmptyException ffs)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Üres korra nem jó kivételt dob!");
            }
            Assert.Fail("Üres korra nem dob kivételt!");
        }
        [TestMethod()]
        public void validationTestLessThanMinAge()
        {
            try
            {
                AgeValidator nv = new AgeValidator(10,13,70);
                nv.validation();
            }
            catch (AgeIsLessThanMinException kms)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Az élwtkor nem lehet kisebb mint a minimum életkor!");
            }
            Assert.Fail("Az életkor nem lehet kisebb mint a minimum életkor!");
        }
        [TestMethod()]
        public void validationTesMoreThanMaxAge()
        {
            try
            {
                AgeValidator nv = new AgeValidator(73, 13, 70);
                nv.validation();
            }
            catch (AgeIsMoreThanMaxException kys)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Az életkor nem lehet nagyobb mint a maximum életkor!");
            }
            Assert.Fail("Az életkor nem lehet nagyobb mint a maximum életkor!");
        }
    }
}

