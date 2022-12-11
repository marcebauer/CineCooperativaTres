using CooperativaTres.Context;
using CooperativaTres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CineDatabaseContext _context;

        public HomeController(ILogger<HomeController> logger, CineDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Ingresar([Bind("Email","Password")] Usuario usuario)
        {
            if (!_context.Usuarios.Any(u => u.Email == usuario.Email && u.Password == usuario.Password))
            {
                return RedirectToAction("Login");
            }
            HttpContext.Session.SetString("Usuario", usuario.Email);
            return RedirectToAction("Index");
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear([Bind("Nombre","Apellido","Email","Password","FechaDeNacimiento")] Usuario usuario)
        {
            if(_context.Usuarios.Any(u => u.Email == usuario.Email))
            {
                return RedirectToAction("Crear");
            }
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            HttpContext.Session.SetString("Usuario", usuario.Email);
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> ActualizarPerfil()
        {
            string email = HttpContext.Session.GetString("Usuario");
            int id = _context.Usuarios.Where(e => e.Email == email).FirstOrDefault().Id;
            var usuario = await _context.Usuarios.FindAsync(id);
            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> ActualizarPerfil([Bind("Id","Nombre", "Apellido", "Email", "Password", "FechaDeNacimiento")] Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
            return View(usuario);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}