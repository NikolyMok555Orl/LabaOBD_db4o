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
    public partial class FormSpares : Form
    {
       
        SparesModel setModel;
        public FormSpares(SparesModel setModel)
        {
            this.setModel = setModel;
            InitializeComponent();
        }

        private void FormSpares_Load(object sender, EventArgs e)
        {
            textBoxName.Text = setModel.Name;
            textBoxCost.Text = setModel.Cost.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setModel.Name = textBoxName.Text;
            setModel.Cost = Convert.ToDouble(textBoxCost.Text);
          
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
