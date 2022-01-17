using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Data;
using static LabaOBD.Utils;

namespace LabaOBD.CarRepair.Model
{
    /// <summary>
    /// Обращение
    /// </summary>
    public class ServiceModel : DBModel<ServiceModel>, TitleModeInterface
    {
        private CarRepairModel car;
        private string nameClient;
        private string phoneClient;
        private DateTime dateStart = DateTime.Now;
        private DateTime dateFinal = DateTime.Now.AddDays(-1);

        public ServiceModel()
        {
        }

        public ServiceModel(CarRepairModel car, string nameClient, string phoneClient, DateTime dateStart, DateTime dateFinal)
        {
            this.car = car;
            this.nameClient = nameClient;
            this.phoneClient = phoneClient;
            this.dateStart = dateStart;
            this.dateFinal = dateFinal;
        }

        public ServiceModel(CarRepairModel car, string nameClient, string phoneClient)
        {
            this.car = car;
            this.nameClient = nameClient;
            this.phoneClient = phoneClient;
        }

        public override DB4oConection Conection => DB.DB4OConectionSTO;

        public override IObjectContainer GetDB => Conection.Db;

        public Title[] Title => new Title[] { new Title("Авто", typeof(string)), new Title("Клиент", typeof(string)), new Title("Номер", typeof(string)), new Title("Начало", typeof(string)), new Title("Конец", typeof(string)), };

        public CarRepairModel Car { get => car; set => car = value; }
        public string NameClient { get => nameClient; set => nameClient = value; }
        public string PhoneClient { get => phoneClient; set => phoneClient = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateFinal { get => dateFinal; set => dateFinal = value; }

        public override string[] FieldsAsString()
        {
            return new string[] { car?.ToString(), nameClient, phoneClient, dateStart.ToString(), dateFinal.ToString() };
        }

        public override bool IsEmpty()
        {
            if (car != null) return false;
            return true;
        }


        public bool IsRepiar()
        {
            return dateFinal < DateStart;
        }

        public DataTable GetAllServiseWithSum()
        {
            IList<ServiceModel> result = GetDB.Query<ServiceModel>();
            return GetAllServiseResult(result);
        }

        public DataTable GetOnFinalServiseWithSum()
        {
            IList<ServiceModel> result = GetDB.Query<ServiceModel>(sm=> sm.dateFinal>=sm.dateStart);
            return GetAllServiseResult(result);
        }


        public DataTable GetOnNotFinalServiseWithSum()
        {
            IList<ServiceModel> result = GetDB.Query<ServiceModel>(sm => sm.dateFinal < sm.dateStart);
            return GetAllServiseResult(result);
        }

        public void TakeCarRepair(CarRental.Model.CarRentalModel car, string nameClient, string phoneClient)
        {
            CarRepairModel servieCar = new CarRepairModel(car);
            ServiceModel newServieModel = new ServiceModel(servieCar, nameClient, phoneClient);
            newServieModel.Insert();
        }

        public void FinalRepair()
        {
            CarRental.Model.CarRentalModel carRental = new CarRental.Model.CarRentalModel();
            carRental = carRental.FindCarAsRepierDB(car);
            if (carRental != null)
            {
                CarRental.Model.RepairHistoryModel repairHistory = new CarRental.Model.RepairHistoryModel();
                repairHistory = repairHistory.FindHistoryModelNotEnd(carRental);
                if (repairHistory != null)
                {
                    repairHistory.ReturnCar(car.SumRepair());
                    dateFinal = DateTime.Now;
                    Update();
                }
            }
           
        }

        public void FinalRepair(string number)
        {
            var res = GetDB.Query<ServiceModel>(sm=>sm.Car.Number==number && sm.DateStart>sm.DateFinal);
            if (res.Count == 1)
            {
                res[0].FinalRepair();
            }

        }

        public void FinalRepair(CarRepairModel car)
        {
            var res = GetDB.Query<ServiceModel>(sm => sm.Car.Equals(car) && sm.DateStart > sm.DateFinal);
            if (res.Count == 1)
            {
                res[0].FinalRepair();
            }
        }

        private DataTable GetAllServiseResult(IList<ServiceModel> result)
        {
            DataTable dataTable = new DataTable();
            Title[] ReportTitle = Title;
            Array.Resize(ref ReportTitle, ReportTitle.Length + 1);
            ReportTitle[ReportTitle.Length - 1] = new Title("Сумма за ремонт", typeof(double));
            Utils.SetHeaderDateTable(dataTable, ReportTitle);

            foreach (var item in result)
            {
                string[] rowReport = item.FieldsAsString();
                Array.Resize(ref rowReport, rowReport.Length + 1);
                rowReport[rowReport.Length - 1] = item.Car?.SumRepair().ToString();
                dataTable.Rows.Add(rowReport);
            }
            return dataTable;
        }
    }
}