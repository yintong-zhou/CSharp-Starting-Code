using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace httpRequest
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRequest_Click(object sender, EventArgs e)
        {
            http conn = new http();
            var httpResponse = conn.PageAsync();
            textBox1.Text = await httpResponse;
        }
    }
}
