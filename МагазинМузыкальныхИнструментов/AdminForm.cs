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
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        DB db = new DB();

        DataTable tableEmployee = new DataTable();

        MySqlDataAdapter adapterEmployee = new MySqlDataAdapter();
        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            label2.Text = "Каталог";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `musical_instruments`", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
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

        private void buttonSales_Click(object sender, EventArgs e)
        {
            label2.Text = "Продажи";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `sales`", db.getConnetion());
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

        private void buttonSpisok_Click(object sender, EventArgs e)
        {
            label2.Text = "Список успешных продаж";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `spisok` ORDER BY spisok.quantity DESC", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            label2.Text = "Список сотрудников";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `employees`", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            label2.Text = "Список покупателей";
            tableEmployee.Clear();
            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `customers`", db.getConnetion());
            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);
            dataGridView1.DataSource = tableEmployee;
        }

        private void buttonRedactor_Click(object sender, EventArgs e)
        {
            RedactorEmployeeForm redactoremployeeform = new RedactorEmployeeForm();
            redactoremployeeform.Show();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InsertForm insertform = new InsertForm();
            insertform.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteform = new DeleteForm();
            deleteform.Show();
        }
    }
}
