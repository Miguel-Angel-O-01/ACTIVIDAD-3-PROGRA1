using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACusercontrol
{
    public partial class Usercontrol : Form
    {
        public Usercontrol()
        {
            InitializeComponent();
        }

        // Abrir formulario para resetear contraseña
        private void Lnkpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Resetpassword resetpassword = new Resetpassword();
            resetpassword.Show();
            this.Hide();
        }

        // Validar usuario y contraseña
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Primero validar que los campos no estén vacíos
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string user = txbxuser.Text;
            string password = txbxpassword.Text;

            if (user == "progra1" && password == "admin1620")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar campos
        private void btnclean_Click(object sender, EventArgs e)
        {
            txbxuser.Clear();
            txbxpassword.Clear();
            err_user.SetError(txbxuser, "");
            err_password.SetError(txbxpassword, "");
        }

        // Validar campo usuario
        private void txbxuser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbxuser.Text))
            {
                e.Cancel = true;
                txbxuser.Focus();
                err_user.SetError(txbxuser, "Ingrese su usuario");
            }
            else
            {
                e.Cancel = false;
                err_user.SetError(txbxuser, "");
            }
        }


        private void txbxpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbxpassword.Text))
            {
                e.Cancel = true;
                txbxpassword.Focus();
                err_password.SetError(txbxpassword, "Ingrese su contraseña");
            }
            else
            {
                e.Cancel = false;
                err_password.SetError(txbxpassword, "");
            }
        }
    }
}
