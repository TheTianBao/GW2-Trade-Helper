using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW2_Trade_Helper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GridColor(ref int Rownumber)
        {
            string sColor;


            if (!(DGVcurrentSales.Rows[Rownumber].Cells[0].Value == null))
            {
                sColor = DGVcurrentSales.Rows[Rownumber].Cells[0].Value.ToString();

                if (sColor == "Copper")
                    DGVcurrentSales.Rows[Rownumber].Cells[0].Style.BackColor = Color.Chocolate;
                else if (sColor == "Silver")
                    DGVcurrentSales.Rows[Rownumber].Cells[0].Style.BackColor = Color.Silver;
                else if (sColor == "Gold")
                    DGVcurrentSales.Rows[Rownumber].Cells[0].Style.BackColor = Color.Gold;
           }
        }

        private void Calculation()
        {
            int RowNumber;
            RowNumber = 0;
            try
            {
                    foreach (DataGridViewRow row in DGVcurrentSales.Rows)
                    {
                        GridColor(ref RowNumber);
                    // Purchase Total Price
                    DGVcurrentSales.Rows[RowNumber].Cells[4].Value = Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[3].Value) * Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[2].Value);
                    // Sales Total Price
                    DGVcurrentSales.Rows[RowNumber].Cells[7].Value = Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[6].Value) * Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[5].Value);
                    // Offer Fee
                    DGVcurrentSales.Rows[RowNumber].Cells[8].Value = Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[7].Value) * 0.05;
                    // Exchange Fee
                    DGVcurrentSales.Rows[RowNumber].Cells[9].Value = Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[7].Value) * 0.1;
                    // Price Offer
                    DGVcurrentSales.Rows[RowNumber].Cells[10].Value = Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[9].Value) + Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[8].Value) + Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[7].Value);
                    // Profit
                    DGVcurrentSales.Rows[RowNumber].Cells[11].Value = Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[7].Value) - Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[4].Value) - Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[9].Value) - Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[8].Value);
                    // Effective Profit
                    DGVcurrentSales.Rows[RowNumber].Cells[12].Value = 100 / Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[4].Value) * Convert.ToDouble(DGVcurrentSales.Rows[RowNumber].Cells[11].Value) / 100;
                    RowNumber = RowNumber + 1;
                    }
                


            }
            catch (InvalidCastException e)
            {
                MessageBox.Show("There was a Problem, we could not calculate your Offer."  + e.Message);
            }
        }

        private void DGVcurrentSales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                Calculation();
            }
            catch (InvalidCastException ex)
            {
                //MessageBox.Show("There was a Problem, we could not calculate your Offer." + e.Message);
            }
            }




        #region "Save & Load"
        private void CMDcleanRows_click(object sender, EventArgs e)
        {
            CleanSales();
        }
        private void CMDsave_Click(object sender, EventArgs e)
        {

        }
        private void CMDexport_Click(object sender, EventArgs e)
        {
            // Don't save if no data is returned
            if (DGVcurrentSales.Rows.Count == 0)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            // Column headers
            string columnsHeader = "";
            for (int i = 0; i < DGVcurrentSales.Columns.Count; i++)
            {
                columnsHeader += DGVcurrentSales.Columns[i].Name + ";";
            }
            sb.Append(columnsHeader + Environment.NewLine);
            // Go through each cell in the datagridview
            foreach (DataGridViewRow dgvRow in DGVcurrentSales.Rows)
            {
                // Make sure it's not an empty row.
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        // Append the cells data followed by a comma to delimit.

                        sb.Append(dgvRow.Cells[c].Value + ";");
                    }
                    // Add a new line in the text file.
                    sb.Append(Environment.NewLine);
                }
            }
            // Load up the save file dialog with the default option as saving as a .csv file.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "TradeExport.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // If they've selected a save location...
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false))
                {
                    // Write the stringbuilder text to the the file.
                    sw.WriteLine(sb.ToString());
                }
            }
            // Confirm to the user it has been completed.
            MessageBox.Show("CSV file saved.");
        }
        private void CMDload_Click(object sender, EventArgs e)
        {
            string FilePath;
            CleanSales();
            OFDImport.ShowDialog();
            FilePath = OFDImport.FileName;
            LoadCSV(FilePath);
        }
        private void LoadCSV(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);

            // If the Colums are needed
            foreach (string s in sr.ReadLine().Split(';'))
            {

            //this.DGVcurrentSales.Columns.Add();

            }

            // Write the Items
            while (!sr.EndOfStream)
            {
                this.DGVcurrentSales.Rows.Add(sr.ReadLine().Split(';'));
            }

            sr.Close();
        }
        private void CleanSales()
        {
            DGVcurrentSales.Rows.Clear();
            DGVcurrentSales.Refresh();
        }
        #endregion

       
    }
}
