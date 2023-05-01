using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
   public class Categoria
    {
        [DisplayName("Número")]
        public int ID { get; set; }
        public string Descripcion { get; set; }

    }
}
