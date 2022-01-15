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
    public partial class FormModelCompl : Form
    {
        List<EngineModel> engineModels;
        ModelsCompleteSetModel setModel;
        public FormModelCompl(List<EngineModel> engineModels, ModelsCompleteSetModel setModel)
        {
            this.engineModels = engineModels;
            this.setModel = setModel;
            InitializeComponent();
           

        }

        private void FormModelCompl_Load(object sender, EventArgs e)
        {
            comboBoxEngine.DataSource = engineModels;
            comboBoxEngine.DisplayMember = "Name";
            comboBoxGearboxTypes.DataSource = ModelsCompleteSetModel.gearboxTypes;
            textBoxNameComplete.Text = setModel.NameComplete;
            var index = engineModels.FindIndex(item => item == setModel.Engine);
            comboBoxEngine.SelectedIndex = index >= 0 ? index : 0;
            textBoxCostModel.Text = setModel.CostModel.ToString();
            textBoxRentPrice.Text= setModel.RentPrice.ToString();
            comboBoxGearboxTypes.Text = Array.Find(ModelsCompleteSetModel.gearboxTypes, it => it==(setModel.GearboxType));
            textBoxAmountSeat.Text=setModel.AmountSeat.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.NameComplete = textBoxNameComplete.Text;
            setModel.Engine = engineModels[comboBoxEngine.SelectedIndex];
            setModel.CostModel = Convert.ToDouble(textBoxCostModel.Text);
            setModel.RentPrice = Convert.ToDouble(textBoxRentPrice.Text);
            setModel.GearboxType = comboBoxGearboxTypes.Text;
            setModel.AmountSeat = Convert.ToInt32(textBoxAmountSeat.Text);
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
