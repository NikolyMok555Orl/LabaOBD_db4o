using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental
{
    class DB4oConectionCarRental :DB4oConection
    {
        protected new const String dbFileName = "CarRental.data";

        public DB4oConectionCarRental() : base(dbFileName)
        {
        }
    }
}
