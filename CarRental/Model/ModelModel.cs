using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRental.Model
{
    public class ModelModel : DBModel<ModelModel>, TitleModeInterface
    {
        public enum BodyTypes { Sedan, Pikap, none }

        public static string[] bodyTypes = new string[] { BodyTypes.Sedan.ToString(), BodyTypes.Pikap.ToString(), null };


        string nameModel = "";
        ModelsCompleteSetModel complete=new ModelsCompleteSetModel();
        string brand = "";
        string bodyType = bodyTypes[(int)BodyTypes.none];

        public string FindType(string type)
        {
            if (bodyTypes.Contains(type)) return type;
            else return null;
        }

        public ModelModel(ModelsCompleteSetModel complete, string brand, string nameType, string nameModel)
        {
            this.complete = complete;
            this.brand = brand;
            this.bodyType = FindType(nameType);
            this.nameModel = nameModel;
        }

        public ModelModel()
        {
        }

        public override DB4oConection Conection => DB.DB4OConectionCarRental;

        public override IObjectContainer GetDB => Conection.Db;

        public Utils.Title[] Title => new Title[]{new Title("Название модели", typeof(string)), new Title("Комплектация", typeof(string), true),
        new Title("Бренд", typeof(string)), new Title("Имя типа", typeof(string))};

        public ModelsCompleteSetModel Complete { get => complete; set => complete = value; }
        public string Brand { get => brand; set => brand = value; }
        public string BodyType { get => bodyType; set => bodyType = value; }
        public string NameModel { get => nameModel; set => nameModel = value; }

        public override string[] FieldsAsString()
        {
            return new string[] { nameModel, complete?.ToString(), brand.ToString(), bodyType.ToString()};
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return NameModel;
        }

        public override bool Equals(object obj)
        {
            return obj is ModelModel model &&
                   nameModel == model.nameModel &&
                   EqualityComparer<ModelsCompleteSetModel>.Default.Equals(complete, model.complete) &&
                   brand == model.brand &&
                   bodyType == model.bodyType;
        }
    }
}
