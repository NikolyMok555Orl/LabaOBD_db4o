using LabaOBD.CarRental.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LabaOBD.CarRental.Model.EngineModel;

namespace LabaOBD.CarRental.Controller
{
    class EngineController : LabaOBD.Controller
    {
        static EngineModel engine = new EngineModel();

        List<EngineModel> engineModels = new List<EngineModel>();
        public EngineController()
        {
            //Refresh();
        }





        private void CreateEngine(string type, int power, double fuelConsumption, int volume, string name)
        {
            EngineModel engine = new EngineModel(type, power, fuelConsumption, volume, name);
            engine.Insert();
            Refresh();
        }

        public override void Add(DataTable dataTable)
        {
            if (!Utils.IsIdenticalHeading(dataTable, engine.TitleAll))
            {
                MessageBox.Show("Не совпадение заголовков");
                return;
            }
            if(dataTable.Rows.Count>1) MessageBox.Show("Допустимо создания одного объекта");
            var row = dataTable.Rows[0];
            CreateEngine(row[0].ToString(), Convert.ToInt32(row[1].ToString()),Convert.ToDouble( row[2].ToString()), 
                Convert.ToInt32(row[3].ToString()), row[4].ToString());
            Refresh();
        }

        public override DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            engineModels = engine.GetAll();
            Utils.SetHeaderDateTable(dataTable, engine.TitleAll);
            foreach (var engine in engineModels)
            {
                dataTable.Rows.Add(engine.FieldsAsString());
            }
            return dataTable;
        }


        public override void GetDataTableTitle(DataTable dataTable)
        {
            var en = new EngineModel();
            Utils.SetHeaderDateTable(dataTable, en.TitleAll);
        }

        public override void Delete(int indexRow)
        {
            if (indexRow > engineModels.Count)
            {
                MessageBox.Show("Ошибка удаление не сущ эл");
                return;
            }
            engineModels[indexRow].Delete();
            Refresh();
        }

        public override void Update(DataTable dataTable, int indexRow)
        {
            if (!Utils.IsIdenticalHeading(dataTable, engine.TitleAll)) { 
                MessageBox.Show("Не совпадение заголовков");
                return;
            }
            if (indexRow > engineModels.Count)
            {
                MessageBox.Show("Ошибка удаление не сущ элемент");
                return;
            }
            var row = dataTable.Rows[indexRow];
            engineModels[indexRow].Type = engine.ConvertFromString(row[0].ToString());
            engineModels[indexRow].Power = Convert.ToInt32( row[1].ToString());
            engineModels[indexRow].FuelConsumption = Convert.ToDouble(row[2].ToString());
            engineModels[indexRow].Volume = Convert.ToInt32( row[3].ToString());
            engineModels[indexRow].Name = row[4].ToString();
            engineModels[indexRow].Update();
            Refresh();
        }

        public override void Refresh()
        {
            engineModels = engine.GetAll();
        }

        
    }
}
