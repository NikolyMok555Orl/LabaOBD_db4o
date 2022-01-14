using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental.Model
{
    class RepairHistoryModel
    {
        CarModel car = new CarModel();
        DateTime startDate = DateTime.Now;
        DateTime EndDatePrimary;
        DateTime EndDate;
        double initialAmount;
        double finalAmount;

    }
}
