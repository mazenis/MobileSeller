using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_BLL
{
   public class MobTable
    {
       public MobTable init(string _Tablename, string _insert_PROC, string _update_PROC, string _delete_PROC)
       {
         //  MobTable _t = new MobTable();
           this.Tablename = _Tablename;
           this.insert_PROC = _insert_PROC;
           this.update_PROC = _update_PROC;
           this.delete_PROC = _delete_PROC;
           return this;
       } 

        public string Tablename { set; get; }
       public string insert_PROC { set; get; }
       public string update_PROC { set; get; }
       public string delete_PROC { set; get; }

    }
}
