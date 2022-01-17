using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRental.Model
{
    public class CarRentalModel : DBModel<CarRentalModel>, TitleModeInterface
    {
        public CarRentalModel()
        {

        }

        public enum ConditionCarType
        {
            free, busy, repair, none
        }

        public static string[] conditionCarTypes = new string[] { ConditionCarType.free.ToString(), ConditionCarType.busy.ToString(),ConditionCarType.repair.ToString(), null };

        ModelModel model = new ModelModel();
        int productionYear = 0;
        string conditionCar = conditionCarTypes[(int)ConditionCarType.none];
        string color = "";
        string number = "";
        int mileage = 0;

        public override DB4oConection Conection => DB.DB4OConectionCarRental;

        public override IObjectContainer GetDB => Conection.Db;

        public Title[] Title => new Title[]{new Title("Модель", typeof(string)), new Title("Год", typeof(int)),
        new Title("Состояние", typeof(string)), new Title("Цвет", typeof(string)), new Title("Номер", typeof(string)), new Title("Пробег", typeof(int))};


        public ModelModel Model { get => model; set => model = value; }
        public int ProductionYear { get => productionYear; set => productionYear = value; }
        internal string ConditionCar { get => conditionCar; set => conditionCar = value; }
        public string Color { get => color; set => color = value; }
        public string Number { get => number; set => number = value; }
        public int Mileage { get => mileage; set => mileage = value; }

        public CarRentalModel(ModelModel model, int productionYear, String condition_car, string color, string number, int mileage)
        {
            this.model = model;
            this.productionYear = productionYear;
            this.conditionCar = FindType(condition_car);
            this.color = color;
            this.number = number;
            this.mileage = mileage;
        }

        public string FindType(string type)
        {
            if (conditionCarTypes.Contains(type)) return type;
            else return null;
        }

        public override bool IsEmpty()
        {
            if (model != null && number != null && number.Length > 0) return false;
            return true;
        }

        public override string[] FieldsAsString()
        {
            return new string[] { model.ToString(), productionYear.ToString(), conditionCar?.ToString(), color.ToString(), number.ToString(), mileage.ToString()};
        }

        public override string ToString()
        {
            return model.ToString()+" "+ number;
        }


        public void SendForRepair()
        {
            conditionCar= conditionCarTypes[(int)ConditionCarType.repair];
            RepairHistoryModel repairHistoryModel = new RepairHistoryModel();
            repairHistoryModel.SendForRepair(this);
            CarRepair.Model.ServiceModel serviceModel = new CarRepair.Model.ServiceModel();
            serviceModel.TakeCarRepair(this, "", "");
            Update();
        }

        public void ReturnFromRepir()
        {
            conditionCar = conditionCarTypes[(int)ConditionCarType.free];
            Update();
        }

        public CarRentalModel FindCarAsRepierDB(CarRepair.Model.CarRepairModel carR)
        {
            var res = GetDB.Query<CarRentalModel>(c=>c.number== carR.Number && c.Model.ToString()== carR.Model && c.Model?.Brand==carR.Brand);
            if (res.Count == 1)
            {
                return res[0];
            }
            return null;
        }

        public  void ReturnFromRepir(string number)
        {
            IList<CarRentalModel> result = GetDB.Query<CarRentalModel>(u => u.Number == number);
            if (result.Count == 1)
            {
                var car = result[0];
                car.ReturnFromRepir();
            }
        }

        public DataTable GetFullInfoCar()
        {
            
            IList<CarRentalModel> result = GetDB.Query<CarRentalModel>();


            return GetFullInfo(result);
        }



        public DataTable GetFullInfoCarFree()
        {
            IList<CarRentalModel> result = GetDB.Query<CarRentalModel>(c=>c.conditionCar == ConditionCarType.free.ToString());
            return GetFullInfo(result);

        }

        private DataTable GetFullInfo(IList<CarRentalModel> result)
        {
            DataTable dataTable = new DataTable();
            List<Title> ReportTitle = new List<Title>();
            ReportTitle.AddRange(Title);
            ReportTitle.AddRange(new ModelModel().Title);
            ReportTitle.AddRange(new ModelsCompleteSetModel().Title);
            ReportTitle.AddRange(new EngineModel().Title);

            Utils.SetHeaderDateTable(dataTable, ReportTitle.ToArray());

            foreach (var item in result)
            {
                List<string> rowReport = new List<string>();
                rowReport.AddRange(item.FieldsAsString());
                rowReport.AddRange(item.Model?.FieldsAsString());
                rowReport.AddRange(item.Model?.Complete?.FieldsAsString());
                rowReport.AddRange(item.Model?.Complete?.Engine?.FieldsAsString());
                dataTable.Rows.Add(rowReport.ToArray());
            }
            return dataTable;
        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return obj is CarRentalModel model &&
                   EqualityComparer<ModelModel>.Default.Equals(this.model, model.model) &&
                   productionYear == model.productionYear &&
                   color == model.color &&
                   number == model.number &&
                   mileage == model.mileage;
        }
    }
}
