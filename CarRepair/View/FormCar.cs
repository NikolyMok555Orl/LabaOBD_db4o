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
    public partial class FormCar : Form
    {
       
        CarRepairModel setModel;
        List<BreakingModel> sparesBreakings;
        List<BreakingModel> sparesBreaking=new List<BreakingModel>();

        public FormCar(CarRepairModel setModel, List<BreakingModel> sparesModels)
        {
            this.setModel = setModel;
            this.sparesBreakings = sparesModels;
            InitializeComponent();
        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            textBoxModel.Text = setModel.Model;
            textBoxBrand.Text = setModel.Brand;
            textBoxNumber.Text = setModel.Number;
            comboBoxBreakingModels.DataSource = sparesBreakings;
            comboBoxBreakingModels.DisplayMember = "Name";
            if (setModel.BreakingModels == null) setModel.BreakingModels = new List<BreakingModel>();
            sparesBreaking.AddRange(setModel.BreakingModels);
            listBoxBreakingModels.Items.AddRange(sparesBreaking.ConvertAll(it => it.Name).ToArray());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.Model = textBoxModel.Text;
            setModel.Brand = textBoxBrand.Text;
            setModel.Number = textBoxNumber.Text;

            if (sparesBreaking.Count > 0)
            {
                setModel.BreakingModels = sparesBreaking;
            }
            else
            {
                setModel.BreakingModels = null;
            }
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxBreakingModels.SelectedIndex >= 0)
            {
                sparesBreaking.Add(sparesBreakings[comboBoxBreakingModels.SelectedIndex]);
                listBoxBreakingModels.Items.Clear();
                listBoxBreakingModels.Items.AddRange(sparesBreaking.ConvertAll(it => it.Name).ToArray());
                listBoxBreakingModels.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxBreakingModels.SelectedIndex >= 0)
            {
                sparesBreaking.RemoveAt(comboBoxBreakingModels.SelectedIndex);
                listBoxBreakingModels.Items.Clear();
                listBoxBreakingModels.Items.AddRange(sparesBreaking.ConvertAll(it => it.Name).ToArray());
                listBoxBreakingModels.Refresh();
            }
        }
    }
}
