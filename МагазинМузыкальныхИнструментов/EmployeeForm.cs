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
    public partial class EmployeeForm : Form
    {
        DB db = new DB();

        DataTable tableEmployee = new DataTable();
        
        MySqlDataAdapter adapterEmployee = new MySqlDataAdapter();
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        private void buttonReceipts_Click(object sender, EventArgs e)
        {
            label2.Text = "Поступления";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `receipts`", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }
        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            label2.Text = "Каталог";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `musical_instruments`", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }
        private void buttonSales_Click(object sender, EventArgs e)
        {
            label2.Text = "Продажи";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `sales`", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }
        private void buttonSpisok_Click(object sender, EventArgs e)
        {
            label2.Text = "Список успешных продаж";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `spisok` ORDER BY spisok.quantity DESC", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            label2.Text = "Заказы";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `orders`", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }

        private void buttonRedactor_Click(object sender, EventArgs e)
        {
            RedactorEmployeeForm redactoremployeeform = new RedactorEmployeeForm();
            redactoremployeeform.Show();
        }
    }
}
