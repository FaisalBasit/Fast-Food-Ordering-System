using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Login_form;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Configuration;
using System.Data.SqlClient;

namespace Fast_Food_Ordering_System
{
    public partial class SignUp : Form
    {
        //regular expression for Email validation
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        //regular expression for password validation
        string Passpattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        //regular expression for phone number validation
        string numpattern = @"^(\+92|0|92)[0-9]{10}$";
        //regular expression for Union Pay Card
        string Union = "^(62[0-9]{14,17})$";
        //regular expression for Visa Card 
        string visa = "^4[0-9]{12}(?:[0-9]{3})?$";
        //regular expression for Visa Master Card 
        string visaMaster = "^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$";
        //regular expression for Mastercard: 
        string Mastercard = "^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$";
        //regular expression for CVN
        string cvnpattern = @"^\d{3}$";
        //regular expression for expiry date
        string expiry = @"^\d{2}\/\d{2}$";
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void First_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(First.Text) == true)
            {
               
                errorProvider1.SetError(this.First, "Please fill this field!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void First_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch)==true)
            {
                e.Handled = false;
            }
            else if (ch==15)
            {
                e.Handled = false;      
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Last_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Last.Text) == true)
            {
               
                errorProvider2.SetError(this.Last, "Please fill this field!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void Last_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 15)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Email.Text, pattern) == false)
            {
               
                errorProvider3.SetError(this.Email, "Invalid Email!");
            }
           
            else
            {
                errorProvider3.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Pass.Text, Passpattern) == false)
            {
                
                errorProvider4.SetError(this.Pass, "Password must be of alteast 8 characters, must contain at least one Number, one Uppercase Letter, one Lowercase Letter and one Special Character!");
            }
           
            else
            {
                errorProvider4.Clear();
            }
        }

        private void Confirm_Leave(object sender, EventArgs e)
        {
            if(Pass.Text != Confirm.Text)
            {
                
                errorProvider5.SetError(this.Confirm, "Password does not match!");
            }

            else
            {
                errorProvider5.Clear();
            }
        
        }

       

        private void Phone_Number_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Phone_Number.Text, numpattern) == false)
            {
                
                errorProvider6.SetError(this.Phone_Number, "Invalid Phone Number!");
            }

            else
            {
                errorProvider6.Clear();
            }
        }

        private void Phone_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address.Text) == true)
            {

                errorProvider7.SetError(this.Address, "Please fill this field!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void Card_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Card_Number_Leave(object sender, EventArgs e)
        {
            string cardNumber = Card_Number.Text;
            bool isValid = false;

            if (Regex.IsMatch(Card_Number.Text,visa))
            {
                isValid = true;
            }
         

            else if (Regex.IsMatch(Card_Number.Text,visaMaster) == false)
            {
                isValid = true;
            }
           

            else if (Regex.IsMatch(Card_Number.Text,Mastercard) == false)
            {
                isValid = true;
            }
           
            else if (Regex.IsMatch(Card_Number.Text,Union) == false)
            {
                isValid = true;
            }
            if (!isValid)
            {
                
                errorProvider8.SetError(Card_Number, "Invalid card number!");
            }
            else
            {
                // Clear all error providers
                errorProvider8.Clear();
               
            }
        }

        private void CVV_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CVV.Text,cvnpattern) == false)
            {
                errorProvider10.SetError(this.CVV, "Invalid Card validation value(CVV)!");
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void CVV_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void CardExpiry_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CardExpiry.Text, expiry) == false)
            {
               
                errorProvider9.SetError(this.CVV, "Invalid format!, write in this format DD/YY");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void CardExpiry_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(First.Text))
            {
                errorProvider1.SetError(First, "Please fill this field!");
            }
            else if (string.IsNullOrEmpty(Last.Text))
            {
                errorProvider2.SetError(Last, "Please fill this field!");
            }
            else if (!Regex.IsMatch(Email.Text, pattern))
            {
                errorProvider3.SetError(Email, "Invalid Email!");
            }
            else if (!Regex.IsMatch(Pass.Text, Passpattern))
            {
                errorProvider4.SetError(Pass, "Password must be between 8 to 15 characters, must contain at least one number, one uppercase letter, one lowercase letter, and one special character!");
            }
            else if (Pass.Text != Confirm.Text)
            {
                errorProvider5.SetError(Confirm, "Password does not match!");
            }
            else if (!Regex.IsMatch(Phone_Number.Text, numpattern))
            {
                errorProvider6.SetError(Phone_Number, "Invalid Phone Number!");
            }
            else if (string.IsNullOrEmpty(Address.Text))
            {
                errorProvider7.SetError(Address, "Please fill this field!");
            }
            else if (!Regex.IsMatch(Card_Number.Text, visa) &&
                     !Regex.IsMatch(Card_Number.Text, visaMaster) &&
                     !Regex.IsMatch(Card_Number.Text, Mastercard) &&
                     !Regex.IsMatch(Card_Number.Text, Union))
            {
                errorProvider8.SetError(Card_Number, "Invalid card number!");
            }
            else if (!Regex.IsMatch(CardExpiry.Text, expiry))
            {
                errorProvider9.SetError(CardExpiry, "Invalid format! Write in this format DD/YY");
            }
            else if (!Regex.IsMatch(CVV.Text, cvnpattern))
            {
                errorProvider10.SetError(CVV, "Invalid Card validation number (CVN)!");
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query2 = "SELECT * FROM signup WHERE EMAIL = @Email";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@Email", Email.Text);
                    con.Open();
                    SqlDataReader rd = cmd2.ExecuteReader();
                    if (rd.HasRows)
                    {
                        MessageBox.Show(Email.Text + " Email address already exists!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    con.Close();

                    string query = "INSERT INTO signup (firstname, lastname, email, pass, phonenum, homeaddress, cardnumber, expirydate, cvv, feedback) " +
                                   "VALUES (@firstname, @lastname, @Email, @pass, @phonenum, @homeaddress, @cardnumber, @expirydate, @cvv, @feedback)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@firstname", First.Text);
                        cmd.Parameters.AddWithValue("@lastname", Last.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@pass", Pass.Text);
                        cmd.Parameters.AddWithValue("@phonenum", Phone_Number.Text);
                        cmd.Parameters.AddWithValue("@homeaddress", Address.Text);
                        cmd.Parameters.AddWithValue("@cardnumber", Card_Number.Text);
                        cmd.Parameters.AddWithValue("@expirydate", CardExpiry.Text);
                        cmd.Parameters.AddWithValue("@cvv", CVV.Text);
                        cmd.Parameters.AddWithValue("@feedback", DBNull.Value); // Assuming feedback is nullable in the database

                        con.Open();
                        var result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thank You for Signing up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Your Email Address is: " + Email.Text + " Your Password is: " + Pass.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Login obj = new Login();
                            obj.Show();
                            obj.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            First.Clear();
            Last.Clear();
            Email.Clear();
            Pass.Clear();
            Confirm.Clear();
            Address.Clear();
            Phone_Number.Clear();
            Card_Number.Clear();
            CardExpiry.Clear();
            CVV.Clear();
            
        }

        private void First_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
