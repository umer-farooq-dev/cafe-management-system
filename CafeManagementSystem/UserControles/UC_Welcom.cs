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
    public partial class UC_Welcom : UserControl
    {
        public UC_Welcom()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lbl_bismiallah.Location = new Point(65, 460);
                lbl_bismiallah.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                lbl_bismiallah.Location = new Point(205, 460);
                lbl_bismiallah.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                lbl_bismiallah.Location = new Point(421, 460);
                lbl_bismiallah.ForeColor = Color.RoyalBlue;
                num=0;
            }
        }

        private void UC_Welcom_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbl_bismiallah_Click(object sender, EventArgs e)
        {

        }
    }
}
