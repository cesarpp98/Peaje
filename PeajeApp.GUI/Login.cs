using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeajeApp.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getUsername();
        }

        private void getUsername()
        {
            if (txtusu.Text == "user")
            {
                getPassword();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos Intente de Nuevo");
            }
        }

        private void getPassword()
        {
            if (txtpass.Text == "123")
            {
                PanelPrincipal panel = new PanelPrincipal();
                panel.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos Intente de Nuevo");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
