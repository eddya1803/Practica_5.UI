using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Core
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Categoria> Categorias { get; set; }

    }
}
