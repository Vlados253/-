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

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            /*userEmailField.Text = "Введите e-mail";
            userEmailField.ForeColor = Color.Gray;
            userCodeField.Text = "Код (необязательно)";
            userCodeField.ForeColor = Color.Gray;
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;*/
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (userCodeField.Text == "14318")
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `employees` (`name`, `surname`, `login`, `pass`, `e-mail`, `post`) VALUES (@name, @surname, @login, @pass, @email, @post)", db.getConnetion());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmailField.Text;
                command.Parameters.Add("@post", MySqlDbType.VarChar).Value = "Сотрудник";

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");

                db.closeConnection();
            }
            if (userCodeField.Text == "a143a")
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `employees` (`name`, `surname`, `login`, `pass`, `e-mail`, `post`) VALUES (@name, @surname, @login, @pass, @email, @post)", db.getConnetion());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmailField.Text;
                command.Parameters.Add("@post", MySqlDbType.VarChar).Value = "Администратор";

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");

                db.closeConnection();
            }
            else
            {
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
    }
}
