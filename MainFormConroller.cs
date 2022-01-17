using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD
{
    public class MainFormConroller
    {


        List<string> reportCarRental = new List<string>() { "Авто полная инфа", "Свободные авто полная инфа" , "Авто в ремонте с помощью двух баз", "Сумма за ремонт по отправки"};
        List<string> reportCarRepair = new List<string>() { "Все авто, что были/есть в сто", "Авто в ремонте", "Авто отремонтированные" };

        public List<string> ReportCarRental { get => reportCarRental; set => reportCarRental = value; }
        public List<string> ReportCarRepair { get => reportCarRepair; set => reportCarRepair = value; }


        public DataTable GetReportRental(int index)
        {
             switch (index)
            {
                case 0:
                    {
                        return (new CarRental.Model.CarRentalModel().GetFullInfoCar());
                    }
                case 1:
                    {
                        return (new CarRental.Model.CarRentalModel().GetFullInfoCarFree());
                    }
                case 2:
                    {
                        return new TotalModel().GetReportTotalCarRepair();
                    }
                case 3:
                    {
                        return new TotalModel().GetReportTotalCarRepairFromWithSumTotalAllPeriod();
                    }

                default: return new DataTable();
            }
        }


        public DataTable GetReportRepair(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        return (new CarRepair.Model.ServiceModel().GetAllServiseWithSum());
                    }
                case 1:
                    {
                        return (new CarRepair.Model.ServiceModel().GetOnNotFinalServiseWithSum());
                    }
                case 2:
                    {
                        return (new CarRepair.Model.ServiceModel().GetOnFinalServiseWithSum());
                    }

                default: return new DataTable();
            }
        }
    }
}
