using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Mobile_July.BLL;

 

namespace Mobile_July
{
    
    public partial class frmSelector : Form
    {
  
        public frmSelector()
        {
            InitializeComponent();
            
        }


        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //login
            string HashPass;
            using (MD5 md5Hash = MD5.Create())
            {
                HashPass = GetMd5Hash(md5Hash, txtPass.Text);

            }

            UsersBLL _usersobj = new UsersBLL();

            DataTable dt = _usersobj.LOGIN(textBox1.Text, HashPass);
            if (dt.Rows.Count > 0)
            {
  
                LogPanel.Hide();
                
                Guid _G = new Guid(dt.Rows[0]["ID"].ToString());
                LogedIN.Current_USER = _G;
                
                label1.Text = "Welcome " + dt.Rows[0]["FirstName"];
            }
            else { label5.Text = "Username or Password is incorrect";
              

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //start
            if (RBCusts.Checked)
            {
                frmCustomers _f = new frmCustomers();
                _f.Show();
            }
            else
            {
                if (RBBills.Checked)
                {
                    frmBills _bf = new frmBills();
                    _bf.Show();
                }
                else
                {
                    if (RBStores.Checked)
                    {
                      //  frmStore _S = new frmStore();
                      //  _S.Show();
                    }
                    else if (RBItems.Checked)
                    {
                        FrmItemsCar _IC = new FrmItemsCar();
                        _IC.Show();
                    }
                }
            }

        }

        public void frmSelector_Load(object sender, EventArgs e)
        {

        }

