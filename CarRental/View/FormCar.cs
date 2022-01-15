﻿using LabaOBD.CarRental.Model;
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
        CarModel setModel;
        public FormCar(List<ModelModel> modelModels, CarModel setModel)
        {
            this.modelModels = modelModels;
            this.setModel = setModel;
            InitializeComponent();
           

        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            comboBoxModel.DataSource = modelModels;
            comboBoxModel.DisplayMember = "Name";
            comboBoxConditionCar.DataSource =CarModel.conditionCarTypes;
            var index = modelModels.FindIndex(item => item == setModel.Model);
            comboBoxModel.SelectedIndex = index >= 0 ? index : 0;
            textBoxProductionYear.Text = setModel.ProductionYear.ToString();
            comboBoxConditionCar.Text = Array.Find(CarModel.conditionCarTypes, it => it == (setModel.ConditionCar));
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
    }
}
