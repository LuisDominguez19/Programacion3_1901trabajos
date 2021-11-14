using Examen_SegundoParcial.Entidades;
using Examen_SegundoParcial.Modelos.DAO;
using Examen_SegundoParcial.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_SegundoParcial.Controladores
{
    public class EstadoController
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        Usuario user = new Usuario();
        Estado vistas;

        public EstadoController(Estado view)
        {
            vistas = view;
            vistas.btnMostrar.Click += new EventHandler(Estado);
            vistas.Load += new EventHandler(Estado);
        }


        private void Estado(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            vistas.dataGridViewEstados.DataSource = usuarioDao.Estado();
        }

        private void Load(object sender, EventArgs e)
        {
            ListarEstado();
        }
        private void ListarEstado()
        {
            vistas.dataGridViewEstados.DataSource = usuarioDao.Estado();
        }


    }
}
