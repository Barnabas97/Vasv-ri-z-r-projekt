using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendégGridview.Model;

namespace VendégGridview.Repository
{
    interface InterfaceCsillagaszManagetanulok
    {
        void add(Tanulo t);
        void delete(string name);
        void update(string name, Tanulo newTanulo);
    }
}
