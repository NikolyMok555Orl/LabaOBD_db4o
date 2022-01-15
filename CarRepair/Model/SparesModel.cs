using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRepair.Model
{
    public class SparesModel : DBModel<SparesModel>, TitleModeInterface
    {
        string name;
        double cost;

        public SparesModel()
        {
        }

        public SparesModel(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public override DB4oConection Conection => DB.DB4OConectionSTO;

        public override IObjectContainer GetDB => Conection.Db;

        public Title[] Title => new Title[]{new Title("Названия", typeof(string)), new Title("Стоимость", typeof(double)),};

        public string Name { get => name; set => name = value; }
        public double Cost { get => cost; set => cost = value; }

        public override string[] FieldsAsString()
        {
            return new string[] { name, cost.ToString()};
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
