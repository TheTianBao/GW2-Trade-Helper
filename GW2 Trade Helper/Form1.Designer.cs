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
            this.TCSales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GBmenu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Currency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasingVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button3 = new System.Windows.Forms.Button();
            this.TCSales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TCSales
            // 
            this.TCSales.Controls.Add(this.tabPage1);
            this.TCSales.Controls.Add(this.tabPage2);
            this.TCSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TCSales.Location = new System.Drawing.Point(0, 187);
            this.TCSales.Name = "TCSales";
            this.TCSales.SelectedIndex = 0;
            this.TCSales.Size = new System.Drawing.Size(1357, 446);
            this.TCSales.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1349, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1349, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GBmenu
            // 
            this.GBmenu.Controls.Add(this.button3);
            this.GBmenu.Controls.Add(this.splitter1);
            this.GBmenu.Controls.Add(this.button2);
            this.GBmenu.Controls.Add(this.button1);
            this.GBmenu.Controls.Add(this.cmdLoad);
            this.GBmenu.Location = new System.Drawing.Point(1192, 89);
            this.GBmenu.Name = "GBmenu";
            this.GBmenu.Size = new System.Drawing.Size(165, 118);
            this.GBmenu.TabIndex = 0;
            this.GBmenu.TabStop = false;
            this.GBmenu.Text = "Menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1343, 414);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdLoad
            // 
            this.cmdLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdLoad.Location = new System.Drawing.Point(3, 16);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(159, 23);
            this.cmdLoad.TabIndex = 0;
            this.cmdLoad.Text = "Load Items";
            this.cmdLoad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Items";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // PurchasingVolume
            // 
            this.PurchasingVolume.HeaderText = "PurchasingVolume";
            this.PurchasingVolume.Name = "PurchasingVolume";
            // 
            // PurchaseUnitPrice
            // 
            this.PurchaseUnitPrice.HeaderText = "PurchaseUnitPrice";
            this.PurchaseUnitPrice.Name = "PurchaseUnitPrice";
            // 
            // PurchaseTotalPrice
            // 
            this.PurchaseTotalPrice.HeaderText = "Purchase Total Price";
            this.PurchaseTotalPrice.Name = "PurchaseTotalPrice";
            // 
            // SalesVolume
            // 
            this.SalesVolume.HeaderText = "SalesVolume";
            this.SalesVolume.Name = "SalesVolume";
            // 
            // SalesUnitPrice
            // 
            this.SalesUnitPrice.HeaderText = "Sales Unit Price";
            this.SalesUnitPrice.Name = "SalesUnitPrice";
            // 
            // SalesTotalPrice
            // 
            this.SalesTotalPrice.HeaderText = "Sales Total Price";
            this.SalesTotalPrice.Name = "SalesTotalPrice";
            // 
            // OfferFee
            // 
            this.OfferFee.HeaderText = "Offer Fee (5%)";
            this.OfferFee.Name = "OfferFee";
            // 
            // ExchangeFee
            // 
            this.ExchangeFee.HeaderText = "Exchange Fee (10%)";
            this.ExchangeFee.Name = "ExchangeFee";
            // 
            // PriceOffer
            // 
            this.PriceOffer.HeaderText = "Price Offer";
            this.PriceOffer.Name = "PriceOffer";
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            // 
            // EffectiveProfit
            // 
            this.EffectiveProfit.HeaderText = "Effective Profit (%)";
            this.EffectiveProfit.Name = "EffectiveProfit";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export Items";
            this.button2.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete all Rows";
            this.button3.UseVisualStyleBackColor = true;
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
            this.TCSales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GBmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCSales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GBmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdLoad;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button2;
    }
}

