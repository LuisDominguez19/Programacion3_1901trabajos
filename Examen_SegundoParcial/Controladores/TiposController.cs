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
    
    public class TiposController
    {
        string Operacion = String.Empty;
        Tipos Vistas;

       public TiposController (Tipos view)
        {
            Vistas = view;
            Vistas.btnNuevo.Click += new EventHandler(Nuevo);
            Vistas.btnguardar.Click += new EventHandler(Guardar);
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarBotones();

            Operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (Vistas.TextNombre.Text == "")
            {
                Vistas.errorProvider1.SetError(Vistas.TextNombre, "Ingrese un nombre");
                Vistas.TextNombre.Focus();
                return;
            }


            if (Vistas.textTelf.Text == "")
            {
                Vistas.errorProvider1.SetError(Vistas.textTelf, "Ingrese un Numero de telefono");
                Vistas.textTelf.Focus();
                return;
            }

            if (Vistas.comboBoxNombre.Text == "")
            {
                Vistas.errorProvider1.SetError(Vistas.comboBoxNombre, "Selecciones un tipo de mantenimiento ");
                Vistas.comboBoxNombre.Focus();
                return;
            }

            UsuarioDao usuarioDao = new UsuarioDao();
            Usuario user = new Usuario();
            //user.TipoMantenimiento  = vistas.comboBox1.;
            user.Nombre = Vistas.TextNombre.Text;
            user.Telefono = (Vistas.textTelf.Text);

            if(Operacion == "Nuevo")
            {
                bool insert = usuarioDao.RegistrarNuevoUsuario(user);
            }
            
        }

        private void HabilitarBotones()
        {
            Vistas.TextNombre.Enabled = true;
            Vistas.textTelf.Enabled = true;
            Vistas.textprecio.Enabled = true;
            Vistas.comboBoxNombre.Enabled = true;
            Vistas.btnguardar.Enabled = true;
            Vistas.btnModificar.Enabled = true;
            Vistas.btnregresar.Enabled = false;
            Vistas.btnNuevo.Enabled = false;
        }
    }
}
