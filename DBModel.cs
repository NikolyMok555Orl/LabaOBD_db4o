using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD
{
    public abstract class DBModel<T>
    {


        public bool Insert()
        {
            GetDB.Store(this);
            return Conection.Commit();
        }
        public bool Delete() {
            GetDB.Delete(this);
            return Conection.Commit();
        }

        public bool Update()
        {
            GetDB.Store(this);
            return Conection.Commit();
        }


        public abstract bool IsEmpty();
        public List<T> GetAll()
        {
            var res = (GetDB.Query<T>());
            if (res != null)
            {
                return res.ToList();
            }
            else
            {
                return new List<T>();
            }
        }

        /// <summary>
        /// Получаем 1 объект
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public T GetOne(T model)
        {
            var res = GetDB.QueryByExample(model);
            if (res.HasNext())
            {
                return (T)res.Next();
            }
            else
            {
                return default(T);
            }

        }

        public abstract DB4oConection Conection { get; }

        public abstract IObjectContainer GetDB { get; }

        abstract public string[] FieldsAsString();



      
    }
}
