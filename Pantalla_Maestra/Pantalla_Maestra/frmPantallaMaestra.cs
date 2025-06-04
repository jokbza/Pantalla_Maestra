using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Maestra
{
    public partial class frmPantallaMaestra : Form
    {
        public frmPantallaMaestra()
        {
            InitializeComponent();
        }

        public frmPantallaMaestra(string rol)
        {
            InitializeComponent();
            this.Text = "Login Exitoso. Rol: " + rol;
        }
    }
}