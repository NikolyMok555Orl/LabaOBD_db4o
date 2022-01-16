using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LabaOBD.Utils;

namespace LabaOBD.CarRepair.Model
{
    /// <summary>
    /// Список поломок
    /// </summary>
    public class BreakingModel : DBModel<BreakingModel>, TitleModeInterface
    {
        string name;
        double costRepair;
        List<SparesModel> sparesModels;

        public BreakingModel()
        {
        }

        public BreakingModel(string name, double costRepair)
        {
            this.name = name;
            this.costRepair = costRepair;
        }

        public BreakingModel(string name, double costRepair, List<SparesModel> sparesModels) : this(name, costRepair)
        {
            this.sparesModels = sparesModels;
        }

        public override DB4oConection Conection => DB.DB4OConectionSTO;

        public override IObjectContainer GetDB => Conection.Db;

        public Title[] Title => new Title[] { new Title("Названия", typeof(string)), new Title("Стоимость", typeof(double)), new Title("Запчасти", typeof(string)) };

        public string Name { get => name; set => name = value; }
        public double CostRepair { get => costRepair; set => costRepair = value; }
        public List<SparesModel> SparesModels { get => sparesModels; set => sparesModels = value; }

        public override string[] FieldsAsString()
        {
            var listAsStr = "";
            if (sparesModels != null)
            {
                foreach (var item in sparesModels)
                {
                    listAsStr += item.ToString() + ", ";
                }
                listAsStr = listAsStr.Substring(0, listAsStr.Length - 2);
            }
  
            return new string[] { name, costRepair.ToString(), listAsStr };
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }



        public double SumSpares()
        {
            return sparesModels?.Sum(item=> item.Cost)?? 0;
        }


        public double amountOfBreakage()
        {
            return costRepair + SumSpares();
        }
    }
}
