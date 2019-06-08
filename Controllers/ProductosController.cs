using System.Linq;
using ropa.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ropa.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private TiendaContext _context { get; }

        public ProductosController(TiendaContext context) {
            _context = context;
        }

        public IActionResult Listar()
        {
            var productos = _context.Productos.ToList();

            return View(productos);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Producto p)
        {
            if (ModelState.IsValid) {
                _context.Productos.Add(p);
                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }

        public IActionResult Actualizar(int id)
        {
            var p = _context.Productos.FirstOrDefault(x => x.Id == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(Producto p)
        {
            if (ModelState.IsValid) {
                var productoBd = _context.Productos.Find(p.Id);

                productoBd.Nombre = p.Nombre;
                productoBd.PrecioC = p.PrecioC;
                productoBd.Foto = p.Foto;

                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }

        public IActionResult Borrar(int id)
        {
            var p = _context.Productos.FirstOrDefault(x => x.Id == id);

            if (p != null) {
                _context.Productos.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}