using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_BLL
{
    public class TablesLista
    {
        List<MobTable> Tables_LISTA { set; get; }


        public List<MobTable> init()
        {
            List<MobTable> ___Tables_LISTA = new List<MobTable>();


            MobTable _Action_Log = new MobTable(); _Action_Log.init("Action_Log", "", "", ""); ___Tables_LISTA.Add(_Action_Log);
            MobTable _Area = new MobTable(); _Area.init("Area", "", "", ""); ___Tables_LISTA.Add(_Area);
            MobTable _Category = new MobTable(); _Category.init("Category", "", "", ""); ___Tables_LISTA.Add(_Category);
            MobTable _Control_Sections = new MobTable(); _Control_Sections.init("Control_Sections", "", "", ""); ___Tables_LISTA.Add(_Control_Sections);
            MobTable _Customers = new MobTable(); _Customers.init("Customers", "", "", ""); ___Tables_LISTA.Add(_Customers);
            MobTable _Customers_Bills = new MobTable(); _Customers_Bills.init("Customers_Bills", "", "", ""); ___Tables_LISTA.Add(_Customers_Bills);
            MobTable _Customers_Bills_Details = new MobTable(); _Customers_Bills_Details.init("Customers_Bills_Details", "", "", ""); ___Tables_LISTA.Add(_Customers_Bills_Details);
            MobTable _Customers_Group = new MobTable(); _Customers_Group.init("Customers_Group", "", "", ""); ___Tables_LISTA.Add(_Customers_Group);
            MobTable _Customers_Groups = new MobTable(); _Customers_Groups.init("Customers_Groups", "", "", ""); ___Tables_LISTA.Add(_Customers_Groups);
            MobTable _Customers_Locations = new MobTable(); _Customers_Locations.init("Customers_Locations", "", "", ""); ___Tables_LISTA.Add(_Customers_Locations);
            MobTable _Departments = new MobTable(); _Departments.init("Departments", "", "", ""); ___Tables_LISTA.Add(_Departments);
            MobTable _Discounts = new MobTable(); _Discounts.init("Discounts", "", "", ""); ___Tables_LISTA.Add(_Discounts);
            MobTable _Item_Properties = new MobTable(); _Item_Properties.init("Item_Properties", "", "", ""); ___Tables_LISTA.Add(_Item_Properties);
            MobTable _Items = new MobTable(); _Items.init("Items", "", "", ""); ___Tables_LISTA.Add(_Items);
            MobTable _Items_Properties = new MobTable(); _Items_Properties.init("Items_Properties", "", "", ""); ___Tables_LISTA.Add(_Items_Properties);
            MobTable _Items_Providers = new MobTable(); _Items_Providers.init("Items_Providers", "", "", ""); ___Tables_LISTA.Add(_Items_Providers);
            MobTable _Max_Balance_Limitation = new MobTable(); _Max_Balance_Limitation.init("Max_Balance_Limitation", "", "", ""); ___Tables_LISTA.Add(_Max_Balance_Limitation);
            MobTable _Navigation_Customers = new MobTable(); _Navigation_Customers.init("Navigation_Customers", "", "", ""); ___Tables_LISTA.Add(_Navigation_Customers);
            MobTable _Navigation_Types = new MobTable(); _Navigation_Types.init("Navigation_Types", "", "", ""); ___Tables_LISTA.Add(_Navigation_Types);
            MobTable _Navigations_Routes = new MobTable(); _Navigations_Routes.init("Navigations_Routes", "", "", ""); ___Tables_LISTA.Add(_Navigations_Routes);
            MobTable _Payment_Currencies = new MobTable(); _Payment_Currencies.init("Payment_Currencies", "", "", ""); ___Tables_LISTA.Add(_Payment_Currencies);
            MobTable _Payments_Details = new MobTable(); _Payments_Details.init("Payments_Details", "", "", ""); ___Tables_LISTA.Add(_Payments_Details);
            MobTable _Payments_Types = new MobTable(); _Payments_Types.init("Payments_Types", "", "", ""); ___Tables_LISTA.Add(_Payments_Types);
            MobTable _Promotions = new MobTable(); _Promotions.init("Promotions", "", "", ""); ___Tables_LISTA.Add(_Promotions);
            MobTable _Providers = new MobTable(); _Providers.init("Providers", "", "", ""); ___Tables_LISTA.Add(_Providers);
            MobTable _Salesman_Store = new MobTable(); _Salesman_Store.init("Salesman_Store", "", "", ""); ___Tables_LISTA.Add(_Salesman_Store);
            MobTable _Salesman_Visits = new MobTable(); _Salesman_Visits.init("Salesman_Visits", "", "", ""); ___Tables_LISTA.Add(_Salesman_Visits);
            MobTable _Stores = new MobTable(); _Stores.init("Stores", "", "", ""); ___Tables_LISTA.Add(_Stores);
            MobTable _Stores_Items = new MobTable(); _Stores_Items.init("Stores_Items", "", "", ""); ___Tables_LISTA.Add(_Stores_Items);
            MobTable _Suggested_Clients = new MobTable(); _Suggested_Clients.init("Suggested_Clients", "", "", ""); ___Tables_LISTA.Add(_Suggested_Clients);
            MobTable _Users = new MobTable(); _Users.init("Users", "", "", ""); ___Tables_LISTA.Add(_Users);
            MobTable _Users_Cars = new MobTable(); _Users_Cars.init("Users_Cars", "", "", ""); ___Tables_LISTA.Add(_Users_Cars);
            MobTable _Users_Days_Off = new MobTable(); _Users_Days_Off.init("Users_Days_Off", "", "", ""); ___Tables_LISTA.Add(_Users_Days_Off);
            MobTable _Users_Payments = new MobTable(); _Users_Payments.init("Users_Payments", "", "", ""); ___Tables_LISTA.Add(_Users_Payments);
            MobTable _Users_Permissions = new MobTable(); _Users_Permissions.init("Users_Permissions", "", "", ""); ___Tables_LISTA.Add(_Users_Permissions);
            MobTable _Users_Types = new MobTable(); _Users_Types.init("Users_Types", "", "", ""); ___Tables_LISTA.Add(_Users_Types);
            
            return ___Tables_LISTA;
        }




    }
}
