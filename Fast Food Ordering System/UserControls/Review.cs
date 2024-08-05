using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fast_Food_Ordering_System.UserControls
{
    public partial class Review : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public string email { get; set; }
        public bool IsLoggedIn { get; set; } // Property to track login status

        public Review()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            feedback.Text = "";
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn) // Check if the user is logged in
            {
                MessageBox.Show("Please login first before giving feedback.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(cs);
            if (string.IsNullOrWhiteSpace(feedback.Text))
            {
                MessageBox.Show("Please write feedback", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string updateData = "UPDATE signup SET feedback = @feedback WHERE email = @Email";

                using (SqlCommand cmd = new SqlCommand(updateData, con))
                {
                    cmd.Parameters.AddWithValue("@feedback", feedback.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thank you for writing feedback!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
