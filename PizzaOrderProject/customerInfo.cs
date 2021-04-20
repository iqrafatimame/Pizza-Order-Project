using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PizzaOrderProject
{
    public partial class CustomerDetails : Form
    {
        // public variable to store the value of customer id and then send it to the other form
        public static string setCustomerId = "";
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {

            // Storing the text field's value into some string variables
            string Name = nameBox.Text;
            string Phone = phoneBox.Text;
            string Address = addressbox.Text;
            string id = custIdBox.Text;
            
            // SQL query to insert data in CUSTOMERS table
            string insertCustomer = @"INSERT INTO CUSTOMERS(custID, custName, custPhone, custAddress) VALUES ( @i, @n, @p, @ad)";

            // If any of the text field is not filled then give an error message
            if (Name == "" | Phone == "" | Address == "" | id == "")
            {
                MessageBox.Show("Kindly fill all fileds");
                return;
            }
            // If primary key alreday exists, gives an error message and do not insert it in the table
            cn.Open();
            String prim = "SELECT * FROM CUSTOMERS WHERE custID = @id";
            SqlCommand cmd2 = new SqlCommand(prim, cn);

            cmd2.Parameters.AddWithValue("@id", custIdBox.Text);
            cmd2.ExecuteNonQuery();
            SqlDataReader read = cmd2.ExecuteReader();

            // If the table has already a row having this ID
            bool flag = read.HasRows;
            cn.Close();

            if (flag)
            {
                MessageBox.Show("Alreday customer with this ID exists!");
                custIdBox.Text = "";
                return;
            }
            // Insert data into database
            SqlCommand insertCustomerCmd = new SqlCommand(insertCustomer, cn);

            insertCustomerCmd.Parameters.AddWithValue("@i", id);
            insertCustomerCmd.Parameters.AddWithValue("@n", Name);
            insertCustomerCmd.Parameters.AddWithValue("@p", Phone);
            insertCustomerCmd.Parameters.AddWithValue("@ad", Address);

            // ++++ CONNECTION OPEN ++++
            cn.Open();
            insertCustomerCmd.ExecuteNonQuery();
            cn.Close();
            // ++++ CONNECTION CLOSE +++

            MessageBox.Show("New customer Added Succesfully :) ");
            
            // Open Order Details Form on Button Click
            using(OrderDetails c = new OrderDetails())
            {
                
                setCustomerId = id;   
                OrderDetails orderForm = new OrderDetails();
                this.Hide();
                orderForm.ShowDialog();
            }
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Changing the focus of keyboard to Phone Text Box on keypress 
            if(e.KeyCode == Keys.Enter)
            {
                phoneBox.Focus();
            }
        }

        private void phoneBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If the data in Phone Text Box is not a number then show an error message
            if (e.KeyCode == Keys.Enter)
            {
                string tString = phoneBox.Text;
                if (tString.Trim() == "") return;
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Please enter a valid number");

                        // Empty the filed for reentry
                        phoneBox.Text = "";
                        return;
                    }

                }
                

                // Change the fovus of keyboard to Address Box on Keypress
                addressbox.Focus();
            }
        }

        private void addressbox_KeyDown(object sender, KeyEventArgs e)
        {
            // Changing the focus of keyboard to ADd Customer Button on keypress
            if (e.KeyCode == Keys.Enter)
            {
                addCustBtn.Focus();
            }
        }

        private void cancelCustBtn_Click(object sender, EventArgs e)
        {
            // Open Home home on Button Click
            using(Home c = new Home())
            {
                this.Hide();
                c.ShowDialog();
            }
        }

        private void custIdBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Show an error message if the Customer Id is not a number
            if (e.KeyCode == Keys.Enter)
            {
                string tString = custIdBox.Text;
                if (tString.Trim() == "") return;
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Enter a valid Id. Customer ID can only be a number!");
                        phoneBox.Text = "";
                        return;
                    }
                }
                nameBox.Focus();
            }
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
