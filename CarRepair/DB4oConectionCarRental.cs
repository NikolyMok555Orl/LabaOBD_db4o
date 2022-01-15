using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental
{
    class DB4oConectionSTO :DB4oConection
    {
        protected const String dbFileName = "Sto.data";

        public DB4oConectionSTO() : base(dbFileName)
        {
        }
    }
}
