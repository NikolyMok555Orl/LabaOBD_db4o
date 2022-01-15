using LabaOBD.CarRental.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOBD
{
    public static class Utils
    {


        public static readonly DateTime MinDateDateTimePicker = new DateTime(1753, 1,1 );
        public static void SetHeaderDateTable(DataTable dataTable, Title [] headers)
        {
            foreach (var header in headers)
            {
                dataTable.Columns.Add(header.Name, header.Type);
            }
        }


        public static void SetHeaderDateTable(DataGridView dataGrid, Title[] headers)
        {
            foreach (var header in headers)
            {
                if (header.IsList)
                {
                    DataGridViewComboBoxColumn dataColumn = new DataGridViewComboBoxColumn();
                    dataColumn.HeaderText = header.Name;
                    dataGrid.Columns.Add(dataColumn);

                }
                else
                {
                    dataGrid.Columns.Add(header.Name, header.Name);
                    dataGrid.Columns[dataGrid.Columns.Count - 1].ValueType = header.Type;
                }
            }
        }


        public static bool IsIdenticalHeading(DataTable dataTable, Title[] headers)
        {
            if (dataTable.Columns.Count != headers.Length) return false;

            for (int i = 0; i < headers.Length; i++)
            {
                if (!(dataTable.Columns[i].ColumnName.Equals(headers[i].Name) && dataTable.Columns[i].DataType== headers[i].Type)) return false;
            }
            return true;
        }


       /* private DataGridViewComboBoxColumn AddComboboxColumn()
        {
            DataGridViewComboBoxColumn ColComboBox = new DataGridViewComboBoxColumn();
            dataGridView1.Columns.Add(ColComboBox);
            ColComboBox.DataPropertyName = "ScoreID";
            ColComboBox.HeaderText = "Category";
            ColComboBox.ValueType = typeof(string);
            ColComboBox.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            ColComboBox.DisplayIndex = 2;
            ColComboBox.Width = 150;
            ColComboBox.DataSource = oleDs;
            ColComboBox.DisplayMember = "description";
            ColComboBox.ValueMember = "ScoreID";
            ColComboBox.Name = "ScoreID";
            ColComboBox.DataPropertyName = "ScoreID";
        }*/

        public class Title
        {
            string name;
            Type type;
            bool isList=false;

            public Title(string name, Type type, bool isList =false)
            {
                this.name = name;
                this.type = type;
                this.isList = isList;
            }

            public string Name { get => name; set => name = value; }
            public Type Type { get => type; set => type = value; }
            public bool IsList { get => isList; set => isList = value; }
        }


    }
}
