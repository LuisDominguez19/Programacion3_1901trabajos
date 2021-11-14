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
    public partial class DetallesView : Form
    {
        public DetallesView()
        {
            InitializeComponent();
            DetalleController controller = new DetalleController(this);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
