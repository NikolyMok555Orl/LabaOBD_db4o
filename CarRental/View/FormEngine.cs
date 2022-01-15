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
    public partial class FormEngine : Form
    {
       
        EngineModel setModel;
        public FormEngine(EngineModel setModel)
        {
            this.setModel = setModel;
            InitializeComponent();
           

        }

        private void FormEngine_Load(object sender, EventArgs e)
        {
            comboBoxTypes.DataSource = EngineModel.engineTypeMass;
            textBoxName.Text = setModel.Name;
            textBoxPower.Text = setModel.Power.ToString();
            textBoxFuelConsumption.Text= setModel.FuelConsumption.ToString();
            comboBoxTypes.Text = setModel.Type;
            textBoxVolume.Text=setModel.Volume.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.Name = textBoxName.Text;
            setModel.Power = Convert.ToInt32(textBoxPower.Text);
            setModel.FuelConsumption = Convert.ToDouble(textBoxFuelConsumption.Text);
            setModel.Type = comboBoxTypes.SelectedItem.ToString();
            setModel.Volume = Convert.ToInt32(textBoxVolume.Text);
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
