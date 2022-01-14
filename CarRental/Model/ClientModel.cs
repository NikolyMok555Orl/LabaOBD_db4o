using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental.Model
{
    class ClientModel
    {
        string secondName = "";
        string firstName = "";
        string patronymic = "";
        string address = "";
        int phone = 0;
        DateTime registrationDate = DateTime.Now;
        string passport = "";
        string driverLicense = "";
        RatingModel rating = new RatingModel();
        int amountPoint = 0;

        public ClientModel(string secondName, string firstName, string patronymic, string address, 
            int phone, DateTime registrationDate, string passport, string driverLicense, 
            RatingModel rating, int amountPoint)
        {
            this.secondName = secondName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.address = address;
            this.phone = phone;
            this.registrationDate = registrationDate;
            this.passport = passport;
            this.driverLicense = driverLicense;
            this.rating = rating;
            this.amountPoint = amountPoint;
        }


        public ClientModel(){}
    }
}
