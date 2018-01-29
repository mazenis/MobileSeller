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
    public partial class frmCustomers : Form
    {
        DataTable DT = new DataTable();
        string UpdateST;
        string SelectST;
        string InsertST;
        bool AbortDetailSClient = true;

        BLL.connection ConnecOb = new connection();


        public frmCustomers()
        {
            InitializeComponent();
        }
        public Guid _____CustId { set; get; }
 
        private void button1_Click(object sender, EventArgs e)
        {
            pnlNew.BringToFront();
            txtCustName.Text = "";
            TxtAdrss.Text = "";
            txtPhon.Text = "";
            TitCombox.Text = "";
            txtMob.Text = "";
            btnSaveCustomer.Tag = "NEW";
            lblOperation.Text = "Add New Suggested Customer";
            CheckCanSale.Enabled = false;
            CheckSendBalance.Enabled = false;
            CheckDeleted.Enabled = false;
            CheckActive.Enabled = false;
            CheckDeleted.Enabled =false;
            MonthCal.Enabled = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //CustomersBLL _CustomersBLL = new CustomersBLL();
            try
            {     
                //bool Active = true;
                //bool CanSale = false;
                //bool Deleted = false;
                svumobilesales.somee.com.Service1 _s = new Mobile_July.svumobilesales.somee.com.Service1();
                bool SendBalance = true;
                switch (btnSaveCustomer.Tag.ToString())
                {
                    case "NEW": // New Suggested Client
                   
                        Guid CUSTOMER_ID = Guid.NewGuid();
                        Guid LOCATION_ID = Guid.NewGuid();

                        InsertST = "INSERT INTO Suggested_Clients (ID, Customer_Title, Fullname, Phone, Mobile, Address, Related_User_ID, Date_Added,LOCATION_ID , Send_Balance_Newsletter, Entry_Date, IS_ACKNOWLEDGE) VALUES" +
                            "('" + CUSTOMER_ID.ToString() + "','" + TitCombox.Text + "','" + txtCustName.Text + "','" + txtPhon.Text + "','" + txtMob.Text + "','" + TxtAdrss.Text + "','" + LogedIN.Current_USER.ToString() + "','" + DateTime.Now + "','"+LOCATION_ID.ToString()+"','True', '" + DateTime.Now + "' ,'False')";
                    DT.Clear();
                    UpdateInsertQu(InsertST);
                    Guid LogInsertId = Guid.NewGuid();

                        // Syc New Suggested Client
                    SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
                    if (MainConnection.State == ConnectionState.Closed)
                    {
                        MainConnection.Open();
                    }
                          try
                        {
                            string[] d = { CUSTOMER_ID.ToString(), TitCombox.Text, txtCustName.Text, TxtAdrss.Text, txtPhon.Text, txtMob.Text, DateTime.Now.ToString(), LOCATION_ID.ToString(), LogedIN.Current_USER.ToString(), "True", DateTime.Now.ToString(), "False"};
                            _s.Op(1, "Suggested_Clients", d);
                            string STR = "update Suggested_Clients set IS_ACKNOWLEDGE = 'True'  where ID = '" + CUSTOMER_ID.ToString() + "'";
                            SqlCeCommand UpdateCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateCommand.ExecuteNonQuery();
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            MessageBox.Show("No Connection you must resend Suggested Cust Info later");
                        }
                      
                        // Insert Local Action Log
                    string Log = "INSERT INTO Action_Log ( ID, User_ID, Section_ID, IS_Mobile, Related_Object_ID, Operation, Entry_Date, IS_ACKNOWLEDGE)" +
                    " VALUES ( '" + LogInsertId.ToString() + "','" + LogedIN.Current_USER.ToString() + "', '786d571a-1d3e-4c5d-9aad-c8ba08852f4b', 'True' ,'" + CUSTOMER_ID.ToString() + "','Insert Suggested Customers ',getdate(),'False' )";
                    UpdateInsertQu(Log);
                    
                    // Syc Action Log
                    try
                    {
                        string[] d = { LogInsertId.ToString(), LogedIN.Current_USER.ToString(), "4474031b-bc11-4037-85d9-3d52cc5356c3", "True", CUSTOMER_ID.ToString(), "Insert Act_Log Of Sugg_C", DateTime.Now.ToString(), "True" };
                        _s.Op(1, "Action_Log", d);
                        Log = "update Action_Log set IS_ACKNOWLEDGE = 'True'  where ID = '" + LogInsertId.ToString() + "'";
                        SqlCeCommand UpdateLastDetailCommand = new SqlCeCommand(Log, MainConnection);
                        UpdateLastDetailCommand.ExecuteNonQuery();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("No Connection you must resend Log Info later manually");
                    }

                    break;
                    case "EDIT":

                        if (CheckSendBalance.CheckState==CheckState.Unchecked)
                        {
                            SendBalance = false;
                        }
                        UpdateST = "UPDATE Customers SET Customer_Title = '" + TitCombox.Text + "', Address = '" + TxtAdrss.Text + "' , Fullname = '" + txtCustName.Text + "', Phone = '" + txtPhon.Text + "', Mobile ='" + txtMob.Text + "', Date_Added = '" + MonthCal.SelectionStart.Date.ToString() + "', Send_Balance_Newsletter = '" + SendBalance.ToString() + "' Where ID = '" + _____CustId.ToString() + "'";
                        UpdateInsertQu(UpdateST);
                        DT.Clear();
                        SelectQuery(SelectST);
                        dgCustomer.DataSource = DT;

                        Log = "INSERT INTO Action_Log ( ID, User_ID, Section_ID, IS_Mobile, Related_Object_ID, Operation, Entry_Date, IS_ACKNOWLEDGE)" +
                            " VALUES ( NEWID(),'" + LogedIN.Current_USER.ToString() + "', '4474031b-bc11-4037-85d9-3d52cc5356c3', 'True' ,'" + _____CustId.ToString()+ "','Update Customers Info',getdate(),'False' )";
                        UpdateInsertQu(Log);

                        break;
                }


               // LOADING();
                pnlNew.SendToBack();
                lblOperation.Text = "Customers";
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNew.SendToBack();
            lblOperation.Text = "Customers";
            ButSearch_Click(ButSearch, e);
        }

        public void SelectQuery(string Str)
        {
            SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
            SqlCeCommand myCommand = new SqlCeCommand(Str, MainConnection);
            if (MainConnection.State == ConnectionState.Closed)
            {
                MainConnection.Open();
            }
            try
            {
                if (MainConnection.State == ConnectionState.Closed)
                {
                    MainConnection.Open();
                }

                SqlCeDataAdapter DA = new SqlCeDataAdapter(myCommand);
                      DA.Fill(DT);
           }
                
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void UpdateInsertQu(string InsUpdateQu)
        {
            SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
           SqlCeCommand myCommand = new SqlCeCommand(InsUpdateQu, MainConnection);
           if (MainConnection.State == ConnectionState.Closed)
           {
               MainConnection.Open();
           }
            try
            {
                if (MainConnection.State == ConnectionState.Closed)
                {
                    MainConnection.Open();
                }

                myCommand.ExecuteNonQuery();
           }
                
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            SelectST = "Select * From customers where Related_User_ID = '" + LogedIN.Current_USER.ToString() + "'";
            DT.Clear();
            SelectQuery(SelectST);           
                dgCustomer.DataSource = DT;
            
           // LOADING();
        }

        private void dgCustomer_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                _____CustId = new Guid(dgCustomer[dgCustomer.HitTest(e.X, e.Y).Row, 0].ToString());
            }
            catch //(Exception _e)
            {
                  return ;
            }

              
            
        }

        private void dgCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (AbortDetailSClient == true)
                return;
            MonthCal.Enabled = true;
            CheckDeleted.Enabled = true;
            CheckActive.Enabled = true;
            CheckCanSale.Enabled = true;
            CheckSendBalance.Enabled = true;
            btnSaveCustomer.Tag = "EDIT";
            CustomersBLL _CustomersBLL = new CustomersBLL();
            DataTable dt = _CustomersBLL.Get_Data_BY_ID(_____CustId);
            txtCustName.Text = dt.Rows[0]["Fullname"].ToString();
            TxtAdrss.Text = dt.Rows[0]["Address"].ToString();
            txtMob.Text = dt.Rows[0]["Mobile"].ToString();
            txtPhon.Text = dt.Rows[0]["Phone"].ToString();
            TitCombox.Text = dt.Rows[0]["Customer_Title"].ToString();
            pnlNew.BringToFront();
            lblOperation.Text = "Edit Customer";
            if (dt.Rows[0]["IS_DELETED"].ToString() == "True")
            {
                CheckDeleted.CheckState = CheckState.Checked;
                CheckDeleted.Enabled = CheckActive.Enabled = CheckCanSale.Enabled = CheckSendBalance.Enabled = false;
                MonthCal.Enabled = btnSaveCustomer.Enabled = txtCustName.Enabled = TxtAdrss.Enabled = TxtAdrss.Enabled = false;
                txtMob.Enabled = txtPhon.Enabled = TitCombox.Enabled = false;
                MessageBox.Show("Deleted Client :" + dt.Rows[0]["Fullname"].ToString());
            }
            else
            {
                CheckDeleted.CheckState = CheckState.Unchecked;
            }
            if (dt.Rows[0]["IS_ACTIVE"].ToString() == "True")
            {
                CheckActive.CheckState = CheckState.Checked;
            }
            else
            {
                CheckActive.CheckState = CheckState.Unchecked;
            }
            if (dt.Rows[0]["Can_Sale"].ToString() == "True")
            {
                CheckCanSale.CheckState = CheckState.Checked;
            }
            else
            {
                MessageBox.Show("Can't Sale :" + dt.Rows[0]["Fullname"].ToString());
                CheckCanSale.CheckState = CheckState.Unchecked;
                CheckCanSale.Enabled = false;
            }
            if (dt.Rows[0]["Send_Balance_Newsletter"].ToString() == "True")
            {
                CheckSendBalance.CheckState = CheckState.Checked;
            }
            else
            {
                CheckSendBalance.CheckState = CheckState.Unchecked;
                
            }
            CheckDeleted.Enabled = false;
        }

        private void ButSearch_Click(object sender, EventArgs e)
        {
            SelectST = "Select * From customers where customers.Fullname like '%" + txtSearchName.Text + "%' ";
            DT.Clear();
            SelectQuery(SelectST);
            dgCustomer.DataSource = DT;
            AbortDetailSClient = false;
        }

        private void txtMob_LostFocus(object sender, EventArgs e)
        {
            int intMob;
            try
            {
                intMob = Convert.ToInt32(txtMob.Text);
            }
            catch
            {
               // MessageBox.Show("reenter Integer Number");
                txtMob.Focus();
                txtMob.SelectAll();
            }
        }

        private void txtPhon_LostFocus(object sender, EventArgs e)
        {
            int intPhone;
            try
            {
                intPhone = Convert.ToInt32(txtPhon.Text);
            }
            catch
            {
             //   MessageBox.Show("reenter Integer Number");
               txtPhon.SelectAll(); 
               txtPhon.Focus();
            }
        }

        private void butSearchSClint_Click(object sender, EventArgs e)
        {
            
            SelectST = "Select * From suggested_clients where suggested_clients.Fullname like '%" + txtSearchName.Text + "%' ";
            DT.Clear();
            SelectQuery(SelectST);
            dgCustomer.DataSource = DT;
            AbortDetailSClient = true;
        }

    }
}