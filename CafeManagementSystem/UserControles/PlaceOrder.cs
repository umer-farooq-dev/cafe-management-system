using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Telerik.Collections.Generic;
using DGVPrinterHelper;

namespace CafeManagementSystem.UserControles
{
    public partial class Uc_PlaceOrder1 : UserControl
    {
        function fn = new function();
        string query;
        public Uc_PlaceOrder1()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
            string Category = txt_ComboBox.Text;
            query = "select ItemName from items where Category='" + Category + "' and itemName Like '"+Txt_search.Text+"%'";
            showItemList(query);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_QuantityUpDown.ResetText();
            Txt_Total.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txt_ItemName.Text = text;
            query = "select Price from items where ItemName ='" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                Txt_Price.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void Guna2_Combox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string Category = txt_ComboBox.Text;
            query = "select ItemName from items where Category='"+Category+"'";
            showItemList(query);
            
        }
        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void Txt_QuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan= Int64.Parse(Txt_QuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(Txt_Price.Text);
            Txt_Total.Text = (quan * price).ToString();
        }
        protected int n, total = 0;

        private void txt_ItemName_TextChanged(object sender, EventArgs e)
        {

        }
        int amount;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {}
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView2.Rows.RemoveAt(this.guna2DataGridView2.SelectedRows[0].Index);
            }
            catch 
            { }
            total -= amount;
            Lbl_TotalAmount.Text = "Rs. " + total;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount :" + Lbl_TotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView2);

            total = 0;
            guna2DataGridView2.Rows.Clear();
            Lbl_TotalAmount.Text = "Rs. " + total;
             }

        private void btn_AddCart_Click(object sender, EventArgs e)
        {
            if (Txt_Total.Text != "0" && Txt_Total.Text != "")
            {
                n = guna2DataGridView2.Rows.Add();
                guna2DataGridView2.Rows[n].Cells[0].Value = txt_ItemName.Text;
                guna2DataGridView2.Rows[n].Cells[1].Value = Txt_Price.Text;
                guna2DataGridView2.Rows[n].Cells[2].Value = Txt_QuantityUpDown.Value;
                guna2DataGridView2.Rows[n].Cells[3].Value = Txt_Total.Text;

                total += int.Parse(Txt_Total.Text);
                Lbl_TotalAmount.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
