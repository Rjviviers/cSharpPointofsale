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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            user log = new user(txtuser.Text, txtpass.Text);
            if (log.login())
            {
                Standard st = new Standard();
                st.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login details incorect");
                txtpass.Clear();
            }
        }
    }
}

