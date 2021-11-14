using Examen_SegundoParcial.Entidades;
using Examen_SegundoParcial.Modelos.DAO;
using Examen_SegundoParcial.Vistas;
using System;


namespace Examen_SegundoParcial.Controladores
{
    public class DetalleController
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        Usuario user = new Usuario();
        DetallesView vistas;

        public DetalleController(DetallesView view)
        {
            vistas = view;
            
            vistas.Load += new EventHandler(Detalle);
        }


        private void Detalle(object sender, EventArgs e)
        {
            ListarDetalle();
        }


        private void ListarDetalle()
        {
            vistas.dataGridViewDetalle.DataSource = usuarioDao.Detalle();
        }

    }
}
