using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = PnlMain.Height;
            PnlMain.Location = new Point(5, 5);
            Pnl.Location = new Point(394, 5);
        }

        private void PnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            PnlRegister.Height = PnlMain.Height;
            PnlMain.Location = new Point(5,5);
            Pnl.Location = new Point(394,5);
        }

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0;
            PnlMain.Location = new Point(394, 5);
            Pnl.Location= new Point(5,5);
        }

        private void gunaTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            PnlRegister.Height = 0;
            PnlMain.Location = new Point(394, 5);
            Pnl.Location = new Point(5,5);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
