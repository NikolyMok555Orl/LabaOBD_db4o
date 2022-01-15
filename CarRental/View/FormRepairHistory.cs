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
    public partial class FormRepairHistory : Form
    {
        List<CarModel> modelModels;
        RepairHistoryModel setModel;
        public FormRepairHistory(List<CarModel> modelModels, RepairHistoryModel setModel)
        {
            this.modelModels = modelModels;
            this.setModel = setModel;
            InitializeComponent();
           

        }

        private void FormRepairHistory_Load(object sender, EventArgs e)
        {
            comboBoxModel.DataSource = modelModels;
            comboBoxModel.DisplayMember = "Name";
            var index = modelModels.FindIndex(item => item == setModel.Car);
            comboBoxModel.SelectedIndex = index >= 0 ? index : 0;
            dateTimePickerStartDate.Value = setModel.StartDate;
            dateTimePickerEndDatePrimary.Value = setModel.EndDatePrimary;
            dateTimePickerEndDate.Value = setModel.EndDate;
            textBoxInitialAmount.Text=setModel.InitialAmount.ToString();
            textBoxFinalAmount.Text=setModel.FinalAmount.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.Car = modelModels[comboBoxModel.SelectedIndex];
            setModel.StartDate = dateTimePickerStartDate.Value;
            setModel.EndDatePrimary = dateTimePickerEndDatePrimary.Value;
            setModel.EndDate = dateTimePickerEndDate.Value;
            setModel.InitialAmount = Convert.ToDouble(textBoxInitialAmount.Text);
            setModel.FinalAmount = Convert.ToDouble(textBoxFinalAmount.Text);
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
