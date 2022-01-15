using LabaOBD.CarRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD
{
    public static class DB
    {
        static DB4oConectionCarRental dB4OConectionCarRental=new DB4oConectionCarRental();
        static DB4oConectionSTO dB4OConectionSTO=new DB4oConectionSTO();

        static DB()
        {}

        internal static DB4oConectionCarRental DB4OConectionCarRental { get => dB4OConectionCarRental; private set => dB4OConectionCarRental = value; }
        internal static DB4oConectionSTO DB4OConectionSTO { get => dB4OConectionSTO; private set => dB4OConectionSTO = value; }

        public static bool Conect()
        {
           bool res= DB4OConectionCarRental.ConnectDB();
           res= dB4OConectionSTO.ConnectDB();

            return res;
        }

        public static bool Disconect()
        {
            bool res = DB4OConectionCarRental.Close();
            res = dB4OConectionSTO.Close();

            return res;
        }


    }
}
