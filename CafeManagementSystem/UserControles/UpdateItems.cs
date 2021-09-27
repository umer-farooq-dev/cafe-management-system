using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem.UserControles
{
    public partial class UpdateItems : UserControl
    {
        function fn = new function();
        string query;


        public UpdateItems()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {

            loadData();
        }
        public void loadData()
        {
            query = "select *  from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }

        private void Text_BoxItemname_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where ItemName like '"+Text_Itemname.Text+"%' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = guna2DataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = guna2DataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString());

            Text_Category.Text = category;
            Text_ItemName2.Text = name;
            Text_Price.Text = price.ToString();
        }

        private void Batn_Update_Click(object sender, EventArgs e)
        {
            query = "upate items set ItemName '" + Text_ItemName2.Text + "',Category = '" + Text_Category + "',Price = '" + Text_Price.Text + "' where id= '" + id + "'";
            fn.setData(query);
            loadData();

            Text_ItemName2.Clear();
            Text_Category.Clear();
            Text_Price.Clear();
        }
    }
}
