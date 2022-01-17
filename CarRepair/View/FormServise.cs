using LabaOBD.CarRepair.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOBD.CarRepair.View
{
    public partial class FormServise : Form
    {
        List<CarRepairModel> modelModels;
        ServiceModel setModel;
        public FormServise(ServiceModel setModel, List<CarRepairModel> modelModels)
        {
            this.modelModels = modelModels;
            this.setModel = setModel;
            InitializeComponent();
            if (!setModel.IsEmpty() && setModel.IsRepiar()) buttonFinalRemont.Visible = true;
        }

        private void FormServise_Load(object sender, EventArgs e)
        {
            comboBoxCar.DataSource = modelModels;
            comboBoxCar.DisplayMember = "Name";
            var index = modelModels.FindIndex(item => item == setModel.Car);
            comboBoxCar.SelectedIndex = index >= 0 ? index : 0;
            textBoxNameClient.Text = setModel.NameClient;
            textBoxPhoneClient.Text = setModel.PhoneClient;
            dateTimePickerDateStart.Value = setModel.DateStart;
            dateTimePickerDateFinal.Value = setModel.DateFinal;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.NameClient = textBoxNameClient.Text;
            setModel.PhoneClient =textBoxPhoneClient.Text;
            setModel.DateStart = dateTimePickerDateStart.Value;
            setModel.DateFinal = dateTimePickerDateFinal.Value;
            setModel.Car = modelModels[comboBoxCar.SelectedIndex];
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFinalRemont_Click(object sender, EventArgs e)
        {
            setModel.FinalRepair();
            Close();
        }
    }
}
