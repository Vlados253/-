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
    public partial class InsertForm : Form
    {
        DB db = new DB();

        DataTable tableEmployee = new DataTable();

        MySqlDataAdapter adapterEmployee = new MySqlDataAdapter();    
        public InsertForm()
        {
            InitializeComponent();

            instrumentName.Text = "Введите название инструмента";
            instrumentName.ForeColor = Color.Gray;
            idDokum.Text = "Введите номер документа";
            idDokum.ForeColor = Color.Gray;
            namePostav.Text = "Введите название постащика";
            namePostav.ForeColor = Color.Gray;
            adressBox.Text = "Введите адрес постащика";
            adressBox.ForeColor = Color.Gray;
            quantityBox.Text = "Введите количество";
            quantityBox.ForeColor = Color.Gray;
            typeBox.Text = "Введите тип инструмента";
            typeBox.ForeColor = Color.Gray;
            costBox.Text = "Введите стоимость";
            costBox.ForeColor = Color.Gray;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime.Now.ToString("yyyy’-‘MM’-‘dd’ ’HH’:’mm’:’ss");
        }
        private void buttonRedactor_Click(object sender, EventArgs e)
        {
            MySqlCommand commandEmployee = new MySqlCommand("INSERT INTO receipts (instrument_name,id_dokument,name_postav,adress,quantity,cost,date,type) VALUES (@iN,@iD,@nP,@A,@Q,@C,@D,@T)", db.getConnetion());
            commandEmployee.Parameters.Add("@iN", MySqlDbType.VarChar).Value = instrumentName.Text;
            commandEmployee.Parameters.Add("@iD", MySqlDbType.Int32).Value = idDokum.Text;
            commandEmployee.Parameters.Add("@nP", MySqlDbType.VarChar).Value = namePostav.Text;
            commandEmployee.Parameters.Add("@A", MySqlDbType.VarChar).Value = adressBox.Text;
            commandEmployee.Parameters.Add("@Q", MySqlDbType.Int32).Value = quantityBox.Text;
            commandEmployee.Parameters.Add("@C", MySqlDbType.Int32).Value = costBox.Text;
            commandEmployee.Parameters.Add("@D", MySqlDbType.Datetime).Value = dateTimePicker1.Value;
            commandEmployee.Parameters.Add("@T", MySqlDbType.VarChar).Value = typeBox.Text;

            adapterEmployee.SelectCommand = commandEmployee;
            adapterEmployee.Fill(tableEmployee);

            MySqlCommand commandEmployee2 = new MySqlCommand("INSERT INTO musical_instruments (instrument_name,quantity,cost,type) VALUES (@iN,@Q,@C,@T)", db.getConnetion());
            commandEmployee2.Parameters.Add("@iN", MySqlDbType.VarChar).Value = instrumentName.Text;
            commandEmployee2.Parameters.Add("@Q", MySqlDbType.Int32).Value = quantityBox.Text;
            commandEmployee2.Parameters.Add("@C", MySqlDbType.Int32).Value = costBox.Text;
            commandEmployee2.Parameters.Add("@T", MySqlDbType.VarChar).Value = typeBox.Text;

            adapterEmployee.SelectCommand = commandEmployee2;
            adapterEmployee.Fill(tableEmployee);

            if (tableEmployee.Rows.Count < 1) 
            {
                MessageBox.Show("Данные добавлены");
                this.Hide();
                AdminForm adminform = new AdminForm();
                adminform.Show();
            }

            if (tableEmployee.Rows.Count > 0) 
                MessageBox.Show("Данные не добавлены!");
            
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

        private void ArrowBackLabel_MouseEnter(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.Gray;
        }

        private void ArrowBackLabel_MouseLeave(object sender, EventArgs e)
        {
            ArrowBackLabel.ForeColor = Color.White;
        }

        private void ArrowBackLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminform = new AdminForm();
            adminform.Show();
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

        private void instrumentName_Enter(object sender, EventArgs e)
        {
            if (instrumentName.Text == "Введите название инструмента")
            {
                instrumentName.Text = "";
                instrumentName.ForeColor = Color.Black;
            }
        }

        private void instrumentName_Leave(object sender, EventArgs e)
        {
            if (instrumentName.Text == "")
            {
                instrumentName.Text = "Введите название инструмента";
                instrumentName.ForeColor = Color.Gray;
            }
        }

        private void idDokum_Enter(object sender, EventArgs e)
        {
            if (idDokum.Text == "Введите номер документа")
            {
                idDokum.Text = "";
                idDokum.ForeColor = Color.Black;
            }
        }

        private void idDokum_Leave(object sender, EventArgs e)
        {
            if (idDokum.Text == "")
            {
                idDokum.Text = "Введите номер документа";
                idDokum.ForeColor = Color.Gray;
            }
        }

        private void namePostav_Enter(object sender, EventArgs e)
        {
            if (namePostav.Text == "Введите название постащика")
            {
                namePostav.Text = "";
                namePostav.ForeColor = Color.Black;
            }
        }

        private void namePostav_Leave(object sender, EventArgs e)
        {
            if (namePostav.Text == "")
            {
                namePostav.Text = "Введите название постащика";
                namePostav.ForeColor = Color.Gray;
            }
        }

        private void adressBox_Enter(object sender, EventArgs e)
        {
            if (adressBox.Text == "Введите адрес постащика")
            {
                adressBox.Text = "";
                adressBox.ForeColor = Color.Black;
            }
        }

        private void adressBox_Leave(object sender, EventArgs e)
        {
            if (adressBox.Text == "")
            {
                adressBox.Text = "Введите адрес постащика";
                adressBox.ForeColor = Color.Gray;
            }
        }

        private void quantityBox_Enter(object sender, EventArgs e)
        {
            if (quantityBox.Text == "Введите количество")
            {
                quantityBox.Text = "";
                quantityBox.ForeColor = Color.Black;
            }
        }

        private void quantityBox_Leave(object sender, EventArgs e)
        {
            if (quantityBox.Text == "")
            {
                quantityBox.Text = "Введите количество";
                quantityBox.ForeColor = Color.Gray;
            }
        }

        private void typeBox_Enter(object sender, EventArgs e)
        {
            if (typeBox.Text == "Введите тип инструмента")
            {
                typeBox.Text = "";
                typeBox.ForeColor = Color.Black;
            }
        }

        private void typeBox_Leave(object sender, EventArgs e)
        {
            if (typeBox.Text == "")
            {
                typeBox.Text = "Введите тип инструмента";
                typeBox.ForeColor = Color.Gray;
            }
        }

        private void costBox_Enter(object sender, EventArgs e)
        {
            if (costBox.Text == "Введите стоимость")
            {
                costBox.Text = "";
                costBox.ForeColor = Color.Black;
            }
        }

        private void costBox_Leave(object sender, EventArgs e)
        {
            if (costBox.Text == "")
            {
                costBox.Text = "Введите стоимость";
                costBox.ForeColor = Color.Gray;
            }
        }
    }

}
