using Fast_Food_Ordering_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_form;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml;

namespace Fast_Food_Ordering_System
{
    public partial class Form1 : Form
    {

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public bool login { get; set; }

        public Form1()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
            nameLabel.Text = "Welcome! " + firstname + " " + lastname;
            addressLabel.Text = Address;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
            nameLabel.Text = "Welcome! " + firstname + " " + lastname;
            addressLabel.Text = Address;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
       
        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            UC_Menu uc = new UC_Menu();
            addUserControl(uc);
            nameLabel.Text = "Welcome! " + firstname + " " + lastname;
            addressLabel.Text = Address;
        }

     

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

  

        private void ButtonAboutUs_Click(object sender, EventArgs e)
        {
            UC_AboutUs uc = new UC_AboutUs();
            addUserControl(uc);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            obj.BringToFront();
        }
        private void ButtonReview_Click(object sender, EventArgs e)
        {
            Review uc = new Review();
            addUserControl(uc);
            Review r = new Review
            {
                email = Email,
                IsLoggedIn = login
        };
            addUserControl(r);
        }
        

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            };
        }

       

       
    }
}
