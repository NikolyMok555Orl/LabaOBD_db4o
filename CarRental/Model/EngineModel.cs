using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRental.Model
{
    //Двигатель
    public class EngineModel : DBModel<EngineModel>, TitleModeInterface
    {
        public enum EngineType { petrol, diesel, electric, none }
        public static string[] engineTypeMass = new string[] { EngineType.petrol.ToString(), EngineType.diesel.ToString(), EngineType.electric.ToString(), null };


        string type = engineTypeMass[((int)EngineType.none)];
        int power = 0;
        double fuelConsumption = 0;
        int volume = 0;
        string name = "";

        public enum TitleType { type, power, fuelConsumption, volume, name };

        public Title[] Title => new Title[]{new Title("Тип", typeof(string)), new Title("Мощность", typeof(int)),  
            new Title("Расход", typeof(double)),  new Title("Объем", typeof(int)), new Title("Двигатель название", typeof(string))};

        public override IObjectContainer GetDB => Conection.Db;

        public override DB4oConection Conection => DB.DB4OConectionCarRental;

        public string Type { get => type; set => type = value; }
        public int Power { get => power; set => power = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public int Volume { get => volume; set => volume = value; }
        public string Name { get => name; set => name = value; }

        public EngineModel()
        {

        }


        public EngineModel(string name)
        {
            this.name = name;
        }

        public string FindType(string type)
        {
            if (engineTypeMass.Contains(type)) return type;
            else return null;
        }

        public EngineModel(string type, int power, double fuelConsumption, int volume, string name)
        {

            this.type = FindType(type);
            this.power = power;
            this.fuelConsumption = fuelConsumption;
            this.volume = volume;
            this.name = name;
        }

        public override string ToString()
        {
            return String.Format("{0}", name);
            // return String.Format("Названия {0}, P {1}, Тип {2}, V {3}, Расход {4}",name, power, type, volume, fuelConsumption);
        }

        public override string[] FieldsAsString()
        {
            return new string[] { type?.ToString(), power.ToString(), fuelConsumption.ToString(), volume.ToString(), name};
        }

        public override bool IsEmpty()
        {
            if (type == null && power == 0 && fuelConsumption == 0 
                && volume == 0 && volume == 0 && name.Length > 0) return true;
           return false;
        }

        public override bool Equals(object obj)
        {
            return obj is EngineModel model &&
                   type == model.type &&
                   power == model.power &&
                   fuelConsumption == model.fuelConsumption &&
                   volume == model.volume &&
                   name == model.name;
        }
    }
}
