using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {

            // Open customer details form on button click
            using(CustomerDetails c = new CustomerDetails())
            {
                c.ShowDialog();
            }
        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {
            //Open View Order Form on Button Click
            using(viewOrder c = new viewOrder())
            {
                c.ShowDialog();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Exit from the application
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
