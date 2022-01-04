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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();

            instrumentName.Text = "Введите название инструмента";
            instrumentName.ForeColor = Color.Gray;
            instrumentType.Text = "Введите тип инструмента";
            instrumentType.ForeColor = Color.Gray;
            instrumentQuantity.Text = "Введите количество";
            instrumentQuantity.ForeColor = Color.Gray;
            customerAdres.Text = "Введите ваш адрес";
            customerAdres.ForeColor = Color.Gray;
        }
        private void ArrowBackLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerform = new CustomerForm();
            customerform.Show();
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
        public void instrumentName_Enter(object sender, EventArgs e)
        {
            if (instrumentName.Text == "Введите название инструмента")
            {
                instrumentName.Text = "";
                instrumentName.ForeColor = Color.Black;
            }
        }
        public void instrumentName_Leave(object sender, EventArgs e)
        {
            if (instrumentName.Text == "")
            {
                instrumentName.Text = "Введите название инструмента";
                instrumentName.ForeColor = Color.Gray;
            }
        }
        private void instrumentType_Enter(object sender, EventArgs e)
        {
            if (instrumentType.Text == "Введите тип инструмента")
            {
                instrumentType.Text = "";
                instrumentType.ForeColor = Color.Black;
            }
        }
        private void instrumentType_Leave(object sender, EventArgs e)
        {
            if (instrumentType.Text == "")
            {
                instrumentType.Text = "Введите тип инструмента";
                instrumentType.ForeColor = Color.Gray;
            }
        }
        private void instrumentQuantity_Enter(object sender, EventArgs e)
        {
            if (instrumentQuantity.Text == "Введите количество")
            {
                instrumentQuantity.Text = "";
                instrumentQuantity.ForeColor = Color.Black;
            }
        }
        private void instrumentQuantity_Leave(object sender, EventArgs e)
        {
            if (instrumentQuantity.Text == "")
            {
                instrumentQuantity.Text = "Введите количество";
                instrumentQuantity.ForeColor = Color.Gray;
            }
        }
        private void instrumentAdres_Enter(object sender, EventArgs e)
        {
            if (customerAdres.Text == "Введите ваш адрес")
            {
                customerAdres.Text = "";
                customerAdres.ForeColor = Color.Black;
            }
        }
        private void instrumentAdres_Leave(object sender, EventArgs e)
        {
            if (customerAdres.Text == "")
            {
                customerAdres.Text = "Введите ваш адрес";
                customerAdres.ForeColor = Color.Gray;
            }
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
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (instrumentName.Text == "Введите название инструмента")
            {
                MessageBox.Show("Введите название инструмента!");
                return;
            }
            if (instrumentType.Text == "Введите тип инструмента")
            {
                MessageBox.Show("Введите тип инструмента!");
                return;
            }
            if (instrumentQuantity.Text == "Введите количество")
            {
                MessageBox.Show("Введите количество!");
                return;
            }
            if (customerAdres.Text == "Введите ваш адрес")
            {
                MessageBox.Show("Введите ваш адрес!");
                return;
            }
            String instrumentname = instrumentName.Text;
            String instrumenttype = instrumentType.Text;
            String instrumenquantity = instrumentQuantity.Text;
            String customeradress = customerAdres.Text;
            
            DB db = new DB();

            DataTable tableCustomer = new DataTable();
            DataTable tableCustomer2 = new DataTable();

            MySqlDataAdapter adapterCustomer = new MySqlDataAdapter();
            MySqlDataAdapter adapterCustomer2 = new MySqlDataAdapter();

            MySqlCommand commandCustomer = new MySqlCommand("SELECT * FROM `musical_instruments` WHERE musical_instruments.instrument_name = @iN AND musical_instruments.type = @iT AND musical_instruments.quantity >= @iQ", db.getConnetion());
            commandCustomer.Parameters.Add("@iN", MySqlDbType.VarChar).Value = instrumentname;
            commandCustomer.Parameters.Add("@iT", MySqlDbType.VarChar).Value = instrumenttype;
            commandCustomer.Parameters.Add("@iQ", MySqlDbType.Int32).Value = instrumenquantity;

            adapterCustomer.SelectCommand = commandCustomer;
            adapterCustomer.Fill(tableCustomer);

            if (tableCustomer.Rows.Count > 0)
            {
                MySqlCommand commandCustomer2 = new MySqlCommand("INSERT INTO `orders` (`instrument_name`, `type`, `quantity`,`adress`) VALUES (@iN,@iT,@iQ,@iA)", db.getConnetion());
                commandCustomer2.Parameters.Add("@iN", MySqlDbType.VarChar).Value = instrumentname;
                commandCustomer2.Parameters.Add("@iT", MySqlDbType.VarChar).Value = instrumenttype;
                commandCustomer2.Parameters.Add("@iQ", MySqlDbType.Int32).Value = instrumenquantity;
                commandCustomer2.Parameters.Add("@iA", MySqlDbType.VarChar).Value = customeradress;

                adapterCustomer2.SelectCommand = commandCustomer2;
                adapterCustomer2.Fill(tableCustomer2);

                this.Hide();
                PayForm payform = new PayForm();
                payform.Show();
            }
            if (tableCustomer.Rows.Count < 1)
                MessageBox.Show("Данные некорректны!");
        }
    }
}
