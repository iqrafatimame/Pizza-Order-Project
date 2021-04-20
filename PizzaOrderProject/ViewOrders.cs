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
using System.Configuration;

namespace PizzaOrderProject
{
    public partial class viewOrder : Form
    {
        // Sql connection  - connection string
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public viewOrder()
        {
            InitializeComponent();
            populateDate();
        }
        private void populateDate()
        {

           // SQL query to select the data from three different table to show them in the grid view
            string query = "SELECT CUSTOMERS.custName, ORDERS.size,ToppingsTable.Pepperoni, ToppingsTable.Jalapeno, ToppingsTable.spinach, ToppingsTable.extraCheese, ToppingsTable.mushroom, ToppingsTable.roastedGarlic FROM CUSTOMERS INNER JOIN ORDERS ON CUSTOMERS.custID = ORDERS.custID INNER JOIN ToppingsTable ON ORDERS.OrderId = ToppingsTable.OrderId";
            

            // +++ CONNECTION OPEN +++
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            // +++ CONNECTION CLOSE +++

        }

        private void viewOrder_Load(object sender, EventArgs e)
        {
            
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void viewOrder_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.database1DataSet1.ORDERS);
            // TODO: This line of code loads data into the 'database1DataSet1.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.database1DataSet1.CUSTOMERS);

        }

        private void srchCustBtn_Click(object sender, EventArgs e)
        {
            
            // SQL query to select the order record based on the customer's name searched by the user
            string searchQuery = "SELECT CUSTOMERS.custName, ORDERS.size,ToppingsTable.Pepperoni, ToppingsTable.Jalapeno, ToppingsTable.spinach, ToppingsTable.extraCheese, ToppingsTable.mushroom, ToppingsTable.roastedGarlic FROM CUSTOMERS INNER JOIN ORDERS ON CUSTOMERS.custID = ORDERS.custID INNER JOIN ToppingsTable ON ORDERS.OrderId = ToppingsTable.OrderId WHERE CUSTOMERS.custName LIKE '%" + srchCustBox.Text + "%' ";


            // +++ COONECTION OPEN +++
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(searchQuery, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            // CONNECTION CLOSE +++


            // Shoe a message box if the record does not exists
            if (ad.Fill(dt) == 0)
            {
                MessageBox.Show("Record Not Found..");
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // SQL query to select the order records based on the size of pizza entered by user in th ecombo box
            string searchComboQuery = "SELECT CUSTOMERS.custID, CUSTOMERS.custName, CUSTOMERS.custPhone, ORDERS.OrderId, ORDERS.size, ORDERS.quantity FROM[dbo].[CUSTOMERS] INNER JOIN[dbo].[ORDERS] ON (CUSTOMERS.custId = ORDERS.custID) WHERE ORDERS.size LIKE '%" + sizeCombo.Text + "%' ";

            // +++ CONNECTION OPEN +++
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(searchComboQuery, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            // +++ CONNECTION CLOSE +++


            // Show message if the record does not exists
            if (ad.Fill(dt) == 0)
            {
                MessageBox.Show("Record Not Found..");
            }
            
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
