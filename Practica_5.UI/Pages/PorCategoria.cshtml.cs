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
    public class PorCategoriaModel : PageModel
    {
        private readonly IProductoRepositorio productoRepositorio;

        [BindProperty]
        public Producto Producto { get; set; }
        [BindProperty]
        public int Codigo { get; set; }
        [BindProperty]
        public List<Producto> Productos { get; set; }

        public PorCategoriaModel(IProductoRepositorio productoRepositorio)
        {
            this.productoRepositorio = productoRepositorio;
        }
        public  void OnGet()
        {
            Productos = new List<Producto>();
        }
        public ActionResult OnPost(int id )
        {
            this.Productos = productoRepositorio.ObtenerPorCategoria(id).ToList();
            return Productos == null ? RedirectToPage("./NoAparece") : Page();
        }
    }
}
 