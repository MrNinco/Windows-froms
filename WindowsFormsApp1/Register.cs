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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Indexlogin IR = new Indexlogin();
            IR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserDAL.NewUser(name.Text, lastname.Text, email.Text, phone_number.Text, town.Text, address.Text, password.Text) > 0)
            {
                MessageBox.Show("Se registro con éxito");
            }
            else MessageBox.Show("Error en el registro");
        }
    }
}
