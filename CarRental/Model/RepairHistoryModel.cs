using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LabaOBD.Utils;

namespace LabaOBD.CarRental.Model
{
    public class RepairHistoryModel : DBModel<RepairHistoryModel>, TitleModeInterface
    {
        CarModel car = new CarModel();
        DateTime startDate = DateTime.Now;
        DateTime endDatePrimary = DateTime.Now.AddDays(-1);
        DateTime endDate= DateTime.Now.AddDays(-1);
        double initialAmount;
        double finalAmount;

        public RepairHistoryModel()
        {
        }

        public RepairHistoryModel(CarModel car, double initialAmount)
        {
            this.car = car;
            this.initialAmount = initialAmount;
        }

        public RepairHistoryModel(CarModel car)
        {
            this.car = car;
        }

        public RepairHistoryModel(CarModel car, DateTime startDate, DateTime endDatePrimary, DateTime endDate, double initialAmount, double finalAmount)
        {
            this.car = car;
            this.startDate = startDate;
            this.endDatePrimary = endDatePrimary;
            this.endDate = endDate;
            this.initialAmount = initialAmount;
            this.finalAmount = finalAmount;
        }

        public CarModel Car { get => car; set => car = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDatePrimary { get => endDatePrimary; set => endDatePrimary = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public double InitialAmount { get => initialAmount; set => initialAmount = value; }
        public double FinalAmount { get => finalAmount; set => finalAmount = value; }

        public override DB4oConection Conection => DB.DB4OConectionCarRental;

        public override IObjectContainer GetDB => Conection.Db;

        public Title[] Title => new Title[]{new Title("Авто", typeof(string), true), new Title("Начало ремонта", typeof(DateTime)),
        new Title("Дата окончание пред.", typeof(DateTime)), new Title("Конец ремонта", typeof(DateTime)), new Title("Сумма нач.", typeof(double)), new Title("Сумма", typeof(double))};


        public override string[] FieldsAsString()
        {
            return new string[] { car.ToString(), startDate.ToString(), endDatePrimary.ToString(), endDate.ToString(), initialAmount.ToString(), finalAmount.ToString() };
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void SendForRepair(CarModel car)
        {
            this.car = car;
            Insert();
        }



        public RepairHistoryModel FindHistoryModelNotEnd(CarModel car)
        {
            var model = GetDB.Query<RepairHistoryModel>(rh=>rh.car.Number==car.Number && DateTime.Compare(rh.StartDate, rh.EndDate)>0);
            if (model.Count == 1)
            {
               return model[0];
            }
            else
            {
                return null;
            }


        }

        public void SendForRepair(CarModel car, double initialAmount)
        {
            this.car = car;
            this.initialAmount = initialAmount;
            Insert();
        }


        public void ReturnCar(double finalAmount)
        {
            
            if (car!=null)
            {
                this.finalAmount = finalAmount;
                endDate = DateTime.Now;
                car.ReturnFromRepir();
                Update();
            }
        }

    }
}
