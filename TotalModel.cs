using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using LabaOBD.CarRental.Model;
using LabaOBD.CarRepair.Model;
using System;
using System.Data;
using System.Linq;

namespace LabaOBD
{
    public class TotalModel
    {
        private IObjectContainer dbRental;
        private IObjectContainer dbRepair;

        public TotalModel()
        {
            CarRentalModel carRental = new CarRentalModel();
            CarRepairModel carRepair = new CarRepairModel();

            dbRental = carRental.GetDB;
            dbRepair = carRepair.GetDB;
        }

        //join CarRepairModel cRepair in dbRepair on cRental.Number equals cRepair.Number
        public DataTable GetReportTotalCarRepair()
        {
            var results = (from CarRentalModel cRental in dbRental
                           join ServiceModel sm in dbRepair on cRental.Number equals sm.Car.Number
                           where sm.DateStart > sm.DateFinal
                           select cRental).ToList();
            DataTable dataTable = new DataTable();
            Utils.SetHeaderDateTable(dataTable, results.Last().Title);
            foreach (var res in results)
            {
                dataTable.Rows.Add(res.FieldsAsString());
            }
            return dataTable;
        }
        //
       /* public DataTable GetReportTotalCarRepairFromWithSumTotal()
        {
            DataTable dataTable = new DataTable();
            string[] header = new string[] { "Авто", "Сумма" , "Дата начало", "Дата окончания"};

            var results = (from CarRentalModel cRental in dbRental
                           join ServiceModel sm in dbRepair on cRental.Number equals sm.Car.Number
                           where sm.DateStart <= sm.DateFinal
                           select new
                           {
                               title = sm.Car.ToString(),
                               sum = sm.Car.BreakingModels.Sum(bm => bm.CostRepair +(from BreakingModel bm2 in dbRepair 
                                                                                     where bm.Name==bm2.Name
                                                                                     select bm2.SparesModels.Sum(smP=>smP.Cost)).Sum())
                           }
                    ).ToList();
            Utils.SetHeaderDateTable(dataTable, header);
            foreach (var res in results)
            {
                dataTable.Rows.Add(res.title, res.sum);
            }

            return dataTable;
        }*/
       /// <summary>
       /// Сумма по авто за весь период
       /// </summary>
       /// <returns></returns>
        public DataTable GetReportTotalCarRepairFromWithSumTotalAllPeriod()
        {
            DataTable dataTable = new DataTable();
            string[] header = new string[] { "Авто", "Сумма"};

            var results = (from CarRentalModel cRental in dbRental
                           select new
                           {
                               group title = cRental.ToString(),
                               sum = (from ServiceModel sm in dbRepair
                                      where sm.Car.Number == cRental.Number
                                      where sm.DateStart <= sm.DateFinal
                                      select new
                                    {
                                    sumCar=sm.Car.BreakingModels.Sum(bm => bm.CostRepair + (from BreakingModel bm2 in dbRepair
                                                                                     where bm.Name == bm2.Name
                                                                                     select bm2.SparesModels.Sum(smP => smP.Cost)).Sum())
                                })
                           }
                    ).ToList();
            Utils.SetHeaderDateTable(dataTable, header);
            foreach (var res in results)
            {
                dataTable.Rows.Add(res.title, res.sum.ToString());
            }

            return dataTable;
        }

    }
}