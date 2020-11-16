using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRGtaak
{
    public partial class Slip : Form
    {
        public Slip()
        {
            InitializeComponent();
        }

        private void Slip_Load(object sender, EventArgs e)
        {
            txtTotal.Text = Standard.setvalue; 
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
           var sd =  txtTotal.Text.Remove(0, 2);
           sd =  sd.Replace(',', '.');
            var total = double.Parse(sd);
            var Change=   double.Parse(txtPayment.Text) - total;
            lblchange.Text = Change.ToString("c");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Standard s = new Standard(); ;
            s.Show();
            this.Hide();
        }
    }
}
