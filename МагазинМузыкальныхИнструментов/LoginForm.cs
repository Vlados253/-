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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = true;
            this.passField.Size = new Size(this.passField.Size.Width, 30);

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин") 
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "") 
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (passField.Text == "Введите пароль") 
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            String loginUser = loginField.Text;
            String passUser = passField.Text;
            String employeesPost = "Employee";
            String adminPost = "Admin";

            DB db = new DB();

            DataTable tableEmployee = new DataTable();
            DataTable tableAdmin = new DataTable();
            DataTable tableCustomer = new DataTable();

            MySqlDataAdapter adapterEmployee = new MySqlDataAdapter();
            MySqlDataAdapter adapterAdmin = new MySqlDataAdapter();
            MySqlDataAdapter adapterCustomer = new MySqlDataAdapter();

            MySqlCommand commandEmployee = new MySqlCommand("SELECT * FROM `employees` WHERE employees.login = @uL AND employees.pass = @uP AND employees.post = @eP", db.getConnetion());
            commandEmployee.Parameters.Add("@uL",MySqlDbType.VarChar).Value = loginUser;
            commandEmployee.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            commandEmployee.Parameters.Add("@eP", MySqlDbType.VarChar).Value = employeesPost;

            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);

            MySqlCommand commandAdmin = new MySqlCommand("SELECT * FROM `employees` WHERE employees.login = @uL AND employees.pass = @uP AND employees.post = @aP", db.getConnetion());
            commandAdmin.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            commandAdmin.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            commandAdmin.Parameters.Add("@aP", MySqlDbType.VarChar).Value = adminPost;

            adapterAdmin.SelectCommand = commandAdmin;
            adapterAdmin.Fill(tableAdmin);

            MySqlCommand commandCustomer = new MySqlCommand("SELECT * FROM `customers` WHERE customers.login = @uL AND customers.pass = @uP", db.getConnetion());
            commandCustomer.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            commandCustomer.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapterCustomer.SelectCommand = commandCustomer;
            adapterCustomer.Fill(tableCustomer);

            if (tableEmployee.Rows.Count > 0) 
            {
                this.Hide();
                EmployeeForm employeeform = new EmployeeForm();
                employeeform.Show();
            }
            if (tableAdmin.Rows.Count > 0) 
            {
                this.Hide();
                AdminForm adminform = new AdminForm();
                adminform.Show();
            }
            if (tableCustomer.Rows.Count > 0)
            {
                this.Hide();
                CustomerForm customerform = new CustomerForm();
                customerform.Show();
            }
            if (tableCustomer.Rows.Count < 1 && tableAdmin.Rows.Count < 1 && tableEmployee.Rows.Count < 1)
                MessageBox.Show("Такого аккаунта не существует!");

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }
    }
}
