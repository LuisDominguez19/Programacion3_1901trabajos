using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_SegundoParcial.Entidades
{
    public class Usuario
    {
        public int ID  { get; set; }
        public string Nombre { get; set; }
        public string EMAIL { get; set; }

        public string CLAVE { get; set; }

        public String Estado  { get; set; }

   

        public String  Telefono { get; set; }

         public string TipoMantenimiento { get; set; }

        public  int Precio { get; set; }

        public int Ticket { get; set; }

    }
}
