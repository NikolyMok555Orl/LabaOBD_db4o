using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOBD
{
    public class DB4oConection
    {
        private String dbFileName = "data.data";
        private IObjectContainer db;

       
        public DB4oConection(string dbFileName)
        {
            this.dbFileName = dbFileName;
            db = null;

        }


        public IObjectContainer Db { get => db; private set => db = value; }

        public bool ConnectDB()
        {
            try
            {
                db = Db4oEmbedded.OpenFile(dbFileName);
                db.Ext().Configure().ActivationDepth(5);
                return true;

            }catch(Exception e)
            {
                return false;
            }
        }


        public bool Commit()
        {
            if (db != null)
            {
                db.Ext().Configure().ActivationDepth(5);
                db.Commit();
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Close()
        {
            if (db != null)
            {
                db.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
