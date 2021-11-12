using Examen_SegundoParcial.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_SegundoParcial.Vistas
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            LoginController controlador = new LoginController(this);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
