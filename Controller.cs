using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD
{
    abstract class Controller
    {

       public abstract void GetDataTableTitle(DataTable dataTable);
       public abstract DataTable GetAllForView();

        public abstract DataTable GetAllForUpdate();
        public abstract void Add(DataTable dataTable);
       public abstract void Update(DataTable dataTable, int indexRow);

       public abstract void Delete(int indexRow);

        public abstract void ShowForm(int indexModel);
        public abstract void Refresh();



    }
}
