using LabaOBD.CarRental.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LabaOBD.CarRental.Model.ModelsCompleteSetModel;

namespace LabaOBD.CarRental.Controller
{
    class ModelCompleteSetController : LabaOBD.Controller
    {
        static ModelsCompleteSetModel model = new ModelsCompleteSetModel();

        List<ModelsCompleteSetModel> models = new List<ModelsCompleteSetModel>();


        public override void Add(DataTable dataTable)
        {
            if (!Utils.IsIdenticalHeading(dataTable, model.Title))
            {
                MessageBox.Show("Не совпадение заголовков");
                return;
            }
            if (dataTable.Rows.Count > 1) MessageBox.Show("Допустимо создания одного объекта");
            var row = dataTable.Rows[0];
            ModelsCompleteSetModel completeSetModel = 
                new ModelsCompleteSetModel(row.Field<string>(model.Title[(int)TitleType.nameComplete].Name),
                new EngineModel(null, 0, 0, 0, row.Field<string>(model.Title[(int)TitleType.engine].Name)),
                row.Field<double>(model.Title[(int)TitleType.costModel].Name),
                row.Field<double>(model.Title[(int)TitleType.rentPrice].Name),
                row.Field<string>(model.Title[(int)TitleType.gearboxType].Name),
                row.Field<int>(model.Title[(int)TitleType.amountSeat].Name));
            completeSetModel.Insert();
            Refresh();
        }


        public void Add(DataGridView dataGrid)
        {
            DataTable dataTable = (DataTable)dataGrid.DataSource;
            if (!Utils.IsIdenticalHeading(dataTable, model.Title))
            {
                MessageBox.Show("Не совпадение заголовков");
                return;
            }
            if (dataTable.Rows.Count > 1) MessageBox.Show("Допустимо создания одного объекта");
            var row = dataTable.Rows[0];
            ModelsCompleteSetModel completeSetModel =
                new ModelsCompleteSetModel(row.Field<string>(model.Title[(int)TitleType.nameComplete].Name),
                new EngineModel(null, 0, 0, 0, row.Field<string>(model.Title[(int)TitleType.engine].Name)),
                row.Field<double>(model.Title[(int)TitleType.costModel].Name),
                row.Field<double>(model.Title[(int)TitleType.rentPrice].Name),
                row.Field<string>(model.Title[(int)TitleType.gearboxType].Name),
                row.Field<int>(model.Title[(int)TitleType.amountSeat].Name));
            completeSetModel.Insert();
            Refresh();
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

        public override DataTable GetAllForView()
        {
            DataTable dataTable = new DataTable();
            models = model.GetAll();
            Utils.SetHeaderDateTable(dataTable, model.Title);
            foreach (var mol in models)
            {
                dataTable.Rows.Add(mol.FieldsAsString());
            }
            return dataTable;
        }

        public override DataTable GetAllForUpdate()
        {
            DataTable dataTable = new DataTable();
            models = model.GetAll();
            Utils.SetHeaderDateTable(dataTable, model.Title);
            foreach (var mol in models)
            {


                dataTable.Rows.Add(mol.FieldsAsString());
            }

            return dataTable;
        }

        public override void GetDataTableTitle(DataTable dataTable)
        {
            Utils.SetHeaderDateTable(dataTable, model.Title);
        }

        public override void Refresh()
        {
            models = model.GetAll();
        }

        public override void Update(DataTable dataTable, int indexRow)
        {
            if (!Utils.IsIdenticalHeading(dataTable, model.Title))
            {
                MessageBox.Show("Не совпадение заголовков");
                return;
            }
            if (indexRow > models.Count)
            {
                MessageBox.Show("Ошибка удаление не сущ элемент");
                return;
            }
            var row = dataTable.Rows[indexRow];
            models[indexRow].NameComplete = row.Field<string>(model.Title[(int)TitleType.nameComplete].Name);
            EngineModel engine = new EngineModel();
            engine= engine.GetOne(new EngineModel(row.Field<string>(model.Title[(int)TitleType.engine].Name)));
            models[indexRow].Engine = engine;
            models[indexRow].CostModel = row.Field<double>(model.Title[(int)TitleType.costModel].Name);
            models[indexRow].RentPrice = row.Field<double>(model.Title[(int)TitleType.rentPrice].Name);
            models[indexRow].GearboxType = row.Field<string>(model.Title[(int)TitleType.gearboxType].Name);
            models[indexRow].AmountSeat = row.Field<int>(model.Title[(int)TitleType.amountSeat].Name);
            models[indexRow].Update();
            Refresh();
        }
    }
}
