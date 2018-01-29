using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mobile_July.BLL;


namespace Mobile_July
{
   
    public partial class FrmItemsCar : Form
    {

                BLL.connection ConnecOb = new connection();
                    
        public FrmItemsCar()
        {
            InitializeComponent();
        }
        DataTable DTItemInCar = new DataTable();
        SqlCeDataAdapter DA;

    public void SelectQuery(string Str)
    {
        SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
        SqlCeCommand myCommand = new SqlCeCommand(Str, MainConnection);

        try
        {
            if (MainConnection.State == ConnectionState.Closed)
            {
                MainConnection.Open();
            }

            DA = new SqlCeDataAdapter(myCommand);
            DA.Fill(DTItemInCar);
        }

        catch (System.Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

    }



        private void butCloseItems_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmItemsCar_Load(object sender, EventArgs e)
        {
            string SelectST = "Select  Items.Name, Items.Price ,SD.Quantity ,Items.IS_Available, Items.IS_DELETED From Salesman_Store AS SD inner join Items on SD.Item_ID= Items.ID where Items.IS_AVAILABLE='True' AND Items.IS_DELETED='FALSE'";

            DTItemInCar.Clear();
            SelectQuery(SelectST);
            this.dgItems.DataSource = DTItemInCar;
        }

        private void ButSearch_Click(object sender, EventArgs e)
        {
            string SelectST = "Select  Items.Name, Items.Price, SD.Quantity , Items.IS_Available, Items.IS_DELETED From Salesman_store AS SD inner join Items on SD.Item_ID= Items.ID where Items.IS_AVAILABLE='True' AND Items.IS_DELETED='FALSE' AND Items.Name like '%" + txtSearchName.Text + "%'";

            DTItemInCar.Clear();
            SelectQuery(SelectST);
            this.dgItems.DataSource = DTItemInCar;
        }
    }
}