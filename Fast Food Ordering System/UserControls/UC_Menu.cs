using Login_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Fast_Food_Ordering_System.UserControls
{
    public partial class UC_Menu : UserControl
    {

        private List<MenuItem> cartItems;
        private double totalPrice;
        public UC_Menu()
        {
            InitializeComponent();
            cartItems = new List<MenuItem>();

            totalPrice = 0.0;
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
       
        
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            var itemName =label1.Text;
            var itemPrice = double.Parse(1999.0.ToString());
            var itemQuantity = (int)guna2NumericUpDown1.Value;
            if (guna2NumericUpDown1.Value > 0)
            {
                cartItems.Add(new MenuItem { Name = itemName, Price = itemPrice, Quantity = itemQuantity });
                // Update the cartDataGridView
                UpdateCartDataGridView();

                // Calculate and display the total price
                CalculateTotalPrice();

                // Reset quantityNumericUpDown value
                guna2NumericUpDown1.Value = 1;
            }
        }
        private void UpdateCartDataGridView()
        {
            // Clear the existing rows in the cartDataGridView
            CartDataGridView.Rows.Clear();

            // Add each cart item to the cartDataGridView
            foreach (var cartItem in cartItems)
            {
                CartDataGridView.Rows.Add(cartItem.Name, cartItem.Price, cartItem.Quantity);
            }
        }
        private void CalculateTotalPrice()
        {
            totalPrice = cartItems.Sum(item => item.Price * item.Quantity);

            // Display the total price
            totalLabel.Text = totalPrice.ToString();
        }
       
        /*private bool IsUserSignedUp()
        {
              Login loginForm = new Login();
              loginForm.ShowDialog(); // Display the Login form to allow the user to sign up or login

              return loginForm.IsSignedUp;
        }
        */


            // Return true for demonstration
        

        private void PlaceOrder()
        {
            // Simulated order placement
            var currentTime = DateTime.Now;
            var deliveryTime = currentTime.AddMinutes(30);

            MessageBox.Show($"Your order is on the way and you will receive it at {deliveryTime.ToString("HH:mm")}!");
            ResetApp();
        }

        private void ResetApp()
        {
            // Clear the cart items and reset the UI
            cartItems.Clear();
            CartDataGridView.Rows.Clear();
            totalPrice = 0.0;
            totalLabel.Text = "";
        }
        public class MenuItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
        }

        
            private void gunaAdvenceButton8_Click(object sender, EventArgs e)
            {
                // Check if the user is logged in
                if (Login.IsUserLoggedIn)
                {
                    // Process the payment and place the order
                    PlaceOrder();
                }
                else
                {
                    MessageBox.Show("Please log in before proceeding to pay.");
                }
            }

        

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            
            var itemName = label8.Text;
            var itemPrice = double.Parse(699.00.ToString());
            var itemQuantity = (int)guna2NumericUpDown2.Value;
           
            if (guna2NumericUpDown2.Value > 0)
            {
                cartItems.Add(new MenuItem { Name = itemName, Price = itemPrice, Quantity = itemQuantity });
            // Update the cartDataGridView

           
                UpdateCartDataGridView();

                // Calculate and display the total price
                CalculateTotalPrice();
            }
            // Reset quantityNumericUpDown value
            guna2NumericUpDown2.Value = 1;
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            var itemName = label24.Text;
            var itemPrice = double.Parse(649.00.ToString());
            var itemQuantity = (int)guna2NumericUpDown3.Value;

            if (guna2NumericUpDown3.Value > 0)
            {
                cartItems.Add(new MenuItem { Name = itemName, Price = itemPrice, Quantity = itemQuantity });
                // Update the cartDataGridView

                UpdateCartDataGridView();

                // Calculate and display the total price
                CalculateTotalPrice();
            }
            // Reset quantityNumericUpDown value
            guna2NumericUpDown3.Value = 1;
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            var itemName = label20.Text;
            var itemPrice = double.Parse(579.00.ToString());
            var itemQuantity = (int)guna2NumericUpDown4.Value;

            if (guna2NumericUpDown4.Value > 0)
            {
                cartItems.Add(new MenuItem { Name = itemName, Price = itemPrice, Quantity = itemQuantity });
                // Update the cartDataGridView

                UpdateCartDataGridView();

                // Calculate and display the total price
                CalculateTotalPrice();
            }
            // Reset quantityNumericUpDown value
            guna2NumericUpDown4.Value = 1;
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {

            var itemName = label16.Text;
            var itemPrice = double.Parse(869.00.ToString());
            var itemQuantity = (int)guna2NumericUpDown6.Value;

            if (guna2NumericUpDown6.Value > 0)
            {
                cartItems.Add(new MenuItem { Name = itemName, Price = itemPrice, Quantity = itemQuantity });
                // Update the cartDataGridView

                UpdateCartDataGridView();

                // Calculate and display the total price
                CalculateTotalPrice();
            }
            // Reset quantityNumericUpDown value
            guna2NumericUpDown6.Value = 1;
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {

        }

        private void CartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaShadowPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            CartDataGridView.Rows.Clear();

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
