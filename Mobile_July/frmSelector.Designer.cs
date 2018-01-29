namespace Mobile_July
{
    partial class frmSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButSync = new System.Windows.Forms.Button();
            this.RBItems = new System.Windows.Forms.RadioButton();
            this.ButCloseApp = new System.Windows.Forms.Button();
            this.RBBills = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.RBStores = new System.Windows.Forms.RadioButton();
            this.RBCusts = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.InsertUserpanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.TitCombox = new System.Windows.Forms.ComboBox();
            this.txtPhon = new System.Windows.Forms.TextBox();
            this.TxtAdrss = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.LogPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InsertUserpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.Text = "---";
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(this.label5);
            this.LogPanel.Controls.Add(this.button1);
            this.LogPanel.Controls.Add(this.txtPass);
            this.LogPanel.Controls.Add(this.textBox1);
            this.LogPanel.Controls.Add(this.label3);
            this.LogPanel.Controls.Add(this.label2);
            this.LogPanel.Location = new System.Drawing.Point(0, 0);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(240, 264);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 20);
            this.label5.Text = "Enter User Name And Password to Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "login";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 125);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(228, 21);
            this.txtPass.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "username";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButSync);
            this.panel2.Controls.Add(this.RBItems);
            this.panel2.Controls.Add(this.ButCloseApp);
            this.panel2.Controls.Add(this.RBBills);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.RBStores);
            this.panel2.Controls.Add(this.RBCusts);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 264);
            // 
            // ButSync
            // 
            this.ButSync.Location = new System.Drawing.Point(129, 140);
            this.ButSync.Name = "ButSync";
            this.ButSync.Size = new System.Drawing.Size(72, 20);
            this.ButSync.TabIndex = 10;
            this.ButSync.Text = "Sync";
            this.ButSync.Click += new System.EventHandler(this.ButSync_Click);
            // 
            // RBItems
            // 
            this.RBItems.Location = new System.Drawing.Point(12, 114);
            this.RBItems.Name = "RBItems";
            this.RBItems.Size = new System.Drawing.Size(100, 20);
            this.RBItems.TabIndex = 7;
            this.RBItems.Text = "Items";
            // 
            // ButCloseApp
            // 
            this.ButCloseApp.Location = new System.Drawing.Point(129, 202);
            this.ButCloseApp.Name = "ButCloseApp";
            this.ButCloseApp.Size = new System.Drawing.Size(72, 20);
            this.ButCloseApp.TabIndex = 4;
            this.ButCloseApp.Text = "Exit";
            this.ButCloseApp.Click += new System.EventHandler(this.ButCloseApp_Click);
            // 
            // RBBills
            // 
            this.RBBills.Location = new System.Drawing.Point(12, 88);
            this.RBBills.Name = "RBBills";
            this.RBBills.Size = new System.Drawing.Size(100, 20);
            this.RBBills.TabIndex = 1;
            this.RBBills.Text = "Bills";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "start";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RBStores
            // 
            this.RBStores.Location = new System.Drawing.Point(12, 140);
            this.RBStores.Name = "RBStores";
            this.RBStores.Size = new System.Drawing.Size(100, 20);
            this.RBStores.TabIndex = 1;
            this.RBStores.Text = "Stores";
            // 
            // RBCusts
            // 
            this.RBCusts.Location = new System.Drawing.Point(12, 62);
            this.RBCusts.Name = "RBCusts";
            this.RBCusts.Size = new System.Drawing.Size(100, 20);
            this.RBCusts.TabIndex = 1;
            this.RBCusts.Text = "Customers";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            // 
            // InsertUserpanel
            // 
            this.InsertUserpanel.Controls.Add(this.button3);
            this.InsertUserpanel.Controls.Add(this.btnSaveCustomer);
            this.InsertUserpanel.Controls.Add(this.TitCombox);
            this.InsertUserpanel.Controls.Add(this.txtPhon);
            this.InsertUserpanel.Controls.Add(this.TxtAdrss);
            this.InsertUserpanel.Controls.Add(this.txtCustName);
            this.InsertUserpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertUserpanel.Location = new System.Drawing.Point(0, 0);
            this.InsertUserpanel.Name = "InsertUserpanel";
            this.InsertUserpanel.Size = new System.Drawing.Size(240, 267);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 20);
            this.button3.TabIndex = 11;
            this.button3.Text = "Close";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(28, 203);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(72, 20);
            this.btnSaveCustomer.TabIndex = 12;
            this.btnSaveCustomer.Text = "Save";
            // 
            // TitCombox
            // 
            this.TitCombox.Items.Add("Mr");
            this.TitCombox.Items.Add("Mrs");
            this.TitCombox.Location = new System.Drawing.Point(65, 130);
            this.TitCombox.Name = "TitCombox";
            this.TitCombox.Size = new System.Drawing.Size(100, 22);
            this.TitCombox.TabIndex = 10;
            // 
            // txtPhon
            // 
            this.txtPhon.Location = new System.Drawing.Point(66, 103);
            this.txtPhon.Name = "txtPhon";
            this.txtPhon.Size = new System.Drawing.Size(147, 21);
            this.txtPhon.TabIndex = 7;
            // 
            // TxtAdrss
            // 
            this.TxtAdrss.Location = new System.Drawing.Point(66, 72);
            this.TxtAdrss.Name = "TxtAdrss";
            this.TxtAdrss.Size = new System.Drawing.Size(147, 21);
            this.TxtAdrss.TabIndex = 8;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(66, 45);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(147, 21);
            this.txtCustName.TabIndex = 9;
            // 
            // frmSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.InsertUserpanel);
            this.Menu = this.mainMenu1;
            this.Name = "frmSelector";
            this.Text = "Mobile Sales";
            this.Load += new System.EventHandler(this.frmSelector_Load);
            this.LogPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.InsertUserpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RBStores;
        private System.Windows.Forms.RadioButton RBCusts;
        private System.Windows.Forms.RadioButton RBBills;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel InsertUserpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.ComboBox TitCombox;
        private System.Windows.Forms.TextBox txtPhon;
        private System.Windows.Forms.TextBox TxtAdrss;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Button ButCloseApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RBItems;
        private System.Windows.Forms.Button ButSync;
    }
}