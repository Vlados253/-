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
    public partial class RedactorEmployeeForm : Form
    {
        DB db = new DB();

        DataTable tableEmployee = new DataTable();
        DataTable tableEmployee2 = new DataTable();

        MySqlDataAdapter adapterEmployee = new MySqlDataAdapter();
        public RedactorEmployeeForm()
        {
            InitializeComponent();

            orderId.Text = "Введите уникальный номер заказа";
            orderId.ForeColor = Color.Gray;
            quantityBox.Text = "Введите колличество заказанного инструмента";
            quantityBox.ForeColor = Color.Gray;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime.Now.ToString("yyyy’-‘MM’-‘dd’ ’HH’:’mm’:’ss");
        }
        private void orderId_Enter(object sender, EventArgs e)
        {
            if (orderId.Text == "Введите уникальный номер заказа")
            {
                orderId.Text = "";
                orderId.ForeColor = Color.Black;
            }
        }
        private void orderId_Leave(object sender, EventArgs e)
        {
            if (orderId.Text == "")
            {
                orderId.Text = "Введите уникальный номер заказа";
                orderId.ForeColor = Color.Gray;
            }
        }
        private void buttonRedactor_Click(object sender, EventArgs e)
        {
            String orderid = orderId.Text;
            String orderstatus = "In process";
            String orderfinish = "Finished";
            String orderquantity = quantityBox.Text;

            if (orderId.Text == "Введите уникальный номер заказа") 
            {
                MessageBox.Show("Введите уникальный номер заказа!");
                return;
            }
            if (orderId.Text == "Введите колличество заказанного инструмента")
            {
                MessageBox.Show("Введите колличество заказанного инструмента!");
                return;
            }
            if (checkBox.Checked == true) 
            {
                MySqlCommand commandEmployee = new MySqlCommand("SELECT orders.status, orders.quantity FROM `orders` WHERE orders.id = @oI AND orders.status = @iP AND orders.quantity = @qB", db.getConnetion());
                commandEmployee.Parameters.Add("@oI", MySqlDbType.Int32).Value = orderid;
                commandEmployee.Parameters.Add("@iP", MySqlDbType.VarChar).Value = orderstatus;
                commandEmployee.Parameters.Add("@qB", MySqlDbType.Int32).Value = orderquantity;

                adapterEmployee.SelectCommand = commandEmployee;
                adapterEmployee.Fill(tableEmployee);

                if (tableEmployee.Rows.Count > 0)
                {
                    MySqlCommand commandEmployee2 = new MySqlCommand("UPDATE orders SET orders.status = @oF WHERE orders.id = @oI", db.getConnetion());
                    commandEmployee2.Parameters.Add("@oI", MySqlDbType.Int32).Value = orderid;
                    commandEmployee2.Parameters.Add("@oF", MySqlDbType.VarChar).Value = orderfinish;

                    adapterEmployee.SelectCommand = commandEmployee2;
                    adapterEmployee.Fill(tableEmployee);

                    MySqlCommand commandEmployee3 = new MySqlCommand("INSERT INTO `sales` (instrument_name, quantity, cost, itogo, date) VALUES ((SELECT instrument_name FROM `orders` WHERE orders.id = @oI),(SELECT quantity FROM `orders` WHERE orders.id = @oI),(SELECT cost FROM `orders` WHERE orders.id = @oI),(SELECT itogo FROM `orders` WHERE orders.id = @oI),@sD)", db.getConnetion());
                    commandEmployee3.Parameters.Add("@oI", MySqlDbType.Int32).Value = orderid;
                    commandEmployee3.Parameters.Add("@sD", MySqlDbType.Datetime).Value = dateTimePicker1.Value;

                    adapterEmployee.SelectCommand = commandEmployee3;
                    adapterEmployee.Fill(tableEmployee);

                    MySqlCommand commandEmployee4 = new MySqlCommand("UPDATE musical_instruments SET musical_instruments.quantity = musical_instruments.quantity - @qB WHERE musical_instruments.instrument_name = (SELECT orders.instrument_name FROM `orders` WHERE orders.id = @oI)", db.getConnetion());
                    commandEmployee4.Parameters.Add("@oI", MySqlDbType.Int32).Value = orderid;
                    commandEmployee4.Parameters.Add("@qB", MySqlDbType.Int32).Value = orderquantity;

                    adapterEmployee.SelectCommand = commandEmployee4;
                    adapterEmployee.Fill(tableEmployee);

                    MySqlCommand commandEmployee5 = new MySqlCommand("UPDATE spisok SET spisok.quantity = spisok.quantity + @qB WHERE spisok.instrument_name = (SELECT orders.instrument_name FROM `orders` WHERE orders.id = @oI)", db.getConnetion());
                    commandEmployee5.Parameters.Add("@oI", MySqlDbType.Int32).Value = orderid;
                    commandEmployee5.Parameters.Add("@qB", MySqlDbType.Int32).Value = orderquantity;

                    adapterEmployee.SelectCommand = commandEmployee5;
                    adapterEmployee.Fill(tableEmployee2);

                    if (tableEmployee2.Rows.Count > 0) 
                    {
                        MessageBox.Show("Данные изменены");
                        this.Hide();
                    }
                    if (tableEmployee2.Rows.Count < 1)
                    {
                        MySqlCommand commandEmployee6 = new MySqlCommand("INSERT INTO `spisok` (instrument_name, quantity) VALUES ((SELECT instrument_name FROM `orders` WHERE orders.id = @oI),(SELECT quantity FROM `orders` WHERE orders.id = @oI))", db.getConnetion());
                        commandEmployee6.Parameters.Add("@oI", MySqlDbType.Int32).Value = orderid;

                        adapterEmployee.SelectCommand = commandEmployee6;
                        adapterEmployee.Fill(tableEmployee);

                        MessageBox.Show("Данные изменены");
                        this.Hide();
                    }
                }
                if (tableEmployee.Rows.Count < 1) 
                {
                    MessageBox.Show("Заказа с таким уникальным номером нет!");
                    return;
                }
            }
            if (checkBox.Checked == false) 
            {
                MessageBox.Show("Поставьте галочку!");
                return;
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void ArrowBackLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ArrowBackLabel_MouseEnter(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.Gray;
        }

        private void ArrowBackLabel_MouseLeave(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.White;
        }

        private void quantityBox_Enter(object sender, EventArgs e)
        {
            if (quantityBox.Text == "Введите уникальный номер заказа")
            {
                quantityBox.Text = "";
                quantityBox.ForeColor = Color.Black;
            }
        }

        private void quantityBox_Leave(object sender, EventArgs e)
        {
            if (quantityBox.Text == "")
            {
                quantityBox.Text = "Введите уникальный номер заказа";
                quantityBox.ForeColor = Color.Gray;
            }
        }
    }
}
