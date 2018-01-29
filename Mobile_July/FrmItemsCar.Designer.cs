namespace Mobile_July
{
    partial class FrmItemsCar
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
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.ButSearch = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGrid();
            this.butCloseItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(97, 229);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(94, 21);
            this.txtSearchName.TabIndex = 7;
            // 
            // ButSearch
            // 
            this.ButSearch.Location = new System.Drawing.Point(9, 229);
            this.ButSearch.Name = "ButSearch";
            this.ButSearch.Size = new System.Drawing.Size(86, 21);
            this.ButSearch.TabIndex = 6;
            this.ButSearch.Text = "Search Item";
            this.ButSearch.Click += new System.EventHandler(this.ButSearch_Click);
            // 
            // dgItems
            // 
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgItems.Location = new System.Drawing.Point(9, 11);
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(222, 207);
            this.dgItems.TabIndex = 5;
            // 
            // butCloseItems
            // 
            this.butCloseItems.Location = new System.Drawing.Point(194, 229);
            this.butCloseItems.Name = "butCloseItems";
            this.butCloseItems.Size = new System.Drawing.Size(43, 20);
            this.butCloseItems.TabIndex = 8;
            this.butCloseItems.Text = "Close";
            this.butCloseItems.Click += new System.EventHandler(this.butCloseItems_Click);
            // 
            // FrmItemsCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.butCloseItems);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.ButSearch);
            this.Controls.Add(this.dgItems);
            this.Menu = this.mainMenu1;
            this.Name = "FrmItemsCar";
            this.Text = "FrmItemsCar";
            this.Load += new System.EventHandler(this.FrmItemsCar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button ButSearch;
        private System.Windows.Forms.DataGrid dgItems;
        private System.Windows.Forms.Button butCloseItems;
    }
}