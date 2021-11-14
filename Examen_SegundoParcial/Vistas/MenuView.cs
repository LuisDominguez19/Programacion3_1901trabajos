using Examen_SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen_SegundoParcial.Vistas;

namespace Examen_SegundoParcial.Vistas
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        //private void ribbonControlAdv1_Click(object sender, EventArgs e)
        

        

        private void btnmantenimiento_Click(object sender, EventArgs e)
        {
            Tipos users = new Tipos();
            users.Show();
        }

        //private void toolStripButton2_Click(object sender, EventArgs e)
        
            
        

        private void Btntickets_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Tickets users = new Tickets();
            users.Show();
        }

        private void btnestados_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Estado users = new Estado();
            users.Show();

        }

        private void btnDetalle_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DetallesView users = new DetallesView();
            users.Show();
        }

        
    }
}
