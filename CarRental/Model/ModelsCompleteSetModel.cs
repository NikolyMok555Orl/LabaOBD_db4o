using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRental.Model
{
    //Комплектация 
    public class ModelsCompleteSetModel : DBModel<ModelsCompleteSetModel>, TitleModeInterface
    {

        public enum GearboxTypes {KPP, AKPP, none }

        public static string[] gearboxTypes = new string[] { GearboxTypes.KPP.ToString(), GearboxTypes.AKPP.ToString(), null };


        string nameComplete = "";
        EngineModel engine;
        double costModel = 0.0;
        double rentPrice = 0.0;
        string gearboxType = gearboxTypes[(int)GearboxTypes.none];
        int amountSeat = 0;


        public enum TitleType { nameComplete, engine, costModel, rentPrice, gearboxType, amountSeat };


        public Title[] Title => new Title[]{new Title("Комлпектация название", typeof(string)), new Title("Двигатель", typeof(string), true),
        new Title("Стоимость", typeof(double)), new Title("Аренда", typeof(double)), new Title("КП", typeof(string)), new Title("Места", typeof(int))};
        public ModelsCompleteSetModel(string nameComplete, EngineModel engine, double costModel, double rentPrice, string gearboxType, int amountSeat)
        {
            this.nameComplete = nameComplete;
            this.engine = engine.GetOne(engine);
            this.costModel = costModel;
            this.rentPrice = rentPrice;
            this.gearboxType = FindType(gearboxType);
            this.amountSeat = amountSeat;
        }

        public ModelsCompleteSetModel()
        {
        }

        public string FindType(string type)
        {
            if (gearboxTypes.Contains(type)) return type;
            else return null;
        }

        public override DB4oConection Conection => DB.DB4OConectionCarRental;

        public override IObjectContainer GetDB => Conection.Db;

        public string NameComplete { get => nameComplete; set => nameComplete = value; }
        public EngineModel Engine { get => engine; set => engine = value; }
        public double CostModel { get => costModel; set => costModel = value; }
        public double RentPrice { get => rentPrice; set => rentPrice = value; }
        public string GearboxType { get => gearboxType; set => gearboxType = value; }
        public int AmountSeat { get => amountSeat; set => amountSeat = value; }

        public override string[] FieldsAsString()
        {
            return new string[] { nameComplete, engine?.ToString(), costModel.ToString(), rentPrice.ToString(), gearboxType?.ToString(), amountSeat.ToString() };
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return NameComplete;
        }

        public override bool Equals(object obj)
        {
            return obj is ModelsCompleteSetModel model &&
                   nameComplete == model.nameComplete &&
                   EqualityComparer<EngineModel>.Default.Equals(engine, model.engine) &&
                   costModel == model.costModel &&
                   rentPrice == model.rentPrice &&
                   gearboxType == model.gearboxType &&
                   amountSeat == model.amountSeat;
        }
    }
}
