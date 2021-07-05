using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.myexeption
{
    class AgeisnotnullException : Exception
    {

        public AgeisnotnullException(string message)
           : base(message)
        { }
    }
}
