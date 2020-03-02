using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServiceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyWebService.CalculatorServiceSoapClient client = new MyWebService.CalculatorServiceSoapClient();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResult.Text = client.Add(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtResult.Text = client.Sub(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtResult.Text = client.Mul(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtResult.Text = client.Div(Convert.ToDecimal(txtA.Text), Convert.ToDecimal(txtB.Text)).ToString();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(client.Message(), "Message Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
