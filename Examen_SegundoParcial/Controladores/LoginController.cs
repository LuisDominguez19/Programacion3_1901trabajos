using Examen_SegundoParcial.Entidades;
using Examen_SegundoParcial.Modelos.DAO;
using Examen_SegundoParcial.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examen_SegundoParcial.Controladores
{
    public class LoginController
    {
        LoginView vista;

        
        public LoginController(LoginView view)
        {
            vista = view;
            vista.btnAceptar.Click += new EventHandler(ValidarUsuario);
        }

        //Creación de Método Para validar si el usuario ingresado es correcto:
        public void ValidarUsuario(object serder, EventArgs e)
        {
            UsuarioDao userDao = new UsuarioDAO();
            Usuario user = new Usuario();
            user.EMAIL = vista.textemail.Text;
            user.CLAVE = vista.textcontra.Text;

            // user.Clave = EncriptarClave(vista.textcontra.Text);

            bool valido = userDao.ValidarUsuario(user);
            if (valido)
            {
                MessageBox.Show("Usuario Correcto");
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }

    internal class UsuarioDAO : UsuarioDao
    {
    }
}
