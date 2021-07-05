using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.myexeption
{
        [Serializable]
        public class IsDigitExceptionExceptio : Exception
        {
            public IsDigitExceptionExceptio(string message)
             : base(message)
            { }
        }
}
