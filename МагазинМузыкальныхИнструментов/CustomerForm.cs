using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МагазинМузыкальныхИнструментов
{
    public partial class CustomerForm : Form
    {
        DB db = new DB();

        DataTable tableCustomer = new DataTable();

        MySqlDataAdapter adapterCustomer = new MySqlDataAdapter();
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            MySqlCommand commandCustomer = new MySqlCommand("SELECT musical_instruments.instrument_name,musical_instruments.cost,musical_instruments.type FROM `musical_instruments`", db.getConnetion());
            adapterCustomer.SelectCommand = commandCustomer;
            adapterCustomer.Fill(tableCustomer);
            dataGridView1.DataSource = tableCustomer;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            tableCustomer.Clear();
            adapterCustomer.Fill(tableCustomer);
            dataGridView1.DataSource = tableCustomer;
        }
        private void orderButton_Click(object sender, EventArgs e)
        {         
            OrderForm orderform = new OrderForm();
            orderform.Show();
        }
    }
}
