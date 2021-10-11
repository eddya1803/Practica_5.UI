using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Practica_5.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Practica_5.Data;

namespace Practica_5.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductoRepositorio productoRepositorio;

        [BindProperty]
        public List<Producto> Productos { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IProductoRepositorio productoRepositorio)
        {
            _logger = logger;
            this.productoRepositorio = productoRepositorio;

        }

        public void OnGet()
        {
            this.Productos = productoRepositorio.ObtenerTodos().ToList();
        }
    }
}
