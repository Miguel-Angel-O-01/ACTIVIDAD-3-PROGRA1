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
    public partial class Resetpassword : Form
    {
        public Resetpassword()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(txbxnew.Text))
            {
                MessageBox.Show("Por favor, ingrese una nueva contraseña", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbxnew.Focus();
                return;
            }

            MessageBox.Show("Contraseña cambiada exitosamente", "Éxito",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresar al formulario de login (Usercontrol)
            Usercontrol loginForm = new Usercontrol();
            loginForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }
    }
}