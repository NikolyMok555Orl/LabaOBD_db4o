using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabaOBD.CarRepair.View;
using LabaOBD.CarRepair.Model;

namespace LabaOBD.CarRepair.Controller
{
    class SparesController : LabaOBD.Controller
    {
        static SparesModel model = new SparesModel();
        List<SparesModel> models = new List<SparesModel>();

        public override void Add()
        {
            SparesModel newModel = new SparesModel();
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
            SparesModel updateModel = models[indexRow];
            if (ShowForm(updateModel) == DialogResult.OK)
                updateModel.Insert();
        }

        protected override DialogResult ShowForm(object modelThis)
        {
            if (modelThis is SparesModel)
            {
                FormSpares form = new FormSpares(modelThis as SparesModel);
                 return form.ShowDialog();
              
            }
            else
            {
                return DialogResult.None;
            }
        }
    }
}
