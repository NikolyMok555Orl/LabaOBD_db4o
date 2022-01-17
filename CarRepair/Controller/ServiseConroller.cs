using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabaOBD.CarRepair.View;
using LabaOBD.CarRepair.Model;
using System.Data;
using System.Windows.Forms;

namespace LabaOBD.CarRepair.Controller
{
    class ServiseConroller : LabaOBD.Controller
    {
        static ServiceModel model = new ServiceModel();
        List<ServiceModel> models = new List<ServiceModel>();

        public override void Add()
        {
            ServiceModel newModel = new ServiceModel();
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
            Utils.SetHeaderDateTable(dataTable, model.Title);
        }

        public override void Refresh()
        {
            models = model.GetAll();
        }

        public override void Update(int indexRow)
        {
            ServiceModel updateModel = models[indexRow];
            if (ShowForm(updateModel) == DialogResult.OK)
                updateModel.Insert();
        }

        protected override DialogResult ShowForm(object modelThis)
        {
            if (modelThis is ServiceModel)
            {
                FormServise form = new FormServise(modelThis as ServiceModel, new CarRepairModel().GetAll());
                return form.ShowDialog();

            }
            else
            {
                return DialogResult.None;
            }
        }
    }
}
