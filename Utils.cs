using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD
{
    static class Utils
    {
        public static void SetHeaderDateTable(DataTable dataTable, string [] headers)
        {
            foreach (var header in headers)
            {
                dataTable.Columns.Add(header);
            }
        }


        public static bool IsIdenticalHeading(DataTable dataTable, string[] headers)
        {
            if (dataTable.Columns.Count != headers.Length) return false;

            for (int i = 0; i < headers.Length; i++)
            {
                if (!dataTable.Columns[i].ColumnName.Equals(headers[i])) return false;
            }
            return true;
        }



    }
}
