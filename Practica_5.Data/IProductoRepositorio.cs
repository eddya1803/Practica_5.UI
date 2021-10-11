using Practica_5.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Data
{
    public interface IProductoRepositorio
    {
        public IEnumerable<Producto> ObtenerTodos();

        public IEnumerable<Producto> ObtenerPorCategoria(int id);

        public IEnumerable<Producto> ObtenerPrecio();

        public IEnumerable<Producto> ObtenerCategorias();
    }
}
