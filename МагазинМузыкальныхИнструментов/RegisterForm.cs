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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 30);

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            userEmailField.Text = "Введите e-mail";
            userEmailField.ForeColor = Color.Gray;
            userCodeField.Text = "Код (необязательно)";
            userCodeField.ForeColor = Color.Gray;
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
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

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя") 
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
                
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "") 
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
                
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void userEmailField_Enter(object sender, EventArgs e)
        {
            if (userEmailField.Text == "Введите e-mail")
            {
                userEmailField.Text = "";
                userEmailField.ForeColor = Color.Black;
            }
        }

        private void userEmailField_Leave(object sender, EventArgs e)
        {
            if (userEmailField.Text == "")
            {
                userEmailField.Text = "Введите e-mail";
                userEmailField.ForeColor = Color.Gray;
            }
        }

        private void userCodeField_Enter(object sender, EventArgs e)
        {
            if (userCodeField.Text == "Код (необязательно)")
            {
                userCodeField.Text = "";
                userCodeField.ForeColor = Color.Black;
            }
        }

        private void userCodeField_Leave(object sender, EventArgs e)
        {
            if (userCodeField.Text == "")
            {
                userCodeField.Text = "Код (необязательно)";
                userCodeField.ForeColor = Color.Gray;
            }
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
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string AdminCode = "a143a";
            string EmployeeCode = "a18a";

            if (userNameField.Text == "Введите имя") 
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (userEmailField.Text == "Введите e-mail")
            {
                MessageBox.Show("Введите e-mail!");
                return;
            }
            if (userCodeField.Text != AdminCode && userCodeField.Text != EmployeeCode && userCodeField.Text != "Код (необязательно)")
            {
                MessageBox.Show("Такого кода не существует! Введите существующий или оставьте строку пустой!");
                return;
            }
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

            DB db = new DB();
            if (userCodeField.Text == EmployeeCode)
            {
                if (isUserExists())
                    return;

                MySqlCommand command = new MySqlCommand("INSERT INTO `employees` (`name`, `surname`, `login`, `pass`, `e-mail`, `post`) VALUES (@name, @surname, @login, @pass, @email, @post)", db.getConnetion());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmailField.Text;
                command.Parameters.Add("@post", MySqlDbType.VarChar).Value = "Employee";

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");

                db.closeConnection();
            }
            if (userCodeField.Text == AdminCode)
            {
                if (isUserExists())
                    return;

                MySqlCommand command = new MySqlCommand("INSERT INTO `employees` (`name`, `surname`, `login`, `pass`, `e-mail`, `post`) VALUES (@name, @surname, @login, @pass, @email, @post)", db.getConnetion());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmailField.Text;
                command.Parameters.Add("@post", MySqlDbType.VarChar).Value = "Admin";

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");

                db.closeConnection();
            }
            if (userCodeField.Text == "Код (необязательно)")
            {
                if (isUserExists())
                    return;

                MySqlCommand command = new MySqlCommand("INSERT INTO `customers` (`name`, `surname`, `login`, `pass`, `e-mail`) VALUES (@name, @surname, @login, @pass, @email)", db.getConnetion());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmailField.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");

                db.closeConnection();
            }

        }

        public Boolean isUserExists() 
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employees`,`customers` WHERE employees.login = @uL OR customers.login  = @uL", db.getConnetion());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой!");
                return true;
            }

            else 
            {
                return false;
            }   
        }

        private void ArrowBackLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void ArrowBackLabel_MouseEnter(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.Gray;
        }

        private void ArrowBackLabel_MouseLeave(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.White;
        }
    }
}
