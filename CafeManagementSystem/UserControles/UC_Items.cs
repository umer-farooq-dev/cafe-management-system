using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagementSystem.UserControles
{

    public partial class UC_Items : UserControl
    {
        SqlConnection con = new SqlConnection("server =.; database=restro;uid=sa;pwd=123");
        SqlCommand cmd; 
        
        public UC_Items()

        {
            InitializeComponent();
        }

        #region methods

        public void insert()
        {
            try
            {


                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmd = new SqlCommand("sp_Items", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Category", Txt_category.Text.ToString());
                cmd.Parameters.AddWithValue("@ItemName", Txt_ItemName.Text.ToString());
                cmd.Parameters.AddWithValue("@Price", Txt_Price.Text.ToString());
                int row = cmd.ExecuteNonQuery();
               
                if (row > 0)
                {
                    MessageBox.Show("Data insert Sucessfully");
                }
                else
                {
                    MessageBox.Show("Data Not Save");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            insert();

        }
        public void clearAll()
        {
            Txt_category.SelectedIndex = -1;
            Txt_ItemName.Clear();
            Txt_Price.Clear();
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_ItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

        private void radLabel3_Click(object sender, EventArgs e)
        {

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
