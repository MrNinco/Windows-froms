using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Indexlogin : Form
    {
        public Indexlogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register FR = new Register();
            FR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserDAL.AuthenticationLogin(email.Text, password.Text) > 0)
            {
                this.Hide();

                Indexlogin IL = new Indexlogin();

                IL.ShowDialog();
            }
            else
            {
                MessageBox.Show("Compruebe sus datos");
            }
        }
    }
}
