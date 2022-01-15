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
    class BreakingController : LabaOBD.Controller
    {

        static BreakingModel model = new BreakingModel();
        List<BreakingModel> models = new List<BreakingModel>();

        public override void Add()
        {
            BreakingModel newModel = new BreakingModel();
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
            BreakingModel updateModel = models[indexRow];
            if (ShowForm(updateModel) == DialogResult.OK)
                updateModel.Insert();
        }

        protected override DialogResult ShowForm(object modelThis)
        {
            if (modelThis is BreakingModel)
            {
                FormBreaking form = new FormBreaking(modelThis as BreakingModel, new SparesModel().GetAll());
                return form.ShowDialog();

            }
            else
            {
                return DialogResult.None;
            }
        }
    }
}
