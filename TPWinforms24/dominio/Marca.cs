using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        [DisplayName("Número")]
        public int Id { get; set; }
<<<<<<< HEAD
        public string Descripcion { get; set; }
=======
        public int IdArticulo { get; set; }
        public string ImagenUrl { get; set; }
>>>>>>> b04cdff225b4fbcebe1bba8f072515a6ff95ce33
    }
}
