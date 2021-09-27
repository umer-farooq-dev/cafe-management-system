using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace CafeManagementSystem
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RadForm1_Load(object sender, EventArgs e)
        {

        }

        private void lnk_guest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dasboard ds = new Dasboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_User.Text== "malik" && txt_Password.Text=="malik")
            {
                Dasboard ds = new Dasboard("Admin");
                ds.Show();
            }
            else
            {
                MessageBox.Show("User name and password is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
