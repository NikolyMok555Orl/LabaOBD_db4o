using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRepair.Model
{
    public class CarModel : DBModel<CarModel>, TitleModeInterface
    {
        string model;
        string brand;
        string number;
        List<BreakingModel> breakingModels;

        public CarModel()
        {
        }

        public CarModel(string model, string brand, string number)
        {
            this.model = model;
            this.brand = brand;
            this.number = number;
        }

        public CarModel(string model, string brand, string number, List<BreakingModel> breakingModels) : this(model, brand, number)
        {
            this.breakingModels = breakingModels;
        }

        public override DB4oConection Conection => DB.DB4OConectionSTO;

        public override IObjectContainer GetDB => Conection.Db;

        public Title[] Title => new Title[] { new Title("Модель", typeof(string)), new Title("Марка", typeof(string)), new Title("Номер", typeof(string)), new Title("Поломки", typeof(string)) };

        public string Model { get => model; set => model = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Number { get => number; set => number = value; }
        public List<BreakingModel> BreakingModels { get => breakingModels; set => breakingModels = value; }

        public override string[] FieldsAsString()
        {
            var listAsStr = "";
            if (breakingModels != null)
            {
                foreach (var item in breakingModels)
                {
                    listAsStr += item.ToString() + ", ";
                }
                listAsStr = listAsStr.Substring(0, listAsStr.Length - 2);
            }

            return new string[] { model, brand, number, listAsStr };
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return model + " " + number;
        }
    }
}
