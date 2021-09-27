using CafeManagementSystem.UserControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CafeManagementSystem
{
    public partial class Dasboard : Telerik.WinControls.UI.RadForm
    {
        public Dasboard()
        {
            InitializeComponent();
        }

        public Dasboard(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                Btn_Add.Hide();
                Btn_Remove.Hide();
                Btn_Update.Hide();
            }else if (user == "Admin")
            {
                Btn_Add.Show();
                Btn_Update.Show();
                Btn_Remove.Show();

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

        {
            if (MessageBox.Show("Are You Sure You want to LogOut?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                RadForm1 fm = new RadForm1();
                this.Hide();
                fm.Show();
            }
          
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            uC_Items1.Visible = true;
            uC_Items1.BringToFront();
        }

        private void Dasboard_Load(object sender, EventArgs e)
        {
            uC_Items1.Visible = false;
            UC_placeOrder1.Visible= false;
            updateItems1.Visible= false;
            uC_RemovedItems1.Visible= false;
        }

        private void uC_Items1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            uC_Welcom1.SendToBack();
            guna2Transition1.ShowSync(UC_placeOrder1);
            UC_placeOrder1.Visible = true;
            UC_placeOrder1.BringToFront();
           
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            updateItems1.Visible = true;
            updateItems1.BringToFront();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            uC_RemovedItems1.Visible = true;
            uC_RemovedItems1.BringToFront();
        }

        private void uC_RemovedItems1_Load(object sender, EventArgs e)
        {

        }
    }
}
