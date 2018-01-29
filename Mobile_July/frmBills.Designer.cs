namespace Mobile_July
{
    partial class frmBills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.CheckIsPaid = new System.Windows.Forms.CheckBox();
            this.CheckAcknowledge = new System.Windows.Forms.CheckBox();
            this.CheckCanceled = new System.Windows.Forms.CheckBox();
            this.CheckDelivered = new System.Windows.Forms.CheckBox();
            this.butClose = new System.Windows.Forms.Button();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.txtBillType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBillStatus = new System.Windows.Forms.Label();
            this.dgBills = new System.Windows.Forms.DataGrid();
            this.lblCustN = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.butSycItems = new System.Windows.Forms.Button();
            this.cmpoFindKind = new System.Windows.Forms.ComboBox();
            this.butCloseBillFr = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.ButSearchBName = new System.Windows.Forms.Button();
            this.btnInsertBill = new System.Windows.Forms.Button();
            this.pnlNew = new System.Windows.Forms.Panel();
            this.butSaveItem = new System.Windows.Forms.Button();
            this.CmbBillStatus = new System.Windows.Forms.ComboBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.cmboCustName = new System.Windows.Forms.ComboBox();
            this.PnlDetails = new System.Windows.Forms.Panel();
            this.lblPrice0 = new System.Windows.Forms.Label();
            this.butNewItem = new System.Windows.Forms.Button();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.checkAknowledgeD = new System.Windows.Forms.CheckBox();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmboItem = new System.Windows.Forms.ComboBox();
            this.lblItemValue = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblEnDate = new System.Windows.Forms.Label();
            this.lblAmount0 = new System.Windows.Forms.Label();
            this.DTPBillDate = new System.Windows.Forms.DateTimePicker();
            this.butEditDetails = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.CheckIsOrder = new System.Windows.Forms.CheckBox();
            this.pnlGrid.SuspendLayout();
            this.pnlNew.SuspendLayout();
            this.PnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(8, 176);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(147, 76);
            this.txtNotes.TabIndex = 7;
            this.txtNotes.GotFocus += new System.EventHandler(this.txtNotes_GotFocus);
            this.txtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            this.txtNotes.LostFocus += new System.EventHandler(this.CheckDelivered_CheckStateChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(55, 162);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(42, 20);
            this.lblNotes.Text = "Notes";
            // 
            // CheckIsPaid
            // 
            this.CheckIsPaid.Location = new System.Drawing.Point(162, 50);
            this.CheckIsPaid.Name = "CheckIsPaid";
            this.CheckIsPaid.Size = new System.Drawing.Size(71, 20);
            this.CheckIsPaid.TabIndex = 3;
            this.CheckIsPaid.Text = "Paid";
            this.CheckIsPaid.CheckStateChanged += new System.EventHandler(this.CheckDelivered_CheckStateChanged);
            // 
            // CheckAcknowledge
            // 
            this.CheckAcknowledge.Location = new System.Drawing.Point(7, 104);
            this.CheckAcknowledge.Name = "CheckAcknowledge";
            this.CheckAcknowledge.Size = new System.Drawing.Size(101, 19);
            this.CheckAcknowledge.TabIndex = 4;
            this.CheckAcknowledge.Text = "Acknowledge";
            // 
            // CheckCanceled
            // 
            this.CheckCanceled.Location = new System.Drawing.Point(161, 27);
            this.CheckCanceled.Name = "CheckCanceled";
            this.CheckCanceled.Size = new System.Drawing.Size(73, 20);
            this.CheckCanceled.TabIndex = 12;
            this.CheckCanceled.Text = "Canceled";
            this.CheckCanceled.CheckStateChanged += new System.EventHandler(this.CheckDelivered_CheckStateChanged);
            // 
            // CheckDelivered
            // 
            this.CheckDelivered.Location = new System.Drawing.Point(161, 3);
            this.CheckDelivered.Name = "CheckDelivered";
            this.CheckDelivered.Size = new System.Drawing.Size(80, 20);
            this.CheckDelivered.TabIndex = 2;
            this.CheckDelivered.Text = "Delivered";
            this.CheckDelivered.CheckStateChanged += new System.EventHandler(this.CheckDelivered_CheckStateChanged);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(169, 233);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(63, 20);
            this.butClose.TabIndex = 10;
            this.butClose.Text = "Close";
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Location = new System.Drawing.Point(167, 207);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(65, 20);
            this.btnSaveBill.TabIndex = 9;
            this.btnSaveBill.Text = "Save";
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // txtBillType
            // 
            this.txtBillType.Enabled = false;
            this.txtBillType.Location = new System.Drawing.Point(64, 51);
            this.txtBillType.Name = "txtBillType";
            this.txtBillType.Size = new System.Drawing.Size(96, 21);
            this.txtBillType.TabIndex = 1;
            this.txtBillType.Text = "8";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.Text = "Bill Type";
            // 
            // lblBillStatus
            // 
            this.lblBillStatus.Location = new System.Drawing.Point(3, 29);
            this.lblBillStatus.Name = "lblBillStatus";
            this.lblBillStatus.Size = new System.Drawing.Size(63, 20);
            this.lblBillStatus.Text = "Bill Status";
            // 
            // dgBills
            // 
            this.dgBills.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgBills.Location = new System.Drawing.Point(4, 52);
            this.dgBills.Name = "dgBills";
            this.dgBills.Size = new System.Drawing.Size(230, 206);
            this.dgBills.TabIndex = 2;
            this.dgBills.DoubleClick += new System.EventHandler(this.dgBills_DoubleClick);
            this.dgBills.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgBills_MouseUp);
            // 
            // lblCustN
            // 
            this.lblCustN.Location = new System.Drawing.Point(0, 5);
            this.lblCustN.Name = "lblCustN";
            this.lblCustN.Size = new System.Drawing.Size(66, 20);
            this.lblCustN.Text = "Cust Name";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.butSycItems);
            this.pnlGrid.Controls.Add(this.cmpoFindKind);
            this.pnlGrid.Controls.Add(this.butCloseBillFr);
            this.pnlGrid.Controls.Add(this.txtSearchName);
            this.pnlGrid.Controls.Add(this.ButSearchBName);
            this.pnlGrid.Controls.Add(this.dgBills);
            this.pnlGrid.Controls.Add(this.btnInsertBill);
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(240, 265);
            // 
            // butSycItems
            // 
            this.butSycItems.Location = new System.Drawing.Point(78, 4);
            this.butSycItems.Name = "butSycItems";
            this.butSycItems.Size = new System.Drawing.Size(72, 20);
            this.butSycItems.TabIndex = 10;
            this.butSycItems.Text = "Syc Items";
            this.butSycItems.Click += new System.EventHandler(this.butSycItems_Click);
            // 
            // cmpoFindKind
            // 
            this.cmpoFindKind.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cmpoFindKind.Items.Add("Search Name");
            this.cmpoFindKind.Items.Add("Deleted Cust");
            this.cmpoFindKind.Items.Add("Can\'t Sale");
            this.cmpoFindKind.Items.Add("Canceled");
            this.cmpoFindKind.Location = new System.Drawing.Point(3, 29);
            this.cmpoFindKind.Name = "cmpoFindKind";
            this.cmpoFindKind.Size = new System.Drawing.Size(93, 20);
            this.cmpoFindKind.TabIndex = 9;
            // 
            // butCloseBillFr
            // 
            this.butCloseBillFr.Location = new System.Drawing.Point(185, 4);
            this.butCloseBillFr.Name = "butCloseBillFr";
            this.butCloseBillFr.Size = new System.Drawing.Size(51, 20);
            this.butCloseBillFr.TabIndex = 8;
            this.butCloseBillFr.Text = "Close";
            this.butCloseBillFr.Click += new System.EventHandler(this.butCloseBillFr_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtSearchName.Location = new System.Drawing.Point(133, 28);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(101, 19);
            this.txtSearchName.TabIndex = 6;
            // 
            // ButSearchBName
            // 
            this.ButSearchBName.Location = new System.Drawing.Point(98, 26);
            this.ButSearchBName.Name = "ButSearchBName";
            this.ButSearchBName.Size = new System.Drawing.Size(33, 23);
            this.ButSearchBName.TabIndex = 5;
            this.ButSearchBName.Text = "Find";
            this.ButSearchBName.Click += new System.EventHandler(this.ButSearchBName_Click);
            // 
            // btnInsertBill
            // 
            this.btnInsertBill.Location = new System.Drawing.Point(3, 4);
            this.btnInsertBill.Name = "btnInsertBill";
            this.btnInsertBill.Size = new System.Drawing.Size(69, 20);
            this.btnInsertBill.TabIndex = 0;
            this.btnInsertBill.Text = "New Bill";
            this.btnInsertBill.Click += new System.EventHandler(this.btnInsertBill_Click);
            // 
            // pnlNew
            // 
            this.pnlNew.Controls.Add(this.butSaveItem);
            this.pnlNew.Controls.Add(this.CmbBillStatus);
            this.pnlNew.Controls.Add(this.lblCustName);
            this.pnlNew.Controls.Add(this.lblAmount);
            this.pnlNew.Controls.Add(this.lblEntryDate);
            this.pnlNew.Controls.Add(this.cmboCustName);
            this.pnlNew.Controls.Add(this.PnlDetails);
            this.pnlNew.Controls.Add(this.lblEnDate);
            this.pnlNew.Controls.Add(this.lblAmount0);
            this.pnlNew.Controls.Add(this.DTPBillDate);
            this.pnlNew.Controls.Add(this.butEditDetails);
            this.pnlNew.Controls.Add(this.txtNotes);
            this.pnlNew.Controls.Add(this.lblNotes);
            this.pnlNew.Controls.Add(this.lblDate);
            this.pnlNew.Controls.Add(this.CheckIsPaid);
            this.pnlNew.Controls.Add(this.CheckAcknowledge);
            this.pnlNew.Controls.Add(this.CheckCanceled);
            this.pnlNew.Controls.Add(this.CheckDelivered);
            this.pnlNew.Controls.Add(this.CheckIsOrder);
            this.pnlNew.Controls.Add(this.butClose);
            this.pnlNew.Controls.Add(this.btnSaveBill);
            this.pnlNew.Controls.Add(this.txtBillType);
            this.pnlNew.Controls.Add(this.label4);
            this.pnlNew.Controls.Add(this.lblBillStatus);
            this.pnlNew.Controls.Add(this.lblCustN);
            this.pnlNew.Location = new System.Drawing.Point(0, 0);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(240, 265);
            // 
            // butSaveItem
            // 
            this.butSaveItem.Location = new System.Drawing.Point(163, 182);
            this.butSaveItem.Name = "butSaveItem";
            this.butSaveItem.Size = new System.Drawing.Size(72, 20);
            this.butSaveItem.TabIndex = 30;
            this.butSaveItem.Text = "Save Item";
            this.butSaveItem.Click += new System.EventHandler(this.butSaveItem_Click);
            // 
            // CmbBillStatus
            // 
            this.CmbBillStatus.Enabled = false;
            this.CmbBillStatus.Location = new System.Drawing.Point(64, 27);
            this.CmbBillStatus.Name = "CmbBillStatus";
            this.CmbBillStatus.Size = new System.Drawing.Size(96, 22);
            this.CmbBillStatus.TabIndex = 29;
            // 
            // lblCustName
            // 
            this.lblCustName.Location = new System.Drawing.Point(65, 4);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(89, 20);
            this.lblCustName.Text = "---";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(185, 103);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 20);
            this.lblAmount.Text = "---";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.Location = new System.Drawing.Point(68, 76);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(91, 16);
            this.lblEntryDate.Text = "---";
            this.lblEntryDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmboCustName
            // 
            this.cmboCustName.Location = new System.Drawing.Point(64, 3);
            this.cmboCustName.Name = "cmboCustName";
            this.cmboCustName.Size = new System.Drawing.Size(94, 22);
            this.cmboCustName.TabIndex = 19;
            this.cmboCustName.Visible = false;
            this.cmboCustName.LostFocus += new System.EventHandler(this.cmboCustName_LostFocus);
            // 
            // PnlDetails
            // 
            this.PnlDetails.Controls.Add(this.lblPrice0);
            this.PnlDetails.Controls.Add(this.butNewItem);
            this.PnlDetails.Controls.Add(this.lblItemPrice);
            this.PnlDetails.Controls.Add(this.butBack);
            this.PnlDetails.Controls.Add(this.butNext);
            this.PnlDetails.Controls.Add(this.lblItemCount);
            this.PnlDetails.Controls.Add(this.checkAknowledgeD);
            this.PnlDetails.Controls.Add(this.lblPriceValue);
            this.PnlDetails.Controls.Add(this.lblPrice);
            this.PnlDetails.Controls.Add(this.txtQuantity);
            this.PnlDetails.Controls.Add(this.lblQuantity);
            this.PnlDetails.Controls.Add(this.cmboItem);
            this.PnlDetails.Controls.Add(this.lblItemValue);
            this.PnlDetails.Controls.Add(this.lblItemName);
            this.PnlDetails.Location = new System.Drawing.Point(6, 148);
            this.PnlDetails.Name = "PnlDetails";
            this.PnlDetails.Size = new System.Drawing.Size(155, 110);
            this.PnlDetails.Visible = false;
            // 
            // lblPrice0
            // 
            this.lblPrice0.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblPrice0.Location = new System.Drawing.Point(4, 59);
            this.lblPrice0.Name = "lblPrice0";
            this.lblPrice0.Size = new System.Drawing.Size(62, 20);
            this.lblPrice0.Text = "Item Price:";
            // 
            // butNewItem
            // 
            this.butNewItem.Location = new System.Drawing.Point(115, 6);
            this.butNewItem.Name = "butNewItem";
            this.butNewItem.Size = new System.Drawing.Size(36, 20);
            this.butNewItem.TabIndex = 19;
            this.butNewItem.Text = "New";
            this.butNewItem.Click += new System.EventHandler(this.butNewItem_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblItemPrice.Location = new System.Drawing.Point(62, 60);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(41, 20);
            this.lblItemPrice.Text = "---";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(77, 83);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(35, 20);
            this.butBack.TabIndex = 12;
            this.butBack.Text = "Back";
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(115, 83);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(35, 20);
            this.butNext.TabIndex = 12;
            this.butNext.Text = "Next";
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // lblItemCount
            // 
            this.lblItemCount.Location = new System.Drawing.Point(2, 83);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(68, 20);
            this.lblItemCount.Text = "Count:";
            // 
            // checkAknowledgeD
            // 
            this.checkAknowledgeD.Location = new System.Drawing.Point(104, 60);
            this.checkAknowledgeD.Name = "checkAknowledgeD";
            this.checkAknowledgeD.Size = new System.Drawing.Size(48, 20);
            this.checkAknowledgeD.TabIndex = 6;
            this.checkAknowledgeD.Text = "Ack";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Location = new System.Drawing.Point(113, 33);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(38, 20);
            this.lblPriceValue.Text = "---";
            this.lblPriceValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(81, 34);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 20);
            this.lblPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(41, 34);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(39, 21);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.GotFocus += new System.EventHandler(this.txtQuantity_GotFocus);
            this.txtQuantity.LostFocus += new System.EventHandler(this.txtQuantity_LostFocus);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(1, 35);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(45, 20);
            this.lblQuantity.Text = "Quant";
            // 
            // cmboItem
            // 
            this.cmboItem.Location = new System.Drawing.Point(41, 5);
            this.cmboItem.Name = "cmboItem";
            this.cmboItem.Size = new System.Drawing.Size(71, 22);
            this.cmboItem.TabIndex = 1;
            this.cmboItem.LostFocus += new System.EventHandler(this.cmboItem_LostFocus);
            this.cmboItem.SelectedIndexChanged += new System.EventHandler(this.cmboItem_SelectedIndexChanged);
            this.cmboItem.GotFocus += new System.EventHandler(this.cmboItem_GotFocus);
            // 
            // lblItemValue
            // 
            this.lblItemValue.Location = new System.Drawing.Point(41, 6);
            this.lblItemValue.Name = "lblItemValue";
            this.lblItemValue.Size = new System.Drawing.Size(71, 20);
            this.lblItemValue.Text = "---";
            this.lblItemValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblItemValue.Visible = false;
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(6, 8);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(31, 20);
            this.lblItemName.Text = "Item";
            // 
            // lblEnDate
            // 
            this.lblEnDate.Location = new System.Drawing.Point(2, 76);
            this.lblEnDate.Name = "lblEnDate";
            this.lblEnDate.Size = new System.Drawing.Size(64, 17);
            this.lblEnDate.Text = "Entry Date";
            // 
            // lblAmount0
            // 
            this.lblAmount0.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblAmount0.Location = new System.Drawing.Point(110, 104);
            this.lblAmount0.Name = "lblAmount0";
            this.lblAmount0.Size = new System.Drawing.Size(82, 20);
            this.lblAmount0.Text = "Total Amount";
            // 
            // DTPBillDate
            // 
            this.DTPBillDate.CustomFormat = "";
            this.DTPBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBillDate.Location = new System.Drawing.Point(61, 124);
            this.DTPBillDate.Name = "DTPBillDate";
            this.DTPBillDate.Size = new System.Drawing.Size(131, 22);
            this.DTPBillDate.TabIndex = 6;
            this.DTPBillDate.Value = new System.DateTime(int.Parse(System.DateTime.Today.Year.ToString()),int.Parse(System.DateTime.Today.Month.ToString()),int.Parse(System.DateTime.Today.Day.ToString()));
            this.DTPBillDate.EnabledChanged += new System.EventHandler(this.DTPBillDate_EnabledChanged);
            // 
            // butEditDetails
            // 
            this.butEditDetails.Location = new System.Drawing.Point(159, 156);
            this.butEditDetails.Name = "butEditDetails";
            this.butEditDetails.Size = new System.Drawing.Size(79, 20);
            this.butEditDetails.TabIndex = 8;
            this.butEditDetails.Text = "Edit Details";
            this.butEditDetails.Click += new System.EventHandler(this.butEditDetails_Click);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(4, 126);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 20);
            this.lblDate.Text = "Bill Date";
            // 
            // CheckIsOrder
            // 
            this.CheckIsOrder.Location = new System.Drawing.Point(162, 74);
            this.CheckIsOrder.Name = "CheckIsOrder";
            this.CheckIsOrder.Size = new System.Drawing.Size(70, 20);
            this.CheckIsOrder.TabIndex = 5;
            this.CheckIsOrder.Text = "Order";
            this.CheckIsOrder.CheckStateChanged += new System.EventHandler(this.CheckIsOrder_CheckStateChanged);
            // 
            // frmBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlNew);
            this.Menu = this.mainMenu1;
            this.Name = "frmBills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.frmBills_Load);
            this.pnlGrid.ResumeLayout(false);
            this.pnlNew.ResumeLayout(false);
            this.PnlDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.CheckBox CheckIsPaid;
        private System.Windows.Forms.CheckBox CheckAcknowledge;
        private System.Windows.Forms.CheckBox CheckCanceled;
        private System.Windows.Forms.CheckBox CheckDelivered;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.TextBox txtBillType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBillStatus;
        private System.Windows.Forms.DataGrid dgBills;
        private System.Windows.Forms.Label lblCustN;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnInsertBill;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.CheckBox CheckIsOrder;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblEnDate;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button ButSearchBName;
        private System.Windows.Forms.Button butEditDetails;
        private System.Windows.Forms.Panel PnlDetails;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cmboItem;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.CheckBox checkAknowledgeD;
        private System.Windows.Forms.DateTimePicker DTPBillDate;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAmount0;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmboCustName;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemValue;
        private System.Windows.Forms.Button butNewItem;
        private System.Windows.Forms.Button butCloseBillFr;
        private System.Windows.Forms.ComboBox CmbBillStatus;
        private System.Windows.Forms.Button butSaveItem;
        private System.Windows.Forms.ComboBox cmpoFindKind;
        private System.Windows.Forms.Label lblPrice0;
        private System.Windows.Forms.Button butSycItems;
    }
}