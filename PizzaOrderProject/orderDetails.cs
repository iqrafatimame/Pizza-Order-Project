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
    public partial class OrderDetails : Form
    {
        // Sql connection - connection string
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public string custId;
        public string passingId
        {
            get { return custId; }
            set { custId = value; }
        }
        public OrderDetails()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            // declaring variables to store the textbox, checkbox or radio button's values
            string size;
            string orderId = orderIdBox.Text;
            string custIdText = custIdBox.Text;
            String quantity = quantityBox.GetItemText(quantityBox.SelectedItem);
            string pepporoni = "NO";
            string jalapeno = "NO";
            string garlic= "NO";
            string spinach = "NO";
            string cheese = "NO";
            string mushroom = "NO";
            
            // To check which radio button (pizza size) has been selected
                if (radioButton1.Checked)
                {
                    size = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    size = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    size = radioButton3.Text;
                }
                else 
                {
                    size = radioButton4.Text;
                }
            // To check which Toppings have been selected

                if (peperoniBox.Checked)
                {
                    pepporoni = "YES";
                }
                if (jalapenoBox.Checked)
                {
                    jalapeno = "YES";
                }
                if (cheeseBox.Checked)
                {
                    cheese = "YES";
                }
                if (garlicBox.Checked)
                {
                    garlic = "YES";
                }
                if (mushroomBox.Checked)
                {
                    mushroom = "YES";
                }
                if (spinachBox.Checked)
                {
                    spinach = "YES";
                }

            // Give error message if no size is selected
            if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Kindly choose a pizza size!");
                return;
            }

            // +++ CONNECTION CLOSE +++
            cn.Open();
            String prim = "SELECT * FROM ORDERS WHERE OrderId = @i";
            SqlCommand cmd2 = new SqlCommand(prim, cn);

            cmd2.Parameters.AddWithValue("@i", orderIdBox.Text);
            cmd2.ExecuteNonQuery();
            SqlDataReader read = cmd2.ExecuteReader();

            // If the table has already a row having this ID
            bool flag = read.HasRows;
            cn.Close();

            if (flag)
            {
                MessageBox.Show("Alreday order with this ID exists!");
                orderIdBox.Text = "";
                return;
            }

            // Sql Query to insert data in orders table by using custId as foreign key
            string inserOrder = @"INSERT INTO ORDERS(custId, OrderId, size, quantity) VALUES (@cid, @id, @s, @q)";
            
            // Sql Query to insert data into Toppings table by uisng OrderId as Foreign key
            string insertTopping = @"INSERT INTO ToppingsTable(ToppingsTable.OrderId,ToppingsTable.Pepperoni, ToppingsTable.Jalapeno, ToppingsTable.spinach, ToppingsTable.extraCheese, ToppingsTable.mushroom, ToppingsTable.roastedGarlic) VALUES (@ordId, @p, @j, @s, @c, @m, @g)";

            // Initializing the SQL commands with the connection strings
            SqlCommand insertOrderCmd = new SqlCommand(inserOrder, cn);
            SqlCommand insertToppingCmd = new SqlCommand(insertTopping, cn);
            

            // Inserting data in Data Grid View
            insertOrderCmd.Parameters.AddWithValue("@cid", custIdText);
            insertOrderCmd.Parameters.AddWithValue("@id", orderId);
            insertOrderCmd.Parameters.AddWithValue("@s", size);
            insertOrderCmd.Parameters.AddWithValue("@q", quantity);

            insertToppingCmd.Parameters.AddWithValue("@ordId", orderIdBox.Text);
            insertToppingCmd.Parameters.AddWithValue("@p", pepporoni);
            insertToppingCmd.Parameters.AddWithValue("@j", jalapeno);
            insertToppingCmd.Parameters.AddWithValue("@s", spinach);
            insertToppingCmd.Parameters.AddWithValue("@c", cheese);
            insertToppingCmd.Parameters.AddWithValue("@m", mushroom);
            insertToppingCmd.Parameters.AddWithValue("@g", garlic);

            // +++ CONNECTION OPEN +++
            cn.Open();

            // Executing the queries
            insertOrderCmd.ExecuteNonQuery();
            insertToppingCmd.ExecuteNonQuery();
            cn.Close();


            
            

            // Open Home page on Button click
            using (Home c =new Home())
            {
                MessageBox.Show("Successfully made an order!");
                this.Hide();
                c.ShowDialog();
            }
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            // Pre filling Customer Id by taking it's value from CustomerDetails Form
            custIdBox.Text = CustomerDetails.setCustomerId;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orderIdBox_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
