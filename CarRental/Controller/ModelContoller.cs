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
    class ModelContoller : LabaOBD.Controller
    {
        static ModelModel model = new ModelModel();

        List<ModelModel> models = new List<ModelModel>();

        public override void Add()
        {
            ModelModel completeSetModel = new ModelModel();
            if (ShowForm(completeSetModel) == DialogResult.OK)
                completeSetModel.Insert();
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

        public override void Update(int indexRow)
        {
            ModelModel completeSetModel = models[indexRow];
            if (ShowForm(completeSetModel) == DialogResult.OK)
                completeSetModel.Insert();
        }

        protected override DialogResult ShowForm(object modelThis)
        {
            if (modelThis is ModelModel)
            {
                FormModel form = new FormModel(new ModelsCompleteSetModel().GetAll(), modelThis as ModelModel);
                return form.ShowDialog();
            }
            else
            {
                return DialogResult.None;
            }
        }
    }
}
