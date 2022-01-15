using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabaOBD.CarRental.Model;
using LabaOBD.CarRental.View;

namespace LabaOBD.CarRental.Controller
{
    class RepairHistoryController : LabaOBD.Controller
    {
        static RepairHistoryModel model = new RepairHistoryModel();

        List<RepairHistoryModel> models = new List<RepairHistoryModel>();

        public override void Add()
        {
            RepairHistoryModel newModel = new RepairHistoryModel();
            if (ShowForm(newModel) == DialogResult.OK)
                newModel.Insert();
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
            var en = new RepairHistoryModel();
            Utils.SetHeaderDateTable(dataTable, en.Title);
        }

        public override void Refresh()
        {
            models = model.GetAll();
        }

        public override void Update(int indexRow)
        {
            RepairHistoryModel updateModel = models[indexRow];
            if (ShowForm(updateModel) == DialogResult.OK)
                updateModel.Insert();
        }

        protected override DialogResult ShowForm(object modelThis)
        {
            if (modelThis is RepairHistoryModel)
            {
                FormRepairHistory form = new FormRepairHistory(new CarModel().GetAll(), modelThis as RepairHistoryModel);
                return form.ShowDialog();
            }
            else
            {
                return DialogResult.None;
            }
        }
    }
}
