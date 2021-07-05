using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendégGridview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendégGridview.Tests
{
    [TestClass()]
    public class LoginTests
    {
        TextBox t=new TextBox();

        
        [TestMethod()]
        public void LoginTest()
        {
            t.Text = "Admin";
            Assert.IsTrue(t.Firstletteruppercase(), "Legyen nagybetű a felhasználónév");

            
        }


        [TestMethod()]
        public void LoginTest2()
        {
            t.Text = "Admin";
            Assert.IsTrue(t.Firstletteruppercase2(), "Legyen nagybetű a jelszó");


        }
    }
}