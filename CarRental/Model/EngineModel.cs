using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental.Model
{
    //Двигатель
    public class EngineModel : DBModel<EngineModel>, TitleModeInterface
    {
        public enum EngineType { petrol, diesel, electric, none }


        EngineType type = EngineType.none;
        int power = 0;
        double fuelConsumption = 0;
        int volume = 0;
        string name = "";

        public string[] TitleAll => new string[]{"Тип","Мощность","Расход", "Объем", "Название"};

        public override IObjectContainer GetDB => Conection.Db;

        public override DB4oConection Conection => DB.DB4OConectionCarRental;

        public EngineType Type { get => type; set => type = value; }
        public int Power { get => power; set => power = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public int Volume { get => volume; set => volume = value; }
        public string Name { get => name; set => name = value; }

        public EngineModel()
        {

        }

        public EngineModel(EngineType type, int power, double fuelConsumption, int volume, string name)
        {
            this.type = type;
            this.power = power;
            this.fuelConsumption = fuelConsumption;
            this.volume = volume;
            this.name = name;
        }


        public EngineType ConvertFromString(string type)
        {
            if (type.Equals(EngineType.petrol.ToString()))
            {
                return EngineType.petrol;
            }
            else if (type.Equals(EngineType.diesel.ToString()))
            {
                return EngineType.diesel;
            }
            else if (type.Equals(EngineType.electric.ToString()))
            {
                return EngineType.electric;
            }
            else if (type.Equals(EngineType.none.ToString()))
            {
                return EngineType.none;
            }
            else
            {
                throw new Exception("Такого типа нет");
            }
        }

        public EngineModel(string type, int power, double fuelConsumption, int volume, string name)
        {

            this.type = ConvertFromString(type);
            this.power = power;
            this.fuelConsumption = fuelConsumption;
            this.volume = volume;
            this.name = name;
        }

       /* public override bool Insert()
        {
            GetDB.Store(this);
            return Conection.Commit();
        }*/


        public override string ToString()
        {
            return String.Format("Названия {0}, P {1}, Тип {2}, V {3}, Расход {4}",name, power, type, volume, fuelConsumption);
        }

        public override string[] FieldsAsString()
        {
            return new string[] { type.ToString(), power.ToString(), fuelConsumption.ToString(), volume.ToString(), name};
        }


    }
}
