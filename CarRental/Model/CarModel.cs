using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental.Model
{
    class CarModel
    {
        public CarModel()
        {

        }

        public enum ConditionCar
        {
            free, busy, repair
        }

        ModelModel model = new ModelModel();
        int productionYear = 0;
        ConditionCar condition_car = ConditionCar.free;
        string color = "";
        string number = "";
        int mileage = 0;

        public CarModel(ModelModel model, int productionYear, ConditionCar condition_car, string color, string number, int mileage)
        {
            this.model = model;
            this.productionYear = productionYear;
            this.condition_car = condition_car;
            this.color = color;
            this.number = number;
            this.mileage = mileage;
        }
    }
}
