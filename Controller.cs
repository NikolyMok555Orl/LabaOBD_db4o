using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabaOBD
{

    abstract class Controller
    {


        
       public abstract void GetDataTableTitle(DataTable dataTable);
       public abstract DataTable GetAll();


        public abstract void Add();



       public abstract void Update(int indexRow);

       public abstract void Delete(int indexRow);

        protected abstract DialogResult ShowForm(Object modelThis);
        public abstract void Refresh();

        public virtual DataTable GetReport(int index)
        {
            return new DataTable();
        }

    }
}
