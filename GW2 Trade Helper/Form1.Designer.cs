namespace GW2_Trade_Helper
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GBmenu = new System.Windows.Forms.GroupBox();
            this.CMDcleanRows = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.CMDexport = new System.Windows.Forms.Button();
            this.CMDsave = new System.Windows.Forms.Button();
            this.CMDload = new System.Windows.Forms.Button();
            this.OFDImport = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVcurrentSales = new System.Windows.Forms.DataGridView();
            this.EffectiveProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasingVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TCSales = new System.Windows.Forms.TabControl();
            this.GBmenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcurrentSales)).BeginInit();
            this.TCSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBmenu
            // 
            this.GBmenu.Controls.Add(this.CMDcleanRows);
            this.GBmenu.Controls.Add(this.splitter1);
            this.GBmenu.Controls.Add(this.CMDexport);
            this.GBmenu.Controls.Add(this.CMDsave);
            this.GBmenu.Controls.Add(this.CMDload);
            this.GBmenu.Location = new System.Drawing.Point(1192, 89);
            this.GBmenu.Name = "GBmenu";
            this.GBmenu.Size = new System.Drawing.Size(165, 118);
            this.GBmenu.TabIndex = 0;
            this.GBmenu.TabStop = false;
            this.GBmenu.Text = "Menu";
            // 
            // CMDcleanRows
            // 
            this.CMDcleanRows.Dock = System.Windows.Forms.DockStyle.Top;
            this.CMDcleanRows.Location = new System.Drawing.Point(3, 88);
            this.CMDcleanRows.Name = "CMDcleanRows";
            this.CMDcleanRows.Size = new System.Drawing.Size(159, 23);
            this.CMDcleanRows.TabIndex = 4;
            this.CMDcleanRows.Text = "Delete all Rows";
            this.CMDcleanRows.UseVisualStyleBackColor = true;
            this.CMDcleanRows.Click += new System.EventHandler(this.CMDcleanRows_click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 85);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(159, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // CMDexport
            // 
            this.CMDexport.Dock = System.Windows.Forms.DockStyle.Top;
            this.CMDexport.Location = new System.Drawing.Point(3, 62);
            this.CMDexport.Name = "CMDexport";
            this.CMDexport.Size = new System.Drawing.Size(159, 23);
            this.CMDexport.TabIndex = 2;
            this.CMDexport.Text = "Export Items";
            this.CMDexport.UseVisualStyleBackColor = true;
            this.CMDexport.Click += new System.EventHandler(this.CMDexport_Click);
            // 
            // CMDsave
            // 
            this.CMDsave.Dock = System.Windows.Forms.DockStyle.Top;
            this.CMDsave.Enabled = false;
            this.CMDsave.Location = new System.Drawing.Point(3, 39);
            this.CMDsave.Name = "CMDsave";
            this.CMDsave.Size = new System.Drawing.Size(159, 23);
            this.CMDsave.TabIndex = 1;
            this.CMDsave.Text = "Save Items";
            this.CMDsave.UseVisualStyleBackColor = true;
            this.CMDsave.Click += new System.EventHandler(this.CMDsave_Click);
            // 
            // CMDload
            // 
            this.CMDload.Dock = System.Windows.Forms.DockStyle.Top;
            this.CMDload.Location = new System.Drawing.Point(3, 16);
            this.CMDload.Name = "CMDload";
            this.CMDload.Size = new System.Drawing.Size(159, 23);
            this.CMDload.TabIndex = 0;
            this.CMDload.Text = "Load Items";
            this.CMDload.UseVisualStyleBackColor = true;
            this.CMDload.Click += new System.EventHandler(this.CMDload_Click);
            // 
            // OFDImport
            // 
            this.OFDImport.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVcurrentSales);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1349, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVcurrentSales
            // 
            this.DGVcurrentSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcurrentSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Currency,
            this.ItemName,
            this.PurchasingVolume,
            this.PurchaseUnitPrice,
            this.PurchaseTotalPrice,
            this.SalesVolume,
            this.SalesUnitPrice,
            this.SalesTotalPrice,
            this.OfferFee,
            this.ExchangeFee,
            this.PriceOffer,
            this.Profit,
            this.EffectiveProfit});
            this.DGVcurrentSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVcurrentSales.Location = new System.Drawing.Point(3, 3);
            this.DGVcurrentSales.Name = "DGVcurrentSales";
            this.DGVcurrentSales.Size = new System.Drawing.Size(1343, 414);
            this.DGVcurrentSales.TabIndex = 0;
            this.DGVcurrentSales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcurrentSales_CellValueChanged);
            // 
            // EffectiveProfit
            // 
            this.EffectiveProfit.HeaderText = "Effective Profit (%)";
            this.EffectiveProfit.Name = "EffectiveProfit";
            this.EffectiveProfit.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // PriceOffer
            // 
            this.PriceOffer.HeaderText = "Price Offer";
            this.PriceOffer.Name = "PriceOffer";
            this.PriceOffer.ReadOnly = true;
            // 
            // ExchangeFee
            // 
            this.ExchangeFee.HeaderText = "Exchange Fee (10%)";
            this.ExchangeFee.Name = "ExchangeFee";
            this.ExchangeFee.ReadOnly = true;
            // 
            // OfferFee
            // 
            this.OfferFee.HeaderText = "Offer Fee (5%)";
            this.OfferFee.Name = "OfferFee";
            this.OfferFee.ReadOnly = true;
            // 
            // SalesTotalPrice
            // 
            this.SalesTotalPrice.HeaderText = "Sales Total Price";
            this.SalesTotalPrice.Name = "SalesTotalPrice";
            this.SalesTotalPrice.ReadOnly = true;
            // 
            // SalesUnitPrice
            // 
            this.SalesUnitPrice.HeaderText = "Sales Unit Price";
            this.SalesUnitPrice.Name = "SalesUnitPrice";
            // 
            // SalesVolume
            // 
            this.SalesVolume.HeaderText = "SalesVolume";
            this.SalesVolume.Name = "SalesVolume";
            // 
            // PurchaseTotalPrice
            // 
            this.PurchaseTotalPrice.HeaderText = "Purchase Total Price";
            this.PurchaseTotalPrice.Name = "PurchaseTotalPrice";
            this.PurchaseTotalPrice.ReadOnly = true;
            // 
            // PurchaseUnitPrice
            // 
            this.PurchaseUnitPrice.HeaderText = "PurchaseUnitPrice";
            this.PurchaseUnitPrice.Name = "PurchaseUnitPrice";
            // 
            // PurchasingVolume
            // 
            this.PurchasingVolume.HeaderText = "PurchasingVolume";
            this.PurchasingVolume.Name = "PurchasingVolume";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Items.AddRange(new object[] {
            "Copper",
            "Silver",
            "Gold"});
            this.Currency.Name = "Currency";
            // 
            // TCSales
            // 
            this.TCSales.Controls.Add(this.tabPage1);
            this.TCSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TCSales.Location = new System.Drawing.Point(0, 187);
            this.TCSales.Name = "TCSales";
            this.TCSales.SelectedIndex = 0;
            this.TCSales.Size = new System.Drawing.Size(1357, 446);
            this.TCSales.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GW2_Trade_Helper.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 633);
            this.Controls.Add(this.GBmenu);
            this.Controls.Add(this.TCSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GW2 Trade Helper";
            this.GBmenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcurrentSales)).EndInit();
            this.TCSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBmenu;
        private System.Windows.Forms.Button CMDsave;
        private System.Windows.Forms.Button CMDload;
        private System.Windows.Forms.Button CMDcleanRows;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button CMDexport;
        private System.Windows.Forms.OpenFileDialog OFDImport;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVcurrentSales;
        private System.Windows.Forms.DataGridViewComboBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasingVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangeFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveProfit;
        private System.Windows.Forms.TabControl TCSales;
    }
}

