using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp02.Models;

namespace Tp02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult GenerarSugerencia(SugeridorReceta datos){
        ViewBag.plato = datos.DeterminarPlato();
        ViewBag.tiempo = datos.CalcularTiempo();
        ViewBag.dificultad = datos.DeterminarDificultad();
        ViewBag.edad = datos.CalcularEdad();
        ViewBag.nombre = datos.nombreCocinero; 
        ViewBag.cantidadComensales = datos.cantidadComensales;
        return View();
    }
}
