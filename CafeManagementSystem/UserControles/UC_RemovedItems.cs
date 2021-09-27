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
    public partial class UC_RemovedItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_RemovedItems()
        {
            InitializeComponent();
        }

        private void UC_RemovedItems_Load(object sender, EventArgs e)
        {
            Lbl_Dell.Text = "How to Delete";
            Lbl_Dell.ForeColor = Color.Blue;
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }

        private void Text_DeleteItemname_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where ItemName like '" + Text_DeleteItemname.Text+ "%' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id=" +id+"";
                fn.setData(query);
                loadData();
            }
        }

        private void Lbl_Dell_Click(object sender, EventArgs e)
        {
            Lbl_Dell.ForeColor = Color.Red;
            Lbl_Dell.Text = "Click on Row to Delete the Item";
        }

        private void UC_RemovedItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
