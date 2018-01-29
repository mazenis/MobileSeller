namespace Mobile_July
{
    partial class frmCustomers
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
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.lblOperation = new System.Windows.Forms.Label();
            this.dgCustomer = new System.Windows.Forms.DataGrid();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.ButSearch = new System.Windows.Forms.Button();
            this.butSearchSClint = new System.Windows.Forms.Button();
            this.pnlNew = new System.Windows.Forms.Panel();
            this.MonthCal = new System.Windows.Forms.MonthCalendar();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckSendBalance = new System.Windows.Forms.CheckBox();
            this.CheckCanSale = new System.Windows.Forms.CheckBox();
            this.CheckDeleted = new System.Windows.Forms.CheckBox();
            this.CheckActive = new System.Windows.Forms.CheckBox();
            this.butClose = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.TitCombox = new System.Windows.Forms.ComboBox();
            this.txtPhon = new System.Windows.Forms.TextBox();
            this.TxtAdrss = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGrid.SuspendLayout();
            this.pnlNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnInsertCustomer.Location = new System.Drawing.Point(54, 3);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(127, 20);
            this.btnInsertCustomer.TabIndex = 0;
            this.btnInsertCustomer.Text = "New Suggested Client";
            this.btnInsertCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.Location = new System.Drawing.Point(150, 3);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(87, 20);
            this.lblOperation.Text = "Customers";
            // 
            // dgCustomer
            // 
            this.dgCustomer.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgCustomer.Location = new System.Drawing.Point(3, 26);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.Size = new System.Drawing.Size(233, 195);
            this.dgCustomer.TabIndex = 2;
            this.dgCustomer.DoubleClick += new System.EventHandler(this.dgCustomer_DoubleClick);
            this.dgCustomer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgCustomer_MouseUp);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.label6);
            this.pnlGrid.Controls.Add(this.txtSearchName);
            this.pnlGrid.Controls.Add(this.ButSearch);
            this.pnlGrid.Controls.Add(this.dgCustomer);
            this.pnlGrid.Controls.Add(this.butSearchSClint);
            this.pnlGrid.Controls.Add(this.btnInsertCustomer);
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(240, 268);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.Text = "Seach:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(25, 246);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(192, 21);
            this.txtSearchName.TabIndex = 4;
            // 
            // ButSearch
            // 
            this.ButSearch.Location = new System.Drawing.Point(55, 224);
            this.ButSearch.Name = "ButSearch";
            this.ButSearch.Size = new System.Drawing.Size(67, 20);
            this.ButSearch.TabIndex = 3;
            this.ButSearch.Text = "Clients";
            this.ButSearch.Click += new System.EventHandler(this.ButSearch_Click);
            // 
            // butSearchSClint
            // 
            this.butSearchSClint.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.butSearchSClint.Location = new System.Drawing.Point(128, 224);
            this.butSearchSClint.Name = "butSearchSClint";
            this.butSearchSClint.Size = new System.Drawing.Size(109, 20);
            this.butSearchSClint.TabIndex = 0;
            this.butSearchSClint.Text = "Suggested Clients";
            this.butSearchSClint.Click += new System.EventHandler(this.butSearchSClint_Click);
            // 
            // pnlNew
            // 
            this.pnlNew.Controls.Add(this.MonthCal);
            this.pnlNew.Controls.Add(this.txtMob);
            this.pnlNew.Controls.Add(this.label1);
            this.pnlNew.Controls.Add(this.CheckSendBalance);
            this.pnlNew.Controls.Add(this.CheckCanSale);
            this.pnlNew.Controls.Add(this.CheckDeleted);
            this.pnlNew.Controls.Add(this.CheckActive);
            this.pnlNew.Controls.Add(this.butClose);
            this.pnlNew.Controls.Add(this.btnSaveCustomer);
            this.pnlNew.Controls.Add(this.TitCombox);
            this.pnlNew.Controls.Add(this.txtPhon);
            this.pnlNew.Controls.Add(this.TxtAdrss);
            this.pnlNew.Controls.Add(this.txtCustName);
            this.pnlNew.Controls.Add(this.lblOperation);
            this.pnlNew.Controls.Add(this.label5);
            this.pnlNew.Controls.Add(this.label4);
            this.pnlNew.Controls.Add(this.label3);
            this.pnlNew.Controls.Add(this.label2);
            this.pnlNew.Location = new System.Drawing.Point(0, 0);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(240, 265);
            // 
            // MonthCal
            // 
            this.MonthCal.Location = new System.Drawing.Point(3, 118);
            this.MonthCal.Name = "MonthCal";
            this.MonthCal.Size = new System.Drawing.Size(163, 149);
            this.MonthCal.TabIndex = 8;
            // 
            // txtMob
            // 
            this.txtMob.Location = new System.Drawing.Point(47, 74);
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(98, 21);
            this.txtMob.TabIndex = 4;
            this.txtMob.LostFocus += new System.EventHandler(this.txtMob_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.Text = "Mobile";
            // 
            // CheckSendBalance
            // 
            this.CheckSendBalance.Checked = true;
            this.CheckSendBalance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSendBalance.Location = new System.Drawing.Point(17, 99);
            this.CheckSendBalance.Name = "CheckSendBalance";
            this.CheckSendBalance.Size = new System.Drawing.Size(104, 20);
            this.CheckSendBalance.TabIndex = 7;
            this.CheckSendBalance.Text = "Send Balance";
            // 
            // CheckCanSale
            // 
            this.CheckCanSale.Checked = true;
            this.CheckCanSale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCanSale.Location = new System.Drawing.Point(160, 98);
            this.CheckCanSale.Name = "CheckCanSale";
            this.CheckCanSale.Size = new System.Drawing.Size(81, 20);
            this.CheckCanSale.TabIndex = 13;
            this.CheckCanSale.Text = "Can Sale";
            // 
            // CheckDeleted
            // 
            this.CheckDeleted.Enabled = false;
            this.CheckDeleted.Location = new System.Drawing.Point(160, 79);
            this.CheckDeleted.Name = "CheckDeleted";
            this.CheckDeleted.Size = new System.Drawing.Size(73, 20);
            this.CheckDeleted.TabIndex = 12;
            this.CheckDeleted.Text = "Deleted";
            // 
            // CheckActive
            // 
            this.CheckActive.Checked = true;
            this.CheckActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckActive.Location = new System.Drawing.Point(161, 60);
            this.CheckActive.Name = "CheckActive";
            this.CheckActive.Size = new System.Drawing.Size(71, 20);
            this.CheckActive.TabIndex = 6;
            this.CheckActive.Text = "Active";
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(172, 233);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(63, 20);
            this.butClose.TabIndex = 10;
            this.butClose.Text = "Close";
            this.butClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(172, 207);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(63, 20);
            this.btnSaveCustomer.TabIndex = 9;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // TitCombox
            // 
            this.TitCombox.Items.Add("Mr");
            this.TitCombox.Items.Add("Mrs");
            this.TitCombox.Location = new System.Drawing.Point(181, 32);
            this.TitCombox.Name = "TitCombox";
            this.TitCombox.Size = new System.Drawing.Size(56, 22);
            this.TitCombox.TabIndex = 5;
            // 
            // txtPhon
            // 
            this.txtPhon.Location = new System.Drawing.Point(48, 51);
            this.txtPhon.Name = "txtPhon";
            this.txtPhon.Size = new System.Drawing.Size(96, 21);
            this.txtPhon.TabIndex = 3;
            this.txtPhon.LostFocus += new System.EventHandler(this.txtPhon_LostFocus);
            // 
            // TxtAdrss
            // 
            this.TxtAdrss.Location = new System.Drawing.Point(48, 28);
            this.TxtAdrss.Name = "TxtAdrss";
            this.TxtAdrss.Size = new System.Drawing.Size(96, 21);
            this.TxtAdrss.TabIndex = 1;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(48, 4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(96, 21);
            this.txtCustName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(150, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 22);
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.Text = "address";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.Text = "Name";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlNew);
            this.Menu = this.mainMenu1;
            this.Name = "frmCustomers";
            this.Text = "Customers Manager";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.pnlGrid.ResumeLayout(false);
            this.pnlNew.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.DataGrid dgCustomer;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TitCombox;
        private System.Windows.Forms.TextBox txtPhon;
        private System.Windows.Forms.TextBox TxtAdrss;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.CheckBox CheckDeleted;
        private System.Windows.Forms.CheckBox CheckActive;
        private System.Windows.Forms.CheckBox CheckCanSale;
        private System.Windows.Forms.CheckBox CheckSendBalance;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar MonthCal;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button ButSearch;
        private System.Windows.Forms.Button butSearchSClint;
        private System.Windows.Forms.Label label6;
    }
}