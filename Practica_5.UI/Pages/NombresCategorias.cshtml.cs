using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica_5.Core;
using Practica_5.Data;

namespace Practica_5.UI.Pages
{
    public class NombresCategoriasModel : PageModel
    {
        private readonly IProductoRepositorio productoRepositorio;
        [BindProperty]
        public Producto Producto { get; set; }
        [BindProperty]
        public List<Producto> Productos { get; set; }
        [BindProperty]
        public Categoria Categoria { get; set; }
        [BindProperty]
        public List<Categoria> Categorias { get; set; }

        public NombresCategoriasModel(IProductoRepositorio productoRepositorio)
        {
            this.productoRepositorio = productoRepositorio;
        }
        public void OnGet()
        {
           this.Productos = productoRepositorio.ObtenerCategorias().ToList();
        }
    }
}
