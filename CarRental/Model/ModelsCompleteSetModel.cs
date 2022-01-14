using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD.CarRental.Model
{
    //Комплектация 
    public class ModelsCompleteSetModel : DBModel<ModelsCompleteSetModel>, TitleModeInterface
    {

   

    public enum GearboxTypes {KPP, AKPP, none }

        string nameComplete = "";
        EngineModel engine;
        double costModel = 0.0;
        double rentPrice = 0.0;
        GearboxTypes gearboxType = GearboxTypes.none;
        int amountSeat = 0;
       
        public string[] TitleAll => new string[] { "Название", "Двигатель", "Стоимость", "Аренда", "КП", "Места" };

        public ModelsCompleteSetModel(string nameComplete, EngineModel engine, double costModel, double rentPrice, GearboxTypes gearboxType, int amountSeat)
        {
            this.nameComplete = nameComplete;
            this.engine = engine;
            this.costModel = costModel;
            this.rentPrice = rentPrice;
            this.gearboxType = gearboxType;
            this.amountSeat = amountSeat;
        }

        public ModelsCompleteSetModel()
        {
        }

        public GearboxTypes ConvertFromString(string type)
        {
            if (type.Equals(GearboxTypes.KPP.ToString()))
            {
                return GearboxTypes.KPP;
            }
            else if (type.Equals(GearboxTypes.AKPP.ToString()))
            {
                return GearboxTypes.AKPP;
            }
            else if (type.Equals(GearboxTypes.none.ToString()))
            {
                return GearboxTypes.none;
            }
            else
            {
                throw new Exception("Такого типа нет");
            }
        }

        public override DB4oConection Conection => DB.DB4OConectionCarRental;

        public override IObjectContainer GetDB => Conection.Db;



       /* public override bool Delete()
        {
            GetDB.Delete(this);
            return Conection.Commit();
        }*/


        public override string[] FieldsAsString()
        {
            throw new NotImplementedException();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }


    }
}
