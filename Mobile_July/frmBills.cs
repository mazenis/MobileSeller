using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Windows.Forms;
using Mobile_July.BLL;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;

namespace Mobile_July
{

    // ConnMgrEstablishConnectionSync

    public partial class frmBills : Form
    {
        DataTable DT = new DataTable();
        DataTable DT1 = new DataTable();
        DataTable DTNewBillNewItem = new DataTable();
        DataTable ComboCustDT = new DataTable();
        DataTable ComboItemsDT = new DataTable();
        DataTable DTItemInCar = new DataTable();
        DataTable addCmbStatus = new DataTable("Category");
        Guid NewBillID;
        bool FirstItem = false;
        // string UpdateST;
        string SelectST;
        //  string InsertST;
        string cmboType;
        int DetailIndex = 0;

        string BillStatus = ""; // Bill Changed Or New one
        string ItemStatus = "OldItem"; // For any Item InsertItem, ChangedItem, OldItem
        string ComberTxtChanges = "";
        bool Detail = false;        // work in Bill Or in Bill Details
        bool ItemInCar = false;     // the Operation for detact if item in car or not
        BLL.connection ConnecOb = new connection();
        public frmBills()
        {
            InitializeComponent();
        }

        public Guid _____CustId { set; get; }
        public Guid __Bill_ID { set; get; }


