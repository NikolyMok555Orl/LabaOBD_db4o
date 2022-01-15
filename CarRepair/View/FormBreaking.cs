using LabaOBD.CarRental.Model;
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
    public partial class FormBreaking : Form
    {
       
        BreakingModel setModel;
        List<SparesModel> sparesModels;
        List<SparesModel> sparesBreaking=new List<SparesModel>();

        public FormBreaking(BreakingModel setModel, List<SparesModel> sparesModels)
        {
            this.setModel = setModel;
            this.sparesModels = sparesModels;
            InitializeComponent();
        }

        private void FormBreaking_Load(object sender, EventArgs e)
        {
            textBoxName.Text = setModel.Name;
            textBoxCostRepair.Text = setModel.CostRepair.ToString();
            comboBoxSpares.DataSource = sparesModels;
            comboBoxSpares.DisplayMember = "Name";
            if (setModel.SparesModels == null) setModel.SparesModels = new List<SparesModel>();
            sparesBreaking.AddRange(setModel.SparesModels);
            listBoxSpares.Items.AddRange(sparesBreaking.ConvertAll(it => it.Name).ToArray());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.Name = textBoxName.Text;
            setModel.CostRepair = Convert.ToDouble(textBoxCostRepair.Text);
            if (sparesBreaking.Count > 0)
            {
                setModel.SparesModels = sparesBreaking;
            }
            else
            {
                setModel.SparesModels = null;
            }
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSpares.SelectedIndex >= 0)
            {
                sparesBreaking.Add(sparesModels[comboBoxSpares.SelectedIndex]);
                listBoxSpares.Items.Clear();
                listBoxSpares.Items.AddRange(sparesBreaking.ConvertAll(it => it.Name).ToArray());
                listBoxSpares.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSpares.SelectedIndex >= 0)
            {
                sparesBreaking.RemoveAt(comboBoxSpares.SelectedIndex);
                listBoxSpares.Items.Clear();
                listBoxSpares.Items.AddRange(sparesBreaking.ConvertAll(it => it.Name).ToArray());
                listBoxSpares.Refresh();
            }
        }
    }
}
