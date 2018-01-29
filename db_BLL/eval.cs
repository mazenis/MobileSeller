using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace db_BLL
{
    public class eval : global::System.Configuration.ApplicationSettingsBase
    {
        public static String AlaaConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionStrMobileSales"].ConnectionString;
            }
        }


    }
}
