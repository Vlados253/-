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
    public partial class DeleteForm : Form
    {
        DB db = new DB();

        DataTable tableEmployee = new DataTable();

        MySqlDataAdapter adapterEmployee = new MySqlDataAdapter();
        public DeleteForm()
        {
            InitializeComponent();

            textBoxId.Text = "Введите номер строки";
            textBoxId.ForeColor = Color.Gray;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkBoxPost.Checked != true && checkBoxKata.Checked != true && checkBoxSale.Checked != true && checkBoxOrder.Checked != true && checkBoxEmployee.Checked != true && checkBoxCustomers.Checked != true) 
            {
                MessageBox.Show("Выберите таблицу!");
                return;
            }
            if (checkBoxFull.Checked != true && textBoxId.Text == "Введите номер строки") 
            {
                MessageBox.Show("Введите номер инструмента или поставьте галочку "+"удалить всю таблицу");
                return;
            }
            if (checkBoxPost.Checked == true) 
            {
                if (checkBoxFull.Checked == true) 
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `receipts`", db.getConnetion());

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                if (checkBoxFull.Checked != true) 
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `receipts` WHERE receipts.id = @tI", db.getConnetion());
                    commandEmployee.Parameters.Add("@tI", MySqlDbType.Int32).Value = textBoxId.Text;

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
            }
            if (checkBoxKata.Checked == true)
            {
                if (checkBoxFull.Checked == true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `musical_instruments`", db.getConnetion());

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                if (checkBoxFull.Checked != true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `musical_instruments` WHERE musical_instruments.id = @tI", db.getConnetion());
                    commandEmployee.Parameters.Add("@tI", MySqlDbType.Int32).Value = textBoxId.Text;

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
            }
            if (checkBoxSale.Checked == true)
            {
                if (checkBoxFull.Checked == true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `sales`", db.getConnetion());

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                if (checkBoxFull.Checked != true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `sales` WHERE sales.id = @tI", db.getConnetion());
                    commandEmployee.Parameters.Add("@tI", MySqlDbType.Int32).Value = textBoxId.Text;

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
            }
            if (checkBoxOrder.Checked == true)
            {
                if (checkBoxFull.Checked == true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `orders`", db.getConnetion());

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                if (checkBoxFull.Checked != true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `orders` WHERE orders.id = @tI", db.getConnetion());
                    commandEmployee.Parameters.Add("@tI", MySqlDbType.Int32).Value = textBoxId.Text;

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
            }
            if (checkBoxEmployee.Checked == true)
            {
                if (checkBoxFull.Checked == true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `employees`", db.getConnetion());

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                if (checkBoxFull.Checked != true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `employees` WHERE employees.id = @tI", db.getConnetion());
                    commandEmployee.Parameters.Add("@tI", MySqlDbType.Int32).Value = textBoxId.Text;

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
            }
            if (checkBoxCustomers.Checked == true)
            {
                if (checkBoxFull.Checked == true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `customers`", db.getConnetion());

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                if (checkBoxFull.Checked != true)
                {
                    MySqlCommand commandEmployee = new MySqlCommand("DELETE FROM `customers` WHERE customers.id = @tI", db.getConnetion());
                    commandEmployee.Parameters.Add("@tI", MySqlDbType.Int32).Value = textBoxId.Text;

                    adapterEmployee.SelectCommand = commandEmployee;
                    adapterEmployee.Fill(tableEmployee);

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
            }
        }

        private void textBoxId_Leave(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                textBoxId.Text = "Введите номер строки";
                textBoxId.ForeColor = Color.Gray;
            }
        }

        private void textBoxId_Enter(object sender, EventArgs e)
        {
            if (textBoxId.Text == "Введите номер строки")
            {
                textBoxId.Text = "";
                textBoxId.ForeColor = Color.Black;
            }
        }

        private void ArrowBackLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminform = new AdminForm();
            adminform.Show();
        }

        private void ArrowBackLabel_MouseEnter(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.Gray;
        }

        private void ArrowBackLabel_MouseLeave(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.White;
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
    }
}
