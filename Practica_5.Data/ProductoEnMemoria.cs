using Practica_5.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Data
{
    public class ProductoEnMemoria : IProductoRepositorio
    {
        public Producto Producto { get; set; }
        public Categoria Categoria { get; set; }

        List<Producto> productos;
        List<Categoria> categorias;

        public ProductoEnMemoria()
        {
            Producto = new Producto();
            Categoria = new Categoria();

            productos = new List<Producto>()
            {
                new Producto(){id = 1, nombre = "Nevera", categoriaId = 1, marca = "Nedoca", modelo = "CJ2015", precio = 6500.75},
                new Producto(){id = 2, nombre = "Televisor", categoriaId = 1, marca = "LG", modelo = "Mk2019", precio = 3720.45},
                new Producto(){id = 3, nombre = "Comedor", categoriaId = 2, marca = "Seneca", modelo = "LF2018", precio = 3890.10},
                new Producto(){id = 4, nombre = "Bañera", categoriaId = 3, marca = "Kalua", modelo = "PR2020", precio = 2400.25},
                new Producto(){id = 5, nombre = "Lava manos", categoriaId = 3, marca = "Corona", modelo = "BE2014", precio = 1680.75},
                new Producto(){id = 6, nombre = "Cama dormitorio", categoriaId = 2, marca = "Selly", modelo = "YT2017", precio = 3210.45},
                new Producto(){id = 7, nombre = "Pintura", categoriaId = 4, marca = "Popular", modelo = "DJ2010", precio = 1450.85},
                new Producto(){id = 8, nombre = "Pantalones", categoriaId = 5, marca = "Lee", modelo = "KF2018", precio = 1100.20},
                new Producto(){id = 9, nombre = "Martillo", categoriaId = 4, marca = "Stanly", modelo = "PT2011", precio = 2430.52},
                new Producto(){id = 10, nombre = "Vestido", categoriaId = 5, marca = "Sarah", modelo = "DN2019", precio = 3675.25}
            };

            categorias = new List<Categoria>()
            {
                new Categoria(){id = 1, nombre = "Electrodomesticos"},
                new Categoria(){id = 2, nombre = "Hogar"},
                new Categoria(){id = 3, nombre = "Plomeria"},
                new Categoria(){id = 4, nombre = "Ferreteria"},
                new Categoria(){id = 5, nombre = "Vestimenta"}
            };

        }
        public IEnumerable<Producto> ObtenerTodos()
        {
            return productos;
        }
        public IEnumerable<Producto> ObtenerPorCategoria(int id)
        {
            var resultado = from fila in productos
                            where id == fila.categoriaId
                            select fila;
            return resultado;
        }


        public IEnumerable<Producto> ObtenerPrecio()
        {
            var rango = from f in productos
                        where f.precio >= 3000.00 && f.precio <= 5000.00
                        select f;
            return rango;
        }


        public IEnumerable<Producto> ObtenerCategorias()
        {
            var catego = from p in productos
                         join c in categorias on p.categoriaId equals c.id
                         orderby c descending
                         select p;
            return catego;

        }
    }
}
