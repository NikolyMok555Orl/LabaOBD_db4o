using Db4objects.Db4o;
using LabaOBD.CarRental.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOBD
{
    public partial class MainForm : Form
    {
        EngineController engineController = new EngineController();
        private enum TypeAction { Add, Update, Remote, None };


        struct ActionModel
        {
            private string name;
            private TypeAction actionType;

            public string Name { get => name; set => name = value; }
            public TypeAction ActionType { get => actionType; set => actionType = value; }

            public ActionModel(string name, TypeAction action)
            {
                this.name = name;
                this.actionType = action;
            }

        }

        List<ActionModel> actions = new List<ActionModel>()
        {
            { new ActionModel("Выбирте", TypeAction.None) },
            { new ActionModel("Добавить", TypeAction.Add) }, 
            { new ActionModel("Изменить", TypeAction.Update) }, 
            { new ActionModel("Удалить", TypeAction.Remote) }

        };

        Dictionary<string, Controller> disRentalModel = new Dictionary<string, Controller>
        {
            {"Обращение", null },
            {"Авто", null },
            {"Клиент", null },
            {"Скидка", null },
            {"Двигатель", new EngineController() },
            {"История штрафов", null },
            {"Модель", null },
            {"Комплектация модели", null },
            {"Штрафы", null },
            {"Рейтинг", null },
            {"История ремонта", null },

        };


        public MainForm()
        {
            InitializeComponent();
            comboBoxModelRental.DataSource = new BindingSource(disRentalModel, null); 
            comboBoxModelRental.DisplayMember = "Key";
            comboBoxModelRental.ValueMember = "Value";
            comboBoxActionRental.DataSource = actions;
            comboBoxActionRental.DisplayMember = "Name";
            comboBoxActionRental.ValueMember = "ActionType";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open database file "person.data"
            using (IObjectContainer db = Db4oEmbedded.OpenFile("person.data"))
            {
                 //declare some persons
                Person stefan = new Person("Max", "Mustermann", 17);
                Person pohl = new Person("Alfred", "Adams", 33);
                Person eckl = new Person("Florian", "Dietrich", 21);
                //store the persons in the database
                db.Store(stefan);
                db.Store(pohl);
                db.Store(eckl);
                db.Commit();
                //

                //fetch all Persons from the database
                IObjectSet result = db.QueryByExample(new Person(null, null, 0, null));

                //query through the results and print them out
                while (result.HasNext())
                {
                    Person next = (Person)result.Next();
                    MessageBox.Show(next.ToString());
                }

                Console.Read();

                //Close the database
                db.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Disconect();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!DB.Conect()) MessageBox.Show("Ошибка при подключение к бд");


        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
           // dataGridViewRental.DataSource=engineController.GetAllEngine();

        }

        private void buttonAddRental_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            engineController.GetDataTableTitle(dataTable);
            dataGridViewRental.DataSource = dataTable;

        }

        private void comboBoxModelRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAll();
        }



        private void GetAll()
        {
            var selected = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
            if (selected != null)
            {
                dataGridViewRental.DataSource = selected.GetAll();
            }
        }

        private void Add()
        {

        }

        private void Delete()
        {

        }

        private void Update()
        {

        }

        private void comboBoxActionRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModelRental.SelectedIndex > 0)
            {

                var selectet = (TypeAction)comboBoxActionRental.SelectedValue;
                switch (selectet)
                {
                    case TypeAction.Add:
                        {
                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
                            if (selected != null)
                            {
                                DataTable dataTable = new DataTable();
                                selected.GetDataTableTitle(dataTable);
                                dataTable.Rows.Add();
                                dataGridViewRental.DataSource = dataTable;

                                //dataGridViewRental.AllowUserToAddRows = false;
                            }

                            break;
                        }
                    case TypeAction.Update:
                        {
                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
                            if (selected != null)
                            {
                                dataGridViewRental.SelectionMode = DataGridViewSelectionMode.CellSelect;
                                dataGridViewRental.MultiSelect = false;
                                DataTable dataTable = new DataTable();
                                dataTable = selected.GetAll();
                                dataGridViewRental.DataSource = dataTable;
                            }



                            break;
                        }
                    case TypeAction.Remote:
                        {

                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
                            if (selected != null)
                            {
                                dataGridViewRental.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                dataGridViewRental.MultiSelect =false;
                                DataTable dataTable = new DataTable();
                                dataTable=selected.GetAll();
                                dataGridViewRental.DataSource = dataTable;
                            }
                            break;
                        }


                }
            }
        }

        private void buttonSaveRental_Click(object sender, EventArgs e)
        {
            var selectet = (TypeAction)comboBoxActionRental.SelectedValue;
            var selectedModel = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
            switch (selectet)
            {
                case TypeAction.Add:
                    {
                        DataTable dt = new DataTable();
                        dt = ((DataTable)dataGridViewRental.DataSource);
                        selectedModel.Add(dt);
                        GetAll();
                        break;
                    }
                case TypeAction.Update:
                    {
                        DataTable dt = new DataTable();
                        dt = ((DataTable)dataGridViewRental.DataSource);
                        selectedModel.Update(dt, dataGridViewRental.CurrentCell.RowIndex);
                        GetAll();
                        break;
                    }
                case TypeAction.Remote:
                    {
                        selectedModel.Delete(dataGridViewRental.CurrentCell.RowIndex);
                        GetAll();
                        break;
                    }
            }
        }
    }
}
