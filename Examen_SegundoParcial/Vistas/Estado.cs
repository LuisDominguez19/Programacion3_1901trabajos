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
    public partial class Estado : Form
    {
        public Estado()
        {
            InitializeComponent();
            
            EstadoController controller = new EstadoController(this);

        }

       

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Estado estado = new Estado();
        }
    }
}
