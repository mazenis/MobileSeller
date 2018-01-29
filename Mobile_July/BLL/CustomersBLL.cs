using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Mobile_July.MobileSalesDataSetTableAdapters;

namespace Mobile_July.BLL
{
    public class CustomersBLL
    {
        private CustomersTableAdapter Holder;
        protected CustomersTableAdapter Adapter
        {
            get
            {
                if (Holder == null)
                    Holder = new CustomersTableAdapter();
                return Holder;
            }
        }

        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public MobileSalesDataSet.CustomersDataTable Get_Data()
        {
            return Adapter.GetData();
        }
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public MobileSalesDataSet.CustomersDataTable Get_Data_BY_ID(Guid _customer_ID)
        {
            return Adapter.GetDataBy___ID(_customer_ID);
        }



        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public MobileSalesDataSet.CustomersDataTable Get_Data_BY_Related_User_ID(Guid Related_User_ID)
        {
            return Adapter.GetDataBy__Related_User_ID(Related_User_ID);
        }



       [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public int insertQuery(Guid ID, string Customer_Title, string Fullname, string Phone, string Address, Guid? Related_User_ID)
        {
            return Adapter.InsertQuery(ID, Customer_Title, Fullname, Address, Phone, Related_User_ID, DateTime.Now, Guid.NewGuid());

        }


        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public void UpdateQuery(Guid ID, string Customer_Title, string Fullname, string Phone, string Address)
        {
            Adapter.UpdateQuery(Customer_Title, Fullname, Address, Phone, ID);
        }


    }
}