        public void SycItems()
        {
            char Row_spliter = '^';
            char Column_split = '#';
            svumobilesales.somee.com.Service1 _s = new Mobile_July.svumobilesales.somee.com.Service1();
            SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
            if (MainConnection.State == ConnectionState.Closed)
            {
                MainConnection.Open();
            }
            //SELECT EXAMPLE
            ArrayList _params = new ArrayList();
            try
            {
                var _Items_from_db = _s.GET_Op("Items", "SELECT * FROM Items where IS_DELETED='false'", _params.ToArray());
                //test
                // var _Items_from_db="423c5871-685f-4cc5-bbb2-07258bcbd278#Samsung Androidd#15000#True#False#9/8/2011 2:07:58 AM#6c2da47b-0f86-4355-b814-6aea5057cf2e#^b953c931-e491-4126-a2e2-1fe29c1eac1e#GOOGLE ANDROID #22222#True#False#9/8/2011 2:17:38 AM#828abe47-ecb1-48a2-8db3-28f799329348#^2563d75c-baad-42d4-982f-254079ec8ecd#iphone#222#False#False#9/7/2011 8:38:41 AM#b24c830d-e4e4-438e-a962-29ef6ae9c314#^79717cbe-151e-4ba3-8cb6-2f48555e392f#IPad#20000#True#False#9/8/2011 10:32:54 AM#7f6d9188-6fe4-445e-a845-0dde83323da3#^0d84531a-3e9a-4162-8b7c-904804dc76ec#ASP.net Website#25000#False#False#9/8/2011 2:08:53 AM#142ffef6-85e9-4415-a622-aca0dd55aaa2#^4436ab53-a3ed-44ed-9e0a-91772344a5e6#PHP Website#20000#True#False#9/8/2011 2:09:06 AM#e1e02c58-2e6c-45ed-8509-2d6db28ebec6#^a0bd8083-c459-45b7-887b-cfa0db9270fe#NOKIA N73#50000#True#False#9/8/2011 10:43:57 AM#44df5c5c-f2e8-4893-a0a1-c43c29d4f2e9#^";


                string[] _Item_s = _Items_from_db.Split(Row_spliter);
                DataTable ItemTable = new DataTable();
                ItemTable.Columns.Add("ID");
                ItemTable.Columns.Add("Name");
                ItemTable.Columns.Add("Price");
                ItemTable.Columns.Add("IS_AVAILABLE");
                ItemTable.Columns.Add("IS_DELETED");
                ItemTable.Columns.Add("Entry_Date");
                ItemTable.Columns.Add("Unique_Item_ID");

                foreach (string _uDATA in _Item_s)
                {
                    int i = 0;
                    string[] _data = _uDATA.Split(Column_split);
                    DataRow itemrow = ItemTable.NewRow();

                    foreach (string _obj in _data)
                    {
                        itemrow[i]=_obj.ToString();
                        if (i == 6)
                            break;
                        i++;
                    }
                    ItemTable.Rows.Add(itemrow);
                }
                ComboItemsDT.Clear();
                // I must to change cash DT and then insert 
                // and can do in Opposite way..

                ComboItemsDT = ItemTable.Copy();
                cmboItem.DataSource = ComboItemsDT;
                cmboItem.DisplayMember = "Name";
                cmboItem.ValueMember = "ID";


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            // Delete X Items
            try
            {
                //string STR = "Delet From Items";
                string STR = "DELETE FROM Items";
                SqlCeCommand DeletItemsCommand = new SqlCeCommand(STR, MainConnection);
                DeletItemsCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            // Inset New Items
            try
            {

                for (int i = 0; i < ComboItemsDT.Rows.Count-1; i++)
                {
                    string STR = "INSERT INTO Items ( ID, Name, Price , IS_AVAILABLE, IS_DELETED, Entry_Date,Unique_Item_ID)" +
                             "VALUES ( '" + ComboItemsDT.Rows[i]["ID"].ToString() + "','" + ComboItemsDT.Rows[i]["Name"].ToString() + "','" + ComboItemsDT.Rows[i]["Price"].ToString() + "','" + ComboItemsDT.Rows[i]["IS_AVAILABLE"].ToString() + "','" + ComboItemsDT.Rows[i]["IS_DELETED"].ToString() + "','" + ComboItemsDT.Rows[i]["Entry_Date"].ToString() + "','" + ComboItemsDT.Rows[i]["Unique_Item_ID"].ToString() + "')";
                    SqlCeCommand InsertBillCommand = new SqlCeCommand(STR, MainConnection);
                    InsertBillCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

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

                SqlCeDataAdapter DA = new SqlCeDataAdapter(myCommand);
                if (Detail & FirstItem == false)
                {
                    DT1.Clear();
                    DA.Fill(DT1);
                    Detail = false;
                }
                else
                {
                    if (FirstItem == false)
                    {
                        DT.Clear();
                        DA.Fill(DT);
                        dgBills.DataSource = DT;
                    }
                }
                if (this.BillStatus == "New" & FirstItem)
                {
                    DTNewBillNewItem.Clear();
                    DA.Fill(DTNewBillNewItem);
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        public void SelectCombo(string Str)
        {
            SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
            SqlCeCommand myCommand = new SqlCeCommand(Str, MainConnection);

            try
            {
                if (MainConnection.State == ConnectionState.Closed)
                {
                    MainConnection.Open();
                }

                SqlCeDataAdapter DA = new SqlCeDataAdapter(myCommand);
                if (cmboType == "Cust")
                {
                    ComboCustDT.Clear();
                    DA.Fill(ComboCustDT);
                    cmboType = "";
                    cmboCustName.DataSource = ComboCustDT;
                    cmboCustName.DisplayMember = "Fullname";
                    cmboCustName.ValueMember = "ID";
                }
                else
                {
                    if (cmboType == "Items" & ItemInCar == false)
                    {
                        ComboItemsDT.Clear();
                        DA.Fill(ComboItemsDT);
                        cmboType = "";
                        cmboItem.DataSource = ComboItemsDT;
                        cmboItem.DisplayMember = "Name";
                        cmboItem.ValueMember = "ID";

                    }
                    else if (cmboType == "ItemsInCar" & ItemInCar == true)
                    {
                        DTItemInCar.Clear();
                        DA.Fill(DTItemInCar);
                        cmboType = "";
                        ItemInCar = false;
                    }
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string SelectQuant(Guid ItemID)
        {
            string Quant;
            try
            {
                SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);
                if (MainConnection.State == ConnectionState.Closed)
                {
                    MainConnection.Open();
                }

                string SelectOldQu = "select quantity from Salesman_store where Item_ID= '" + ItemID.ToString() + "'";
                SqlCeCommand myCommand = new SqlCeCommand(SelectOldQu, MainConnection);
                DataTable TempDT = new DataTable();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(myCommand);
                DA.Fill(TempDT);

                Quant = TempDT.Rows[0]["quantity"].ToString();


            }
            catch
            {
                return "0";
            }

            return Quant;
        }

        public void InsertUpdatQu()//string OperationKind)
        {
            //Insert Update C_Bill

            SqlCeConnection MainConnection = new SqlCeConnection(ConnecOb.MainCString);

            try
            {
                if (MainConnection.State == ConnectionState.Closed)
                {
                    MainConnection.Open();
                }
                svumobilesales.somee.com.Service1 _s = new Mobile_July.svumobilesales.somee.com.Service1();
                string Delivered, Paid, CANCELED, Order, status;

                if (this.CheckDelivered.CheckState == CheckState.Checked)
                {
                    Delivered = "True";
                }
                else
                {
                    Delivered = "False";
                }

                if (this.CheckIsPaid.CheckState == CheckState.Checked)
                {
                    Paid = "True";
                }
                else
                {
                    Paid = "False";
                }
                if (this.CheckCanceled.CheckState == CheckState.Checked)
                {
                    CANCELED = "True";
                }
                else
                {
                    CANCELED = "False";
                }
                if (this.CheckIsOrder.CheckState == CheckState.Checked)
                {
                    Order = "True";
                }
                else
                {
                    Order = "False";
                }
                if (this.BillStatus == "New")
                {
                    status = "2";
                }
                else if (this.BillStatus == "Changed")
                {
                    status = "3";
                }
                else
                {
                    status = "1";
                }
                if (BillStatus == "New")
                {
                    string InsertBillDate = DateTime.Now.ToString();
                    Guid UniqBillID = Guid.NewGuid();

                    string STR = "INSERT INTO Customers_Bills ( Bill_Date, ID, Customer_ID, User_ID, IS_PAID, IS_ACKNOWLEDGE, IS_DELIVERED, IS_CANCELED, Note, Entry_Date,Unique_Bill_ID , Bill_Status, Bill_Type, IS_ORDER)" +
                     "VALUES ( '" + InsertBillDate + "','" + NewBillID + "','" + this.cmboCustName.SelectedValue.ToString() + "','" + LogedIN.Current_USER.ToString() + "','" + Paid + "','False','" + Delivered + "','False','" + txtNotes.Text + "','" + InsertBillDate + "', '" + UniqBillID.ToString() +"' ,'2','2','" + Order + "')";
                    SqlCeCommand InsertBillCommand = new SqlCeCommand(STR, MainConnection);
                    InsertBillCommand.ExecuteNonQuery();

                    // Syc Cust Bill
                    try
                    {
                        string[] d3 = { NewBillID.ToString(), cmboCustName.SelectedValue.ToString(), LogedIN.Current_USER.ToString(), InsertBillDate.ToString(), Paid.ToString(), "True", Delivered.ToString(), "False", txtNotes.Text, InsertBillDate.ToString(), UniqBillID.ToString(), "2", "2", Order.ToString() };
                        _s.Op(1, "Customers_Bills", d3);
                        STR = "update Customers_Bills set IS_ACKNOWLEDGE = 'True'  where ID = '" + NewBillID.ToString() + "'";
                        SqlCeCommand UpdateLastDetailCommand = new SqlCeCommand(STR, MainConnection);
                        UpdateLastDetailCommand.ExecuteNonQuery();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("No Connection you must resend Info later manually");
                    }

                    Guid LogInsertId = new Guid();
                    LogInsertId = Guid.NewGuid();
                    Guid LogRelatObID = new Guid();
                    LogRelatObID = Guid.NewGuid();
                   // insert Log
                    string Log = "INSERT INTO Action_Log ( ID, User_ID, Section_ID, IS_Mobile, Related_Object_ID, Operation, Entry_Date, IS_ACKNOWLEDGE)" +
                     " VALUES ( '" + LogInsertId + "','" + LogedIN.Current_USER.ToString() + "', '17bce737-fbf5-4153-8d50-264b57bab4bb' , 'True' , '" + NewBillID.ToString() + "' ,'Insert To Customers Bills','" + InsertBillDate + "','False' )";
                    SqlCeCommand LogCommand = new SqlCeCommand(Log, MainConnection);
                    LogCommand.ExecuteNonQuery();

                    // Syc Log
                        try
                        {
                            string[] dLog = { LogInsertId.ToString(), LogedIN.Current_USER.ToString(), "17bce737-fbf5-4153-8d50-264b57bab4bb", "True", LogRelatObID.ToString(), "Insert To Customers Bills", InsertBillDate.ToString(),"True" };
                            _s.Op(1, "Action_Log", dLog);
                            STR = "update Action_Log set IS_ACKNOWLEDGE = 'True'  where ID = '" + LogInsertId.ToString() + "'";
                            SqlCeCommand UpdateLastDetailCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateLastDetailCommand.ExecuteNonQuery();
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            MessageBox.Show("No Connection you must resend Log Info later manually");
                        }

                           // Insert Details
                    for (int i = 0; i < DTNewBillNewItem.Rows.Count; i++)
                    {
                        if (i == DTNewBillNewItem.Rows.Count - 1)
                        {
                            STR = "update Customers_Bills set Bill_Status = '1', IS_ACKNOWLEDGE = 'False'  where ID = '" + NewBillID.ToString() + "'";
                            SqlCeCommand UpdateLastDetailCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateLastDetailCommand.ExecuteNonQuery();
                        }
                        Guid DetID = Guid.NewGuid();
                        DetID = Guid.NewGuid();
                        //insert Log Of Details
                        STR = "Insert INTO Customers_Bills_Details ( ID ,Bill_ID , Item_ID , Quantity , Price , IS_ACKNOWLEDGE )" +
                            " VALUES ( '" + DetID.ToString() + "','" + NewBillID + "', '" + DTNewBillNewItem.Rows[i]["Item_ID"].ToString() + "','" + DTNewBillNewItem.Rows[i]["Quantity"].ToString() + "', '" + DTNewBillNewItem.Rows[i]["Price"].ToString() + "', 'False')";
                        SqlCeCommand InsertDetailCommand = new SqlCeCommand(STR, MainConnection);
                        InsertDetailCommand.ExecuteNonQuery();
                            // Syc Details
                        try
                        {
                            string[] d = { DetID.ToString(), NewBillID.ToString(), DTNewBillNewItem.Rows[i]["Item_ID"].ToString(), DTNewBillNewItem.Rows[i]["Quantity"].ToString(), DTNewBillNewItem.Rows[i]["Price"].ToString(), "True" };
                            _s.Op(1, "Customers_Bills_Details", d);
                            //update state of Details
                            STR = "update Customers_Bills_Details set IS_ACKNOWLEDGE = 'True'  where ID = '" + DetID.ToString() + "'";
                            SqlCeCommand UpdateLastDetailCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateLastDetailCommand.ExecuteNonQuery();
                            Guid IDtoPass = new Guid(DTNewBillNewItem.Rows[i]["Item_ID"].ToString());

                            string quant = SelectQuant(IDtoPass);
                            // update the quantity local
                            STR = "update Salesman_store set quantity = '" + (Convert.ToInt32(quant) - Convert.ToInt32(DTNewBillNewItem.Rows[i]["Quantity"].ToString())).ToString() + "' where Item_ID = '" + DTNewBillNewItem.Rows[i]["Item_ID"].ToString() + "'";
                            SqlCeCommand UpdateItemQuntCommand = new SqlCeCommand(STR, MainConnection);
                            UpdateItemQuntCommand.ExecuteNonQuery();

                            //string[] UpdatQu = { DTItemInCar.Rows[i]["ID"].ToString(), DTNewBillNewItem.Rows[i]["Item_ID"].ToString(), LogedIN.Current_USER.ToString(), DTItemInCar.Rows[, (Convert.ToInt32(quant) - Convert.ToInt32(DTNewBillNewItem.Rows[i]["Quantity"].ToString())).ToString(), DTNewBillNewItem.Rows[i]["Price"].ToString(), "True" };
                            //_s.Op(2, "Salesman_store", UpdatQu);
                       
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            MessageBox.Show("No Connection you must resend Details Info later manually");
                        }

                        Guid LogD_ID = new Guid();
                        LogD_ID = Guid.NewGuid();
                        Log = "INSERT INTO Action_Log ( ID, User_ID, Section_ID, IS_Mobile, Related_Object_ID, Operation, Entry_Date, IS_ACKNOWLEDGE)" +
                                  " VALUES ( '" + LogD_ID.ToString() + "','" + LogedIN.Current_USER.ToString() + "', '56d9f9be-32f8-454e-b83b-779907863d6c' , 'True' ,'" + DetID.ToString() + "','Insert To Customers Bills Details',getdate(),'False' )";
                        LogCommand = new SqlCeCommand(Log, MainConnection);
                        LogCommand.ExecuteNonQuery();

                        STR = "update Salesman_Store set Quantity = Quantity - '" + DTNewBillNewItem.Rows[i]["Quantity"] + "' where Item_ID =  '" + DTNewBillNewItem.Rows[i]["Item_ID"].ToString() + "'";
                        SqlCeCommand UpdateQuItemInCar = new SqlCeCommand(STR, MainConnection);
                        UpdateQuItemInCar.ExecuteNonQuery();

                    }
                    MessageBox.Show("Bill Saved");
                }
                else
                {
                    //IS Update 
                    if (BillStatus == "Changed")
                    {
                        string STR = "UPDATE Customers_Bills SET Bill_Date = '" + DTPBillDate.Text + "', IS_PAID = '" + Paid + "', IS_DELIVERED ='" + Delivered + "', IS_CANCELED ='" + CANCELED + "', Note ='" + txtNotes.Text + "', Bill_Status ='" + status + "',Bill_Type ='" + txtBillType.Text + "', IS_ORDER ='" + Order + "' where ID = '" + DT1.Rows[0]["Bill_ID"].ToString() + "'";
                        SqlCeCommand UpdateBillCommand = new SqlCeCommand(STR, MainConnection);
                        UpdateBillCommand.ExecuteNonQuery();

                        string Log = "INSERT INTO Action_Log ( ID, User_ID, Section_ID, IS_Mobile, Related_Object_ID, Operation, Entry_Date, IS_ACKNOWLEDGE)" +
               " VALUES ( NEWID(),'" + LogedIN.Current_USER.ToString() + "', '56d9f9be-32f8-454e-b83b-779907863d6c', 'True' ,'" + DT1.Rows[0]["Bill_ID"].ToString() + "','Update Customers Bills',getdate(),'False' )";
                        SqlCeCommand LogCommand = new SqlCeCommand(Log, MainConnection);
                        LogCommand.ExecuteNonQuery();

                    }

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void butSaveItem_Click(object sender, EventArgs e)
        {
            if (BillStatus == "New")
            {
                if (FirstItem)
                {
                    SelectST = "select ID AS ID, Bill_ID AS Bill_ID, Item_ID AS Item_ID , Quantity AS Quantity, Price AS Price,IS_ACKNOWLEDGE AS IS_ACKNOWLEDGE, '' AS Operation from Customers_Bills_Details where id=NewID()";
                    SelectQuery(SelectST);

                    if (ItemStatus == "InsertItem" & txtQuantity.Text != "")
                    {
                        DTNewBillNewItem.Rows.Add(DTNewBillNewItem.NewRow());

                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["ID"] = Guid.NewGuid();
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Bill_ID"] = NewBillID;
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Item_ID"] = cmboItem.SelectedValue.ToString();
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Quantity"] = txtQuantity.Text;
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Price"] = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["IS_ACKNOWLEDGE"] = "False";
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Operation"] = "Insert";
                        lblItemCount.Text = "Count:1";
                        FirstItem = false;
                        ItemStatus = "InsertItem";
                    }

                }
                else if (FirstItem == false)
                {
                    if (ItemStatus == "InsertItem" & txtQuantity.Text != "")
                    {
                        DTNewBillNewItem.Rows.Add(DTNewBillNewItem.NewRow());

                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["ID"] = new Guid();
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Bill_ID"] = NewBillID;
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Item_ID"] = cmboItem.SelectedValue.ToString();
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Quantity"] = txtQuantity.Text;
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Price"] = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["IS_ACKNOWLEDGE"] = "False";
                        DTNewBillNewItem.Rows[DTNewBillNewItem.Rows.Count - 1]["Operation"] = "Insert";
                        lblItemCount.Text = "Count:" + DTNewBillNewItem.Rows.Count.ToString();
                        // ItemStatus = "Saved";

                    }
                }
            }
            else
            {

                if (ItemStatus == "ChangedItem" & txtQuantity.Text != "")
                {

                    DT1.Rows[DetailIndex]["Price"] = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                    DT1.Rows[DetailIndex]["Quantity"] = txtQuantity.Text;
                    DT1.Rows[0]["Amount"] = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString());
                    DT1.Rows[DetailIndex]["ItemName"] = cmboItem.Text;
                    DT1.Rows[DetailIndex]["Item_ID"] = cmboItem.SelectedValue.ToString();
                    DT1.Rows[0]["Entry_Date"] = DateTime.Now.ToString();
                    DT1.Rows[DetailIndex]["AcDetail"] = "false";
                    DT1.Rows[DetailIndex]["IS_CANCELED"] = "false";
                    DT1.Rows[DetailIndex]["Operation"] = "Update";
                    ItemStatus = "Saved";
                    BillStatus = "Changed";
                }

                if (ItemStatus == "InsertItem" & txtQuantity.Text != "")
                {
                    DT1.Rows.Add(DT1.NewRow());
                    for (int i = 0; i == DT1.Columns.Count - 1; i++)
                    {
                        DT1.Rows[DT1.Rows.Count][i] = DT1.Rows[DT1.Rows.Count - 1][i];
                    }
                    DT1.Rows[DT1.Rows.Count - 1]["Price"] = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                    DT1.Rows[DT1.Rows.Count - 1]["Quantity"] = txtQuantity.Text;
                    DT1.Rows[DT1.Rows.Count - 1]["Amount"] = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString());
                    DT1.Rows[DT1.Rows.Count - 1]["ItemName"] = cmboItem.Text;
                    DT1.Rows[DT1.Rows.Count - 1]["Item_ID"] = cmboItem.SelectedValue.ToString();
                    DT1.Rows[DT1.Rows.Count - 1]["Entry_Date"] = DateTime.Now.ToString();
                    DT1.Rows[DT1.Rows.Count - 1]["Bill_Date"] = DateTime.Now.ToString();
                    DT1.Rows[DT1.Rows.Count - 1]["Detail_ID"] = new Guid();
                    DT1.Rows[DT1.Rows.Count - 1]["AcDetail"] = "false";
                    DT1.Rows[DT1.Rows.Count - 1]["IS_CANCELED"] = "false";
                    DT1.Rows[DT1.Rows.Count - 1]["Operation"] = "Insert";
                    lblItemCount.Text = "Count:" + DT1.Rows.Count.ToString();
                    ItemStatus = "Saved";
                    BillStatus = "Changed";
                }
            }
            butNewItem.Enabled = true;
            txtQuantity.Enabled = false;

            butSaveItem.Enabled = false;
        }



        private void butClose_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            DetailIndex = 0;
            txtNotes.Text = "";
            txtSearchName.Text = "";
            ButSearchBName_Click(ButSearchBName, e);
            DT1.Clone();
            DTNewBillNewItem.Clone();
            ComboCustDT.Clone();
            ComboItemsDT.Clone();
            pnlGrid.BringToFront();
        }

        private void btnInsertBill_Click(object sender, EventArgs e)
        {

            ItemStatus = "InsertItem";
            FirstItem = true;
            Detail = false;
            btnSaveBill.Tag = "New";

            cmboType = "Items";
            SelectST = "select * from Items where IS_AVAILABLE='true' and IS_DELETED='false'";
            SelectCombo(SelectST);
            cmboType = "Cust";
            SelectST = "select ID, Fullname, Can_Sale from Customers where IS_ACTIVE ='True' and IS_DELETED='False'";
            SelectCombo(SelectST);
            ItemInCar = true;
            SelectST = "Select  Items.Name, Items.Price ,SD.Quantity, Items.ID From Salesman_Store AS SD inner join Items on SD.Item_ID= Items.ID where Items.IS_AVAILABLE='True' AND Items.IS_DELETED='FALSE'";
            cmboType = "ItemsInCar";
            SelectCombo(SelectST);
            DTPBillDate.Value = new System.DateTime(int.Parse(System.DateTime.Today.Year.ToString()), int.Parse(System.DateTime.Today.Month.ToString()), int.Parse(System.DateTime.Today.Day.ToString()));

            cmboCustName.SelectedIndex = 0;
            cmboCustName.Visible = true;
            lblCustName.Visible = false;
            cmboItem.Visible = true;
            lblItemValue.Visible = false;

            lblPriceValue.Text = "---";
            checkAknowledgeD.Enabled = false;
            lblItemCount.Text = "Count:";
            txtBillType.Text = "";
            DTPBillDate.Text = "";
            lblAmount.Text = "";
            txtQuantity.Text = "";
            lblPriceValue.Text = "";
            txtNotes.Text = "";
            lblEnDate.Text = "";

            CheckCanceled.CheckState = CheckState.Unchecked;
            CheckCanceled.Enabled = false;

            CheckDelivered.CheckState = CheckState.Checked;

            CheckIsPaid.CheckState = CheckState.Checked;

            CheckIsOrder.CheckState = CheckState.Unchecked;

            CheckAcknowledge.CheckState = CheckState.Unchecked;
            CheckAcknowledge.Enabled = false;
            butEditDetails.BackColor = Color.AliceBlue;
            checkAknowledgeD.CheckState = CheckState.Unchecked;
            checkAknowledgeD.Enabled = false;
            BillStatus = "New";
            
            PnlDetails.Visible = false;
            lblAmount.Text = "";
            NewBillID = Guid.NewGuid();
            pnlNew.BringToFront();
            butSaveItem.Enabled = false;
            btnSaveBill.Enabled = false;
            string x = DateTime.Now.ToShortDateString();
        }

        private void frmBills_Load(object sender, EventArgs e)
        {
            Detail = false;
            SelectST = "select c.Fullname,* from Customers_Bills AS CBill inner join Customers c on c.ID = CBill.Customer_ID where User_ID='" + LogedIN.Current_USER.ToString() + "' AND c.IS_DELETED='False'  and cbill.is_canceled = 'false' order by Bill_Date desc";
            SelectQuery(SelectST);

            try
            {

                Guid __Bill_ID = new Guid(dgBills[0, 1].ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ther is no Bills Loud");
            }
            cmpoFindKind.SelectedIndex = 0;
            

            butSaveItem.Enabled = false;
        }

        private void butCloseBillFr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButSearchBName_Click(object sender, EventArgs e)
        {
            Detail = false;
            if (cmpoFindKind.Text == "Deleted Cust")
            {
                SelectST = "select c.Fullname,* from Customers_Bills AS CBill inner join Customers c on c.ID = CBill.Customer_ID where c.Fullname like '%" + txtSearchName.Text + "%' AND c.IS_DELETED='True'  and cbill.is_canceled = 'false' order by Bill_Date desc";
                SelectQuery(SelectST);
            }
            else if (cmpoFindKind.Text == "Canceled")
            {
                SelectST = "select c.Fullname,* from Customers_Bills AS CBill inner join Customers c on c.ID = CBill.Customer_ID where c.Fullname like '%" + txtSearchName.Text + "%' AND c.IS_DELETED='False'  and cbill.is_canceled = 'True' order by Bill_Date desc";
                SelectQuery(SelectST);
            }
            else if (cmpoFindKind.Text == "Search Name")
            {
                SelectST = "select c.Fullname,* from Customers_Bills AS CBill inner join Customers c on c.ID = CBill.Customer_ID where c.Fullname like '%" + txtSearchName.Text + "%' AND c.IS_DELETED='False'  and cbill.is_canceled = 'false' order by Bill_Date desc";
                SelectQuery(SelectST);
            }
            else if (cmpoFindKind.Text == "Can't Sale")
            {
                SelectST = "select c.Fullname,* from Customers_Bills AS CBill inner join Customers c on c.ID = CBill.Customer_ID where c.Fullname like '%" + txtSearchName.Text + "%' AND c.IS_DELETED='False'  and cbill.is_canceled = 'false' and c.can_sale = 'false' order by Bill_Date desc";
                SelectQuery(SelectST);
            }
            //Can't Sale
        }




        private void butEditDetails_Click(object sender, EventArgs e)
        {

            if (PnlDetails.Visible == true)
            {
                PnlDetails.Visible = true;
                PnlDetails.BringToFront();

                butSaveItem.Enabled = false;
                if (ItemStatus == "ChangedItem" || ItemStatus == "InsertItem")
                {
                    if (ItemStatus == "ChangedItem")
                    {
                        DialogResult MsgDialog = MessageBox.Show("You must save item befor", "Save remmainder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (MsgDialog == DialogResult.Yes)
                        {
                            butSaveItem_Click(butSaveItem, e);
                        }
                    }
                }
                DetailIndex = 0;
                PnlDetails.Visible = true;
            }
            else
            {
                if (DT1.Rows.Count > 0)
                {
                    lblItemCount.Text = "count: " + DT1.Rows.Count.ToString();
                    if (DT1.Rows[0]["IS_CANCELED"].ToString() == "True" || DT1.Rows[0]["Bill_Status"].ToString() == "1")
                    {
                        lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                        lblItemPrice.Text = (Convert.ToInt32(DT1.Rows[0]["Price"].ToString()) * Convert.ToInt32(DT1.Rows[0]["Quantity"].ToString())).ToString();
                        lblItemName.Text = this.DT1.Rows[0]["ItemName"].ToString();
                        lblItemCount.Text = "Count: " + DT1.Rows.Count.ToString();
                        lblItemName.Visible = true;
                  //      butNewItem_Click(butNewItem, e);
                        cmboItem.SelectedIndex = 0;
                        this.cmboItem.Enabled = false;
                        this.cmboItem.Visible = true;
                        butSaveItem.Enabled = false;
                        btnSaveBill.Enabled = false;

                        //      this.txtQuantity.Enabled = false;
                        //User Can't Update old Bills
                    }
                    else
                    {
                        CheckCanceled.Enabled = true; // only cancel
                        lblCustName.Visible = false;
                        txtQuantity.Enabled = true;
                        cmboItem.Visible = true;
                        cmboItem.Enabled = true;
                        butNewItem_Click(butNewItem, e);
                        butNewItem.Enabled = false;
                        butSaveItem.Enabled = false;
                    }
                  }
                else
                {
                    // btnSaveBill.Tag = "NewBill";
                    ItemStatus = "InsertItem";
                    //  lblItemPrice.Text = "Item Price:";
                    lblItemCount.Text = "Count:" + this.DTNewBillNewItem.Rows.Count.ToString();
                    //lblItemCount.Text = "Count: ";
                    lblCustName.Visible = false;
                    cmboItem.Visible = true;
                    cmboItem.Enabled = true;
                    PnlDetails.BringToFront();
                    butNewItem_Click(butNewItem, e);
                    butNewItem.Enabled = false;
                }

                PnlDetails.Visible = true;
                PnlDetails.BringToFront();

            }

            butSaveItem.Enabled = false;

        }



        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            // btnSaveBill.Tag = "Closed";

            if (BillStatus != "New")
                DT1.Rows[0]["Bill_Status"] = 1;
            InsertUpdatQu();
            btnSaveBill.Enabled = false;
            butSaveItem.Enabled = false;
        }


        private void butNext_Click(object sender, EventArgs e)
        {
            if (DetailIndex < DT1.Rows.Count - 1)
            {
                DetailIndex++;
                txtQuantity.Text = DT1.Rows[DetailIndex]["Quantity"].ToString();
                cmboItem.Text = DT1.Rows[DetailIndex]["ItemName"].ToString();
                lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                if (txtQuantity.Text != "")
                {
                    lblItemPrice.Text = (Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(lblPriceValue.Text)).ToString();
                }
                else
                    //  lblItemPrice.Text = "All Price: ";
                    if (DT1.Rows[DetailIndex]["AcDetail"].ToString() == "True")
                    {
                        checkAknowledgeD.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAknowledgeD.CheckState = CheckState.Unchecked;
                    }
                checkAknowledgeD.Enabled = false;
            }
            else
            {
                MessageBox.Show("Last Item");
            }

        }


        private void butBack_Click(object sender, EventArgs e)
        {
            if (DetailIndex > 0)
            {
                DetailIndex--;

                txtQuantity.Text = DT1.Rows[DetailIndex]["Quantity"].ToString();
                cmboItem.Text = DT1.Rows[DetailIndex]["ItemName"].ToString();
                lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                if (txtQuantity.Text != "")
                {
                    lblItemPrice.Text = (Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(lblPriceValue.Text)).ToString();
                }
                if (DT1.Rows[DetailIndex]["AcDetail"].ToString() == "True")
                {
                    checkAknowledgeD.CheckState = CheckState.Checked;
                }
                else
                {
                    checkAknowledgeD.CheckState = CheckState.Unchecked;
                }
                checkAknowledgeD.Enabled = false;
            }
            else
                MessageBox.Show("First Item");

        }

        private void CheckDelivered_CheckStateChanged(object sender, EventArgs e)
        {
            if (BillStatus != "New")
                BillStatus = "Changed";
            butSaveItem.Enabled = true;
            btnSaveBill.Enabled = true;
        }




        private void cmboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckIsOrder.CheckState == CheckState.Checked)
            {
                ItemInCar = false;

                if (lblPriceValue.Text != "" & ComberTxtChanges != "" & txtQuantity.Text != "")
                {
                    if (ItemStatus != "InsertItem")
                    {
                        ItemStatus = "ChangedItem";

                        lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                        if (txtQuantity.Text != "")
                        {
                            lblAmount.Text = (Convert.ToInt32(lblPriceValue.Text) * Convert.ToInt32(txtQuantity.Text)).ToString();
                            this.lblAmount.Text = "";
                            for (int i = 0; i < DT1.Rows.Count; i++)
                            {
                                lblAmount.Text = lblAmount.Text + Convert.ToInt32(DT1.Rows[i]["Amount"].ToString());
                            }
                            butEditDetails.BackColor = Color.Red;
                            butSaveItem.Enabled = true;
                            btnSaveBill.Enabled = true;
                        }
                    }
                    else
                    {
                        lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                    }
                }

            }
            if (ItemInCar == true)
            {
                bool checkIfInCar = false;
                for (int i = 0; i < DTItemInCar.Rows.Count; i++)
                {

                    if (cmboItem.SelectedValue.ToString() == DTItemInCar.Rows[i]["ID"].ToString())
                    {
                        checkIfInCar = true;
                        if (txtQuantity.Text != "")
                        {
                            if (Convert.ToInt16(txtQuantity.Text) > Convert.ToInt16(DTItemInCar.Rows[i]["Quantity"].ToString()))
                            {
                                MessageBox.Show("Availble Quantity IS Only " + DTItemInCar.Rows[i]["Quantity"].ToString() + " The selected quantidy IS " + DTItemInCar.Rows[i]["Quantity"].ToString());
                                txtQuantity.Text = DTItemInCar.Rows[i]["Quantity"].ToString();
                            }
                        }
                    }
                }
                if (checkIfInCar == false)
                {
                    MessageBox.Show("This Item is not in car ");
                    try
                    {
                        cmboItem.SelectedIndex = cmboItem.SelectedIndex + 1;
                    }
                    catch
                    {
                        ItemInCar = false;
                        cmboItem.SelectedIndex = 0;
                        ItemInCar = true;
                    }
                    return;
                }

                if (lblPriceValue.Text != "" & ComberTxtChanges != "" & txtQuantity.Text != "")
                {
                    if (ItemStatus != "InsertItem")
                    {
                        ItemStatus = "ChangedItem";

                        lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                        if (txtQuantity.Text != "")
                        {
                            lblAmount.Text = (Convert.ToInt32(lblPriceValue.Text) * Convert.ToInt32(txtQuantity.Text)).ToString();
                            this.lblAmount.Text = "";
                            for (int i = 0; i < DT1.Rows.Count; i++)
                            {
                                lblAmount.Text = lblAmount.Text + Convert.ToInt32(DT1.Rows[i]["Amount"].ToString());
                            }
                            butEditDetails.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
                    }
                }
            }
        }

        private void txtQuantity_GotFocus(object sender, EventArgs e)
        {
            ComberTxtChanges = txtQuantity.Text;
            butSaveItem.Enabled = true;
        }



        private void txtQuantity_LostFocus(object sender, EventArgs e)
        {
            bool checkIfInCar = false;
            int intQuantity;
            try
            {
                intQuantity = Convert.ToInt32(txtQuantity.Text);
            }
            catch
            {
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                return;
            }

            if (CheckIsOrder.CheckState == CheckState.Unchecked)
            {
                for (int i = 0; i < DTItemInCar.Rows.Count; i++)
                {
                    if (cmboItem.SelectedValue.ToString() == DTItemInCar.Rows[i]["ID"].ToString())
                    {
                        checkIfInCar = true;
                        if (Convert.ToInt16(txtQuantity.Text) > Convert.ToInt16(DTItemInCar.Rows[i]["Quantity"].ToString()))
                        {
                            MessageBox.Show("Availble Quantity IS Only " + DTItemInCar.Rows[i]["Quantity"].ToString() + " The selected quantidy IS " + txtQuantity.Text);
                            txtQuantity.Text = DTItemInCar.Rows[i]["Quantity"].ToString();
                            return;
                        }
                    }
                }

                if (checkIfInCar == false)
                    return;
            }
            if (ComberTxtChanges != txtQuantity.Text & ComberTxtChanges != "")
            {
                if (ItemStatus != "InsertItem")
                {
                    ItemStatus = "ChangedItem";
                    butEditDetails.BackColor = Color.Red;

                }
                if (BillStatus != "New")
                    BillStatus = "Changed";
            }
            lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
            if (txtQuantity.Text != "")
                lblItemPrice.Text = (Convert.ToInt32(lblPriceValue.Text) * Convert.ToInt32(txtQuantity.Text)).ToString();

        }

        private void txtNotes_GotFocus(object sender, EventArgs e)
        {
            ComberTxtChanges = txtNotes.Text;

        }




        private void dgBills_DoubleClick(object sender, EventArgs e)
        {
            Detail = true;
            FirstItem = false;
            SelectST = "select c.Fullname, CBillD.Quantity*CBillD.Price Amount, Items.Name ItemName, CBillD.ID Detail_ID, CBill.ID Bill_ID ,CBill.Bill_Date,CBill.IS_PAID, CBill.IS_Acknowledge, CBill.IS_DELIVERED, CBill.IS_CANCELED , CBill.Note, CBill.Entry_Date, CBill.Bill_Status, CBill.Bill_Type, CBill.IS_ORDER ,CBillD.Item_ID, CBillD.Quantity, CBillD.Price, CBillD.IS_Acknowledge AcDetail, '' AS Operation , c.can_sale from Customers_Bills CBill inner join Customers c on c.ID = CBill.Customer_ID left outer join Customers_Bills_Details CBillD on CBillD.Bill_ID = CBill.ID left outer join Items on Items.ID = CBill.ID where CBill.ID ='" + __Bill_ID.ToString() + "' and cbill.is_canceled = 'false'";
            SelectQuery(SelectST);


            try
            {
                if (addCmbStatus.Rows.Count == 0)
                {
                    addCmbStatus.Columns.Add("ID", typeof(int));
                    addCmbStatus.Columns.Add("Display", typeof(string));

                    object[] row = new object[2];

                    row[0] = 1;
                    row[1] = "Is Close";
                    addCmbStatus.Rows.Add(row);

                    row[0] = 2;
                    row[1] = "New Bill";
                    addCmbStatus.Rows.Add(row);

                    row[0] = 3;
                    row[1] = "Update Bill";
                    addCmbStatus.Rows.Add(row);

                    CmbBillStatus.DataSource = addCmbStatus;
                    CmbBillStatus.ValueMember = "ID";
                    CmbBillStatus.DisplayMember = "Display";


                    cmboType = "Cust";
                    SelectST = "select ID, Fullname, IS_ACTIVE from Customers where IS_ACTIVE ='True' and IS_DELETED='False'";
                    SelectCombo(SelectST);

                    cmboType = "Items";
                    SelectST = "select ID, Name, Price from Items where IS_AVAILABLE='true' and IS_DELETED='false'";
                    SelectCombo(SelectST);

                    ItemInCar = true;
                    SelectST = "Select  Items.Name, Items.Price ,SD.Quantity, Items.ID From Salesman_Store AS SD inner join Items on SD.Item_ID= Items.ID where Items.IS_AVAILABLE='True' AND Items.IS_DELETED='FALSE'";
                    cmboType = "ItemsInCar";
                    SelectCombo(SelectST);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                lblCustName.Visible = true;
                lblCustName.Text = DT1.Rows[0]["Fullname"].ToString();
                CmbBillStatus.SelectedValue = DT1.Rows[0]["Bill_Status"].ToString();
                txtBillType.Text = DT1.Rows[0]["Bill_Type"].ToString();
                DTPBillDate.Text = DT1.Rows[0]["Bill_Date"].ToString();
                Int32 TotalAmount = 0;
                //  string qTest;
                for (int i = 0; i < DT1.Rows.Count; i++)
                {
                    if (DT1.Rows[i]["Amount"] is DBNull)
                    { }
                    else
                    {
                        //  qTest = DT1.Rows[i]["Quantity"].ToString();
                        TotalAmount = TotalAmount + Convert.ToInt32(DT1.Rows[i]["Amount"].ToString());
                    }
                }
                lblAmount.Text = TotalAmount.ToString();
                txtNotes.Text = DT1.Rows[0]["Note"].ToString();
                lblEnDate.Text = DT1.Rows[0]["Entry_Date"].ToString();
                txtQuantity.Text = DT1.Rows[0]["Quantity"].ToString();
                cmboItem.Text = DT1.Rows[0]["ItemName"].ToString();
                lblItemName.Text = DT1.Rows[0]["ItemName"].ToString();
                lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();

                if (DT1.Rows[0]["AcDetail"].ToString() == "True")
                {
                    checkAknowledgeD.CheckState = CheckState.Checked;
                }
                else
                {
                    checkAknowledgeD.CheckState = CheckState.Unchecked;
                }
                CheckDelivered.Enabled = true;
                CheckIsPaid.Enabled = true;
                CheckIsOrder.Enabled = true;
                butEditDetails.Enabled = true;
                butSaveItem.Enabled = false;
                btnSaveBill.Enabled = false;
                CmbBillStatus.Enabled = false;
                txtNotes.Enabled = true;
                checkAknowledgeD.Enabled = false;
                CheckAcknowledge.Enabled = false;
                if (DT1.Rows[0]["IS_DELIVERED"].ToString() == "True")
                {
                    CheckDelivered.CheckState = CheckState.Checked;
                }
                else
                {
                    CheckDelivered.CheckState = CheckState.Unchecked;
                }

                if (DT1.Rows[0]["IS_PAID"].ToString() == "True")
                {
                    CheckIsPaid.CheckState = CheckState.Checked;
                }
                else
                {
                    CheckIsPaid.CheckState = CheckState.Unchecked;
                }

                if (DT1.Rows[0]["IS_ORDER"].ToString() == "True")
                {
                    CheckIsOrder.CheckState = CheckState.Checked;
                }
                else
                {
                    CheckIsOrder.CheckState = CheckState.Unchecked;
                }

                if (DT1.Rows[0]["IS_ACKNOWLEDGE"].ToString() == "True")
                {
                    CheckAcknowledge.CheckState = CheckState.Checked;
                }
                else
                {
                    CheckAcknowledge.CheckState = CheckState.Unchecked;
                }

                if (DT1.Rows[0]["IS_CANCELED"].ToString() == "True" || DT1.Rows[0]["Bill_Status"].ToString()== "1" || CmbBillStatus.SelectedText == "Update Bill")
                {
                    CheckCanceled.CheckState = CheckState.Checked;
                    CmbBillStatus.SelectedValue = "1";
                    lblCustName.Visible = true;
                    DTPBillDate.Enabled = false;
                    CheckDelivered.Enabled = false;
                    CheckCanceled.Enabled = false;
                    CheckIsPaid.Enabled = false;
                    CheckIsOrder.Enabled = false;
                    CmbBillStatus.Enabled = false;
                    txtNotes.Enabled = false;
                    CheckAcknowledge.Enabled = false;
                    checkAknowledgeD.Enabled = false;
                  //  butEditDetails.Enabled = false;
                    butSaveItem.Enabled = false;
                    btnSaveBill.Enabled = false;
                    txtBillType.Enabled = false;
                }
                else
                {
                    CheckCanceled.CheckState = CheckState.Unchecked;
                    CheckCanceled.Enabled = true;
                }
                if (DT1.Rows[0]["CAN_SALE"].ToString() == "False")
                {
                    btnSaveBill.Enabled = false;
                    txtQuantity.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            butSaveItem.Enabled = false;
            lblAmount.Visible = true;
            //butNewItem_Click(butNewItem, e);
            pnlNew.BringToFront();
            // PnlDetails.BringToFront();
        }

        private void dgBills_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                __Bill_ID = new Guid(dgBills[dgBills.HitTest(e.X, e.Y).Row, 1].ToString());

                _____CustId = new Guid(dgBills[dgBills.HitTest(e.X, e.Y).Row, 2].ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Double Click in Bill!");
            }
        }

        private void cmboCustName_LostFocus(object sender, EventArgs e)
        {

            if (ComboCustDT.Rows[cmboCustName.SelectedIndex]["Can_Sale"].ToString() == "False" || cmboCustName.Text == "")
            {
                MessageBox.Show("Wrong Name Or Can't Sale");
                try
                {
                    DialogResult MsgDialog = MessageBox.Show("Find Customer Bills?", "Do you want?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (MsgDialog == DialogResult.Yes)
                    {
                        butClose_Click(butClose, e);

                        txtSearchName.Text = cmboCustName.Text;
                        cmpoFindKind.Text = "Can't Sale";
                        //FirstItem = false;
                        ButSearchBName_Click(ButSearchBName, e);
                        return;
                        //  butSaveItem_Click(butSaveItem, e);
                    }
                    else
                    {
                        cmboCustName.SelectedIndex = cmboCustName.SelectedIndex + 1;
                    }
                }
                catch
                {
                    cmboCustName.SelectedIndex = 0;
                }
                cmboCustName_LostFocus(cmboCustName, e);
            }
        }
        private void butNewItem_Click(object sender, EventArgs e)
        {
            if (FirstItem)
            {
                lblItemValue.Visible = false;
                cmboItem.Enabled = true;
                cmboItem.Visible = true;
                txtQuantity.Enabled = true;
                txtQuantity.Text = "";
                ItemStatus = "InsertItem";
                butSaveItem.Enabled = true;
                txtQuantity.Enabled = true;
                //FirstItem = false;
            }
            else
            {
                if (BillStatus != "New")
                {
                    if (Convert.ToInt16(DT1.Rows[0]["Bill_Status"].ToString()) != 1 || DT1.Rows.Count != 1)
                    {
                        lblItemValue.Visible = false;
                        cmboItem.Enabled = true;
                        cmboItem.Visible = true;
                        txtQuantity.Text = "";
                        txtQuantity.Focus();
                        txtQuantity.Enabled = true;
                        ItemStatus = "InsertItem";
                        butSaveItem.Enabled = true;
                    }
                    else if (Convert.ToInt16(DT1.Rows[0]["Bill_Status"].ToString()) == 1)
                    {
                        MessageBox.Show("Invoice is Closed");
                        butNewItem.Enabled = false;
                        return;
                    }
                }
                else
                {
                    lblItemValue.Visible = false;
                    cmboItem.Enabled = true;
                    cmboItem.Visible = true;
                    txtQuantity.Text = "";
                    txtQuantity.Focus();
                    txtQuantity.Enabled = true;
                    ItemStatus = "InsertItem";
                    butSaveItem.Enabled = true;
                }
            }
            lblItemCount.Text = "Count:" + DTNewBillNewItem.Rows.Count.ToString();
        }


        private void txtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 222)
            {
                MessageBox.Show("You Can not writ char: ' ");
                txtQuantity.SelectAll();

            }
        }

        private void cmboItem_GotFocus(object sender, EventArgs e)
        {
            ComberTxtChanges = cmboItem.Text;
            ItemInCar = true;
        }

        private void cmboItem_LostFocus(object sender, EventArgs e)
        {
            if (cmboItem.Text != ComberTxtChanges)
            {
                if (BillStatus != "New")
                    BillStatus = "Changed";
                ItemStatus = "InsertItem";
                lblPriceValue.Text = ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"].ToString();
             //   lblPrice.Text = cmboItem.SelectedText.ToString();
                if (txtQuantity.Text != "")
                    lblItemPrice.Text = (Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(ComboItemsDT.Rows[cmboItem.SelectedIndex]["Price"])).ToString();
                ItemInCar = false;
            }
        }

        private void CheckIsOrder_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckIsOrder.CheckState != CheckState.Checked)
            {
                bool OrderItemInCar = false;
                for (int i = 0; i < DTNewBillNewItem.Rows.Count; i++)
                {
                    for (int j = 0; j < DTItemInCar.Rows.Count; j++)
                    {

                        if (DTNewBillNewItem.Rows[i]["Item_ID"].ToString() == DTItemInCar.Rows[j]["ID"].ToString())
                        {
                            OrderItemInCar = true;
                        }
                    }
                    if (OrderItemInCar == true)
                    {
                        MessageBox.Show("you can't uchack Order, some Items in Bill is not in Car");
                        CheckIsOrder.CheckState = CheckState.Checked;
                        return;
                    }
                }

            }
            if (BillStatus != "New")
                BillStatus = "Changed";
            butSaveItem.Enabled = true;
        }

        private void DTPBillDate_EnabledChanged(object sender, EventArgs e)
        {
            btnSaveBill.Enabled = true;
        }

        private void butSycItems_Click(object sender, EventArgs e)
        {
            SycItems();
        }
    }
}