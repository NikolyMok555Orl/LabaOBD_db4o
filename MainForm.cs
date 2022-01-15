using Db4objects.Db4o;
using LabaOBD.CarRental.Controller;
using LabaOBD.CarRepair.Controller;
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
            { new ActionModel("Выберете", TypeAction.None) },
            { new ActionModel("Добавить", TypeAction.Add) }, 
            { new ActionModel("Изменить", TypeAction.Update) }, 
            { new ActionModel("Удалить", TypeAction.Remote) }

        };

        Dictionary<string, Controller> disRentalModel = new Dictionary<string, Controller>
        {
            {"Обращение", null },
            {"Авто", new CarContoller() },
            {"Клиент", null },
            {"Скидка", null },
            {"Двигатель", new EngineController() },
            {"История штрафов", null },
            {"Модель", new ModelContoller() },
            {"Комплектация модели", new  ModelCompleteSetController()},
            {"Штрафы", null },
            {"Рейтинг", null },
            {"История ремонта", new RepairHistoryController() },

        };

        Dictionary<string, Controller> disStoModel = new Dictionary<string, Controller>
        {
            {"Обращение", new ServiseConroller() },
            {"Авто", new CarConroller() },
            {"Запчасти", new  SparesController()},
            {"Список поломок", new BreakingController() },
        };


        public MainForm()
        {
            InitializeComponent();
           
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
            comboBoxModelRental.DataSource = new BindingSource(disRentalModel, null);
            comboBoxModelRental.DisplayMember = "Key";
            comboBoxModelRental.ValueMember = "Value";
            comboBoxActionRental.DataSource = actions;
            comboBoxActionRental.DisplayMember = "Name";
            comboBoxActionRental.ValueMember = "ActionType";

            comboBoxModelSto.DataSource = new BindingSource(disStoModel, null);
            comboBoxModelSto.DisplayMember = "Key";
            comboBoxModelSto.ValueMember = "Value";
            comboBoxActionSto.DataSource = actions;
            comboBoxActionSto.DisplayMember = "Name";
            comboBoxActionSto.ValueMember = "ActionType";

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
           // dataGridViewRental.DataSource=engineController.GetAllEngine();

        }


        private void comboBoxModelRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllCarRenal();
        }



        private void GetAllCarRenal()
        {
            var selected = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
            if (selected != null)
            {
                dataGridViewRental.DataSource = selected.GetAll();
            }
        }

        private void GetAllCarRepair()
        {
            var selected = ((KeyValuePair<string, Controller>)comboBoxModelSto.SelectedItem).Value;
            if (selected != null)
            {
                dataGridViewSto.DataSource = selected.GetAll();
            }
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
                                dataTable = selected.GetAll();
                                //dataGridViewRental.AllowUserToAddRows = false;
                                buttonSaveRental.Text = "Нажмите чтобы добавить";
                            }

                            break;
                        }
                    case TypeAction.Update:
                        {
                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
                            if (selected != null)
                            {
                                /*dataGridViewRental.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                dataGridViewRental.MultiSelect = false;*/
                                DataTable dataTable = new DataTable();
                                dataTable = selected.GetAll();
                                dataGridViewRental.DataSource = dataTable;
                                buttonSaveRental.Text = "Выбирете позицию, после нажмите для измениня";
                            }



                            break;
                        }
                    case TypeAction.Remote:
                        {

                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelRental.SelectedItem).Value;
                            if (selected != null)
                            {
                               /* dataGridViewRental.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                dataGridViewRental.MultiSelect =false;*/
                                DataTable dataTable = new DataTable();
                                dataTable=selected.GetAll();
                                dataGridViewRental.DataSource = dataTable;
                                buttonSaveRental.Text = "Выбирете позицию, после нажмите для удалиение";
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

                        //selectedModel.Add(dt);
                        selectedModel.Add();
                        GetAllCarRenal();
                        break;
                    }
                case TypeAction.Update:
                    {
                        DataTable dt = new DataTable();
                        dt = ((DataTable)dataGridViewRental.DataSource);
                        //selectedModel.Update(dt, dataGridViewRental.CurrentCell.RowIndex);
                        selectedModel.Update(dataGridViewRental.CurrentCell.RowIndex);
                        GetAllCarRenal();
                        break;
                    }
                case TypeAction.Remote:
                    {
                        selectedModel.Delete(dataGridViewRental.CurrentCell.RowIndex);
                        GetAllCarRenal();
                        break;
                    }
            }
        }

        private void comboBoxModelSto_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllCarRepair();
        }

        private void comboBoxActionSto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModelRental.SelectedIndex > 0)
            {

                var selectet = (TypeAction)comboBoxActionSto.SelectedValue;

                switch (selectet)
                {
                    case TypeAction.Add:
                        {
                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelSto.SelectedItem).Value;
                            if (selected != null)
                            {
                                DataTable dataTable = new DataTable();
                                selected.GetDataTableTitle(dataTable);
                                dataTable = selected.GetAll();
                                buttonSaveRental.Text = "Нажмите чтобы добавить";
                            }

                            break;
                        }
                    case TypeAction.Update:
                        {
                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelSto.SelectedItem).Value;
                            if (selected != null)
                            {

                                DataTable dataTable = new DataTable();
                                dataTable = selected.GetAll();
                                dataGridViewRental.DataSource = dataTable;
                                buttonSaveRental.Text = "Выбирете позицию, после нажмите для измениня";
                            }


                            break;
                        }
                    case TypeAction.Remote:
                        {

                            var selected = ((KeyValuePair<string, Controller>)comboBoxModelSto.SelectedItem).Value;
                            if (selected != null)
                            {
                                /* dataGridViewRental.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                 dataGridViewRental.MultiSelect =false;*/
                                DataTable dataTable = new DataTable();
                                dataTable = selected.GetAll();
                                dataGridViewRental.DataSource = dataTable;
                                buttonSaveRental.Text = "Выбирете позицию, после нажмите для удалиение";
                            }
                            break;
                        }


                }
            }
        }

        private void buttonSaveSto_Click(object sender, EventArgs e)
        {
            var selectet = (TypeAction)comboBoxActionSto.SelectedValue;
            var selectedModel = ((KeyValuePair<string, Controller>)comboBoxModelSto.SelectedItem).Value;
            switch (selectet)
            {
                case TypeAction.Add:
                    {
                        selectedModel.Add();
                        GetAllCarRepair();
                        break;
                    }
                case TypeAction.Update:
                    {

                        selectedModel.Update(dataGridViewSto.CurrentCell.RowIndex);
                        GetAllCarRepair();
                        break;
                    }
                case TypeAction.Remote:
                    {
                        selectedModel.Delete(dataGridViewSto.CurrentCell.RowIndex);
                        GetAllCarRepair();
                        break;
                    }
            }
        }
    }
}
