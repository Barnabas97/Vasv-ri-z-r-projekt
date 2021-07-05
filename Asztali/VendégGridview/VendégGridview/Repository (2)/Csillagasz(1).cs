using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendégGridview.Model;

namespace VendégGridview.Repository
{
    class Csillagasz : InterfaceCsillagasz
    {
        private string name;
        private List<Tanulo> csillagaszok;

        public Csillagasz(string name)
        {
            this.name = name;
            csillagaszok = new List<Tanulo>();
        }


        public void delete()
        {
            csillagaszok.Clear();
        }

        public void update(string newTanulo)
        {
            throw new NotImplementedException();
        }


        public void Update(string newName)
        {
            this.name = newName;
        }
    }
}
