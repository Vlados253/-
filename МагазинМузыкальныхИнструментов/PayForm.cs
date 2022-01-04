using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace МагазинМузыкальныхИнструментов
{
    public partial class PayForm : Form
    {
        DB db = new DB();

        DataTable tableCustomer = new DataTable();
        DataTable tableCustomer2 = new DataTable();
        DataTable tableCustomer3 = new DataTable();
        
        MySqlDataAdapter adapterCustomer = new MySqlDataAdapter();
        MySqlDataAdapter adapterCustomer2 = new MySqlDataAdapter();
        MySqlDataAdapter adapterCustomer3 = new MySqlDataAdapter();
        
        public PayForm()
        {
            InitializeComponent();
        }
        private void PayForm_Load(object sender, EventArgs e)
        {
            MySqlCommand commandCustomer = new MySqlCommand("SELECT musical_instruments.cost FROM `musical_instruments`,`orders` WHERE musical_instruments.instrument_name = orders.instrument_name AND orders.cost = 0", db.getConnetion());
            adapterCustomer.SelectCommand = commandCustomer;
            adapterCustomer.Fill(tableCustomer);
            dataGridView1.DataSource = tableCustomer;

            MySqlCommand commandCustomer2 = new MySqlCommand("SELECT quantity FROM `orders` WHERE cost = 0", db.getConnetion());
            adapterCustomer2.SelectCommand = commandCustomer2;
            adapterCustomer2.Fill(tableCustomer2);
            dataGridView2.DataSource = tableCustomer2;

            MySqlCommand commandCustomer3 = new MySqlCommand("SELECT orders.quantity * musical_instruments.cost FROM `orders`,`musical_instruments` WHERE orders.instrument_name = musical_instruments.instrument_name AND orders.cost = 0", db.getConnetion());
            adapterCustomer3.SelectCommand = commandCustomer3;
            adapterCustomer3.Fill(tableCustomer3);
            dataGridView3.DataSource = tableCustomer3;
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            String ordersstatus = "In process";

            MySqlCommand commandCustomer3 = new MySqlCommand("UPDATE `orders` SET orders.cost = (SELECT musical_instruments.cost FROM `musical_instruments` WHERE musical_instruments.instrument_name = orders.instrument_name AND orders.cost = 0), orders.itogo = (SELECT orders.quantity *  musical_instruments.cost FROM `musical_instruments` WHERE orders.instrument_name = musical_instruments.instrument_name AND orders.itogo = 0),orders.status = @oS WHERE orders.cost = 0", db.getConnetion());
            commandCustomer3.Parameters.Add("@oS", MySqlDbType.VarChar).Value = ordersstatus;

            adapterCustomer3.SelectCommand = commandCustomer3;
            adapterCustomer3.Fill(tableCustomer3);

            MessageBox.Show("Заказ принят");

            this.Hide();
            CustomerForm customerform = new CustomerForm();
            customerform.Show();
        }
        private void ArrowBackLabel_Click(object sender, EventArgs e)
        {
            MySqlCommand commandCustomer3 = new MySqlCommand("DELETE FROM `orders` WHERE orders.cost = 0", db.getConnetion());
       
            adapterCustomer3.SelectCommand = commandCustomer3;
            adapterCustomer3.Fill(tableCustomer3);

            this.Hide();
            OrderForm orderform = new OrderForm();
            orderform.Show();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            MySqlCommand commandCustomer3 = new MySqlCommand("DELETE FROM `orders` WHERE orders.cost = 0", db.getConnetion());

            adapterCustomer3.SelectCommand = commandCustomer3;
            adapterCustomer3.Fill(tableCustomer3);

            Application.Exit();
        }
        private void ArrowBackLabel_MouseEnter(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.Gray;
        }
        private void ArrowBackLabel_MouseLeave(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.White;
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
