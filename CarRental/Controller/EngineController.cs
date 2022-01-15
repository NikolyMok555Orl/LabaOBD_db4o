using LabaOBD.CarRental.Model;
using LabaOBD.CarRental.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOBD.CarRental.Controller
{
    class EngineController : LabaOBD.Controller
    {
        static EngineModel model = new EngineModel();

        List<EngineModel> models = new List<EngineModel>();
        public EngineController()
        {
            //Refresh();
        }



        public override void Add()
        {
            /* if (!Utils.IsIdenticalHeading(dataTable, model.Title))
             {
                 MessageBox.Show("Не совпадение заголовков");
                 return;
             }
             if(dataTable.Rows.Count>1) MessageBox.Show("Допустимо создания одного объекта");
             var row = dataTable.Rows[0];

             EngineModel engine = new EngineModel(row.Field<string>(model.Title[(int)TitleType.type].Name), 
                 row.Field<int>(model.Title[(int)TitleType.power].Name), 
                 row.Field<double>(model.Title[(int)TitleType.fuelConsumption].Name),
                 row.Field<int>(model.Title[(int)TitleType.volume].Name),
                 row.Field<string>(model.Title[(int)TitleType.name].Name));
             engine.Insert();
             Refresh();*/
            EngineModel newModel = new EngineModel();
            if (ShowForm(newModel) == DialogResult.OK)
                newModel.Insert();

        }

        public override DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            models = model.GetAll();
            Utils.SetHeaderDateTable(dataTable, model.Title);
            foreach (var engine in models)
            {
                dataTable.Rows.Add(engine.FieldsAsString());
            }
            return dataTable;
        }


        public override void GetDataTableTitle(DataTable dataTable)
        {
            Utils.SetHeaderDateTable(dataTable, model.Title);
        }

        public override void Delete(int indexRow)
        {
            if (indexRow > models.Count)
            {
                MessageBox.Show("Ошибка удаление не сущ эл");
                return;
            }
            models[indexRow].Delete();
            Refresh();
        }

        public override void Update( int indexRow)
        {
            /*if (!Utils.IsIdenticalHeading(dataTable, model.Title)) { 
                MessageBox.Show("Не совпадение заголовков");
                return;
            }
            if (indexRow > models.Count)
            {
                MessageBox.Show("Ошибка удаление не сущ элемент");
                return;
            }
            var row = dataTable.Rows[indexRow];
            models[indexRow].Type = model.FindType(row[0].ToString());
            models[indexRow].Power = Convert.ToInt32( row[1].ToString());
            models[indexRow].FuelConsumption = Convert.ToDouble(row[2].ToString());
            models[indexRow].Volume = Convert.ToInt32( row[3].ToString());
            models[indexRow].Name = row[4].ToString();
            models[indexRow].Update();
            Refresh();*/
            EngineModel updateModel = models[indexRow];
            if (ShowForm(updateModel) == DialogResult.OK)
                updateModel.Insert();

        }

        public override void Refresh()
        {
            models = model.GetAll();
        }

        protected override DialogResult ShowForm(object modelThis)
        {
            if (modelThis is EngineModel)
            {
                FormEngine form = new FormEngine(modelThis as EngineModel);
                return form.ShowDialog();
            }
            else
            {
                return DialogResult.None;
            }
        }
    }
}
