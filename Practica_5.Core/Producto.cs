using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Core
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int categoriaId { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public double precio { get; set; }

    }
}
