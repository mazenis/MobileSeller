using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Mobile_July.MobileSalesDataSetTableAdapters;

namespace Mobile_July.BLL
{
    
    public class UsersBLL
    {
        private UsersTableAdapter Holder;
        protected UsersTableAdapter Adapter
        {
            get
            {
                if (Holder == null)
                    Holder = new UsersTableAdapter();
                return Holder;
            }
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public MobileSalesDataSet.UsersDataTable Get_Data()
        {
            return Adapter.GetData();
        }
        public MobileSalesDataSet.UsersDataTable LOGIN(string uname, string pass)
        {
            return Adapter.GetDataBy_LOGIN(uname, pass);
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public int insert(Guid ID, Guid user_type_ID, Guid _Deparment_id, string usertitle, string firstname, string lastname, string position, string organization, DateTime join_date, string uname, string pass, DateTime entry_date, Guid unique_user_id, bool is_active)
        {
            int Ins = Convert.ToInt32(Adapter.Insert(ID, user_type_ID, _Deparment_id, usertitle
                , firstname, lastname
                , position, organization, join_date, uname, pass, entry_date, unique_user_id, is_active
                ));
            return Ins;
        }

        public bool Update(Guid ID, Guid user_type_ID, Guid _Deparment_id, string usertitle, string firstname, string lastname, string position, string organization, DateTime join_date, string uname, string pass, DateTime entry_date, Guid unique_user_id, bool is_active)
        {
            int upd = Adapter.Update(user_type_ID, _Deparment_id, usertitle, firstname, lastname, position, organization, join_date, uname, pass, entry_date, unique_user_id, is_active, ID);
            if (upd > 0) { return true; } else { return false; }
        }
       
    }
}
