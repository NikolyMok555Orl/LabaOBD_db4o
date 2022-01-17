using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using LabaOBD.CarRental.Model;
using LabaOBD.CarRepair.Model;
using System;
using System.Data;
using System.Linq;
using static LabaOBD.Utils;

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
                           select new { cRental, sm.DateStart }).ToList();
            DataTable dataTable = new DataTable();

            var title = (from u in results.Last().cRental.Title
                         select
                         u.Name).ToList();


            title.Add("Дата начало ремонта");
            Utils.SetHeaderDateTable(dataTable, title.ToArray<string>());
            foreach (var res in results)
            {

                var listRes = res.cRental.FieldsAsString().ToList();
                listRes.Add(res.DateStart.ToString());
                dataTable.Rows.Add(listRes.ToArray());
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
                           from ServiceModel sm in dbRepair
                           where sm.Car.Number.Equals(cRental.Number)
                           where sm.DateStart <= sm.DateFinal
                           select new
                           {
                               title = cRental.ToString(),
                               sumCar = sm.Car.BreakingModels?.Sum(bm=>bm.CostRepair+ (from BreakingModel bm2 in dbRepair
                                                                                       where bm.Name == bm2.Name
                                                                                       select bm2.SparesModels.Sum(smP => smP.Cost)).Sum())
                           }
                    ).ToList();
            Utils.SetHeaderDateTable(dataTable, header);
            foreach (var res in results)
            {
                dataTable.Rows.Add(res.title, res.sumCar);
            }

            return dataTable;
        }

        /* sumCar=Convert.ToDouble(sm.Car.BreakingModels.Sum(bm => bm.CostRepair + (from BreakingModel bm2 in dbRepair
                                                                                     where bm.Name == bm2.Name
                                                                                     select bm2.SparesModels.Sum(smP => smP.Cost)).Sum()))*/
    }
}