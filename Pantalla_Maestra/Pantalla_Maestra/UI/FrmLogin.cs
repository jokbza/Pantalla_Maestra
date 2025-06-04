using System;
using System.Windows.Forms;
using Pantalla_Maestra.DAL;
using Pantalla_Maestra;

namespace Pantalla_Maestra.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            UsuarioDAO usuarioDao = new UsuarioDAO();
            string rol = usuarioDao.ValidarCredenciales(usuario, contrasena);

            if (rol != null)
            {
                frmPantallaMaestra frmPrincipal = new frmPantallaMaestra(rol);
                frmPrincipal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente de nuevo.");
            }
        }
    }
}