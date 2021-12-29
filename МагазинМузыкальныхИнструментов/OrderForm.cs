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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
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
    }
}
