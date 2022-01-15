using LabaOBD.CarRental.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOBD.CarRental.View
{
    public partial class FormModel : Form
    {
        List<ModelsCompleteSetModel> compectModels;
        ModelModel setModel;
        public FormModel(List<ModelsCompleteSetModel> engineModels, ModelModel setModel)
        {
            this.compectModels = engineModels;
            this.setModel = setModel;
            InitializeComponent();
           

        }

        private void FormModel_Load(object sender, EventArgs e)
        {
            comboBoxComplete.DataSource = compectModels;
            comboBoxComplete.DisplayMember = "Name";
            comboBoxBodyType.DataSource = ModelModel.bodyTypes;
            textBoxNameModel.Text = setModel.NameModel;
            var index = compectModels.FindIndex(item => item == setModel.Complete);
            comboBoxComplete.SelectedIndex = index >= 0 ? index : 0;
            textBoxBrand.Text = setModel.Brand.ToString();
            comboBoxBodyType.Text = Array.Find(ModelModel.bodyTypes, it => it==(setModel.BodyType));

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.NameModel = textBoxNameModel.Text;
            setModel.Complete = compectModels[comboBoxComplete.SelectedIndex];
            setModel.Brand =textBoxBrand.Text;
            setModel.BodyType = comboBoxBodyType.Text;
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
