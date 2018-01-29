using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace Mobile_July.BLL
{
    public class connection
    {
public string MainCString = "Data Source=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString() + "\\mobilesales.sdf";
public Guid CustID;
           
    }
}
