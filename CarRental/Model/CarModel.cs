using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRental.Model
{
    public class CarModel : DBModel<CarModel>, TitleModeInterface
    {
        public CarModel()
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
        new Title("Состояние", typeof(string)), new Title("Цвети", typeof(string)), new Title("Номер", typeof(string)), new Title("Пробег", typeof(int))};


        public ModelModel Model { get => model; set => model = value; }
        public int ProductionYear { get => productionYear; set => productionYear = value; }
        internal string ConditionCar { get => conditionCar; set => conditionCar = value; }
        public string Color { get => color; set => color = value; }
        public string Number { get => number; set => number = value; }
        public int Mileage { get => mileage; set => mileage = value; }

        public CarModel(ModelModel model, int productionYear, String condition_car, string color, string number, int mileage)
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
            throw new NotImplementedException();
        }

        public override string[] FieldsAsString()
        {
            return new string[] { model.ToString(), productionYear.ToString(), conditionCar?.ToString(), color.ToString(), number.ToString(), mileage.ToString()};
        }

        public override string ToString()
        {
            return model.ToString()+" "+ number;
        }
    }
}
