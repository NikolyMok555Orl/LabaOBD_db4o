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
    public partial class FormCar : Form
    {
        List<ModelModel> modelModels;
        CarRentalModel setModel;
        public FormCar(List<ModelModel> modelModels, CarRentalModel setModel)
        {
            this.modelModels = modelModels;
            this.setModel = setModel;
            InitializeComponent();
            if (!setModel.IsEmpty()) buttonSendRepir.Visible = true;

        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            comboBoxModel.DataSource = modelModels;
            comboBoxModel.DisplayMember = "Name";
            comboBoxConditionCar.DataSource =CarRentalModel.conditionCarTypes;
            var index = modelModels.FindIndex(item => item == setModel.Model);
            comboBoxModel.SelectedIndex = index >= 0 ? index : 0;
            textBoxProductionYear.Text = setModel.ProductionYear.ToString();
            comboBoxConditionCar.Text = Array.Find(CarRentalModel.conditionCarTypes, it => it == (setModel.ConditionCar));
            textBoxColor.Text= setModel.Color.ToString();
            textBoxNumber.Text=setModel.Number.ToString();
            textBoxMileage.Text=setModel.Mileage.ToString();
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.Model = modelModels[comboBoxModel.SelectedIndex];
            setModel.ProductionYear = Convert.ToInt32(textBoxProductionYear.Text);
            setModel.ConditionCar = comboBoxConditionCar.Text;
            setModel.Color = textBoxColor.Text;
            setModel.Number = textBoxNumber.Text;
            setModel.Mileage = Convert.ToInt32(textBoxMileage.Text);
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSendRepir_Click(object sender, EventArgs e)
        {
            setModel.SendForRepair();
            Close();
        }
    }
}