        private void ButCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButSync_Click(object sender, EventArgs e)
        {
         
            BLL.connection ConnecOb = new connection();
            SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
            if (MainConnection.State == ConnectionState.Closed)
            {
                MainConnection.Open();
            }

           string Str = "Select * from Customers_Bills";
            DataTable CustBillsDT = new DataTable();
            SqlCeCommand myCommand = new SqlCeCommand(Str, MainConnection);

           SqlCeDataAdapter DA = new SqlCeDataAdapter(myCommand);
            DA.Fill(CustBillsDT);
            if (CustBillsDT.Rows.Count > 0)
            {
                svumobilesales.somee.com.Service1 _s = new Mobile_July.svumobilesales.somee.com.Service1();
                for (int i = 0; i < CustBillsDT.Rows.Count; i++)
                {
                    if (CustBillsDT.Rows[i]["IS_ACKNOWLEDGE"].ToString() != "True")
                    {
                        try
                            {
                                string[] d = { CustBillsDT.Rows[i]["ID"].ToString(), CustBillsDT.Rows[i]["Customer_ID"].ToString(), CustBillsDT.Rows[i]["User_ID"].ToString(), CustBillsDT.Rows[i]["Bill_Date"].ToString(), CustBillsDT.Rows[i]["IS_Paid"].ToString(), "True", CustBillsDT.Rows[i]["IS_DELIVERED"].ToString(), CustBillsDT.Rows[i]["IS_CANCELED"].ToString(), CustBillsDT.Rows[i]["Note"].ToString(), CustBillsDT.Rows[i]["Entry_Date"].ToString(), CustBillsDT.Rows[i]["Unique_Bill_ID"].ToString(), CustBillsDT.Rows[i]["Bill_Status"].ToString(), CustBillsDT.Rows[i]["Bill_Type"].ToString(), CustBillsDT.Rows[i]["is_order"].ToString() };
                                _s.Op(1, "Customers_Bills", d);
                                string STR = "update Customers_Bills set IS_ACKNOWLEDGE = 'True'  where ID = '" + CustBillsDT.Rows[i]["ID"].ToString() + "'";
                                SqlCeCommand UpdateCommand = new SqlCeCommand(STR, MainConnection);
                                UpdateCommand.ExecuteNonQuery();

                            }
                        catch (System.Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                             //   MessageBox.Show("No Connection you must resend Bill Info later");
                            }
                    }
                }
            }

            Str = "Select * from Customers_Bills_Details";
            DataTable CustBillsDTD = new DataTable();
            myCommand = new SqlCeCommand(Str, MainConnection);
            DA = new SqlCeDataAdapter(myCommand);
            DA.Fill(CustBillsDTD);
            if (CustBillsDTD.Rows.Count > 0)
            {
                svumobilesales.somee.com.Service1 _s = new Mobile_July.svumobilesales.somee.com.Service1();
                for (int i = 0; i < CustBillsDTD.Rows.Count; i++)
                {
                    if (CustBillsDTD.Rows[i]["IS_ACKNOWLEDGE"].ToString() != "True")
                    {
                        try
                        {
                            string[] d = { CustBillsDTD.Rows[i]["ID"].ToString(), CustBillsDTD.Rows[i]["Bill_ID"].ToString(), CustBillsDTD.Rows[i]["Item_ID"].ToString(), CustBillsDTD.Rows[i]["Quantity"].ToString(), CustBillsDTD.Rows[i]["Price"].ToString(), "True"};
                            _s.Op(1, "Customers_Bills_Details", d);
                            string STR = "update Customers_Bills_Details set IS_ACKNOWLEDGE = 'True'  where ID = '" + CustBillsDTD.Rows[i]["ID"].ToString() + "'";
                            SqlCeCommand UpdateCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateCommand.ExecuteNonQuery();

                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                          //  MessageBox.Show("No Connection you must resend Info Bill Detail later ");
                        }
                      
                    }
                }
            }

             Str = "Select * from Action_Log";
            DataTable ActinLogtDT = new DataTable();
            myCommand = new SqlCeCommand(Str, MainConnection);
            DA = new SqlCeDataAdapter(myCommand);
            DA.Fill(ActinLogtDT);
            if (ActinLogtDT.Rows.Count > 0)
            {
                svumobilesales.somee.com.Service1 _s = new Mobile_July.svumobilesales.somee.com.Service1();
                for (int i = 0; i < ActinLogtDT.Rows.Count; i++)
                {
                    if (ActinLogtDT.Rows[i]["IS_ACKNOWLEDGE"].ToString() != "True")
                    {
                        try
                        {
                            string[] d = { ActinLogtDT.Rows[i]["ID"].ToString(), ActinLogtDT.Rows[i]["User_ID"].ToString(), ActinLogtDT.Rows[i]["Section_ID"].ToString(), ActinLogtDT.Rows[i]["Is_Mobile"].ToString(), ActinLogtDT.Rows[i]["Related_Object_ID"].ToString(), ActinLogtDT.Rows[i]["Operation"].ToString(), ActinLogtDT.Rows[i]["Entry_Date"].ToString(),"True"};
                            _s.Op(1, "Action_Log", d);
                            string STR = "update Action_Log set IS_ACKNOWLEDGE = 'True'  where ID = '" + ActinLogtDT.Rows[i]["ID"].ToString() + "'";
                            SqlCeCommand UpdateCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateCommand.ExecuteNonQuery();
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                          //  MessageBox.Show("No Connection you must resend Action Info later");
                        }
                    }
                }
            }

            Str = "Select * from Suggested_Clients";
            DataTable SugCustDT = new DataTable();
            myCommand = new SqlCeCommand(Str, MainConnection);
            DA = new SqlCeDataAdapter(myCommand);
            DA.Fill(SugCustDT);
            if (SugCustDT.Rows.Count > 0)
            {
                svumobilesales.somee.com.Service1 _s = new Mobile_July.svumobilesales.somee.com.Service1();
                for (int i = 0; i < SugCustDT.Rows.Count; i++)
                {
                    if (SugCustDT.Rows[i]["IS_ACKNOWLEDGE"].ToString() != "True")
                    {
                        try
                        {
                            string[] d = { SugCustDT.Rows[i]["ID"].ToString(), SugCustDT.Rows[i]["Customer_Title"].ToString(), SugCustDT.Rows[i]["Fullname"].ToString(), SugCustDT.Rows[i]["Address"].ToString(), SugCustDT.Rows[i]["Phone"].ToString(), SugCustDT.Rows[i]["Mobile"].ToString(), SugCustDT.Rows[i]["Date_Added"].ToString(), SugCustDT.Rows[i]["Location_ID"].ToString(), SugCustDT.Rows[i]["Related_User_ID"].ToString(), SugCustDT.Rows[i]["Send_Balance_Newsletter"].ToString(), SugCustDT.Rows[i]["Entry_Date"].ToString(), "True" };
                            _s.Op(1, "Suggested_Clients", d);
                            string STR = "update Suggested_Clients set IS_ACKNOWLEDGE = 'True'  where ID = '" + SugCustDT.Rows[i]["ID"].ToString() + "'";
                            SqlCeCommand UpdateCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateCommand.ExecuteNonQuery();
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                       //     MessageBox.Show("No Connection you must resend Suggested Cust Info later");
                        }
                    }
                }
            }
            MessageBox.Show("Synchronizing Done");
        }

    }
}