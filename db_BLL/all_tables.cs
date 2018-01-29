using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace db_BLL
{

    public static class Tables_Invokers
    {
        public static string Action_Log { get { return "Action_Log"; } }
        public static string Area { get { return "Area"; } }
        public static string Category { get { return "Category"; } }
        public static string Control_Sections { get { return "Control_Sections"; } }
        public static string Customers { get { return "Customers"; } }
        public static string Customers_Bills { get { return "Customers_Bills"; } }
        public static string Customers_Bills_Details { get { return "Customers_Bills_Details"; } }
        public static string Customers_Group { get { return "Customers_Groups"; } }
        public static string Customers_Locations { get { return "Customers_Locations"; } }
        public static string Departments { get { return "Departments"; } }
        public static string Discounts { get { return "Discounts"; } }
        public static string Item_Properties { get { return "Item_Properties"; } }
        public static string Items { get { return "Items"; } }
        public static string Items_Properties { get { return "Items_Properties"; } }
        public static string Items_Providers { get { return "Items_Providers"; } }
        public static string Max_Balance_Limitation { get { return "Max_Balance_Limitation"; } }
        public static string Navigation_Customers { get { return "Navigation_Customers"; } }
        public static string Navigation_Types { get { return "Navigation_Types"; } }
        public static string Navigations_Routes { get { return "Navigations_Routes"; } }
        public static string Payment_Currencies { get { return "Payment_Currencies"; } }
        public static string Payments_Details { get { return "Payments_Details"; } }
        public static string Payments_Types { get { return "Payments_Types"; } }
        public static string Promotions { get { return "Promotions"; } }
        public static string Providers { get { return "Providers"; } }
        public static string Salesman_Store { get { return "Salesman_Store"; } }
        public static string Salesman_Visits { get { return "Salesman_Visits"; } }
        public static string Stores { get { return "Stores"; } }
        public static string Stores_Items { get { return "Stores_Items"; } }
        public static string Suggested_Clients { get { return "Suggested_Clients"; } }
        public static string Users { get { return "Users"; } }
        public static string Users_Cars { get { return "Users_Cars"; } }
        public static string Users_Days_Off { get { return "Users_Days_Off"; } }
        public static string Users_Payments { get { return "Users_Payments"; } }
        public static string Users_Permissions { get { return "Users_Permissions"; } }
        public static string Users_Types { get { return "Users_Types"; } }

    }



    public class all_tables
    {



        public List<string> init()
        {
            List<string> _t = new List<string>();
            _t.Add("Action_Log");
            _t.Add("Area");
            _t.Add("Category");
            _t.Add("Control_Sections");
            _t.Add("Customers");
            _t.Add("Customers_Bills");
            _t.Add("Customers_Bills_Details");
            _t.Add("Customers_Group");
            _t.Add("Customers_Groups");
            _t.Add("Customers_Locations");
            _t.Add("Departments");
            _t.Add("Discounts");
            _t.Add("Item_Properties");
            _t.Add("Items");
            _t.Add("Items_Properties");
            _t.Add("Items_Providers");
            _t.Add("Max_Balance_Limitation");
            _t.Add("Navigation_Customers");
            _t.Add("Navigation_Types");
            _t.Add("Navigations_Routes");
            _t.Add("Payment_Currencies");
            _t.Add("Payments_Details");
            _t.Add("Payments_Types");
            _t.Add("Promotions");
            _t.Add("Providers");
            _t.Add("Salesman_Store");
            _t.Add("Salesman_Visits");
            _t.Add("Stores");
            _t.Add("Stores_Items");
            _t.Add("Suggested_Clients");
            _t.Add("Users");
            _t.Add("Users_Cars");
            _t.Add("Users_Days_Off");
            _t.Add("Users_Payments");
            _t.Add("Users_Permissions");
            _t.Add("Users_Types");
            return _t;
        }







    }
}
