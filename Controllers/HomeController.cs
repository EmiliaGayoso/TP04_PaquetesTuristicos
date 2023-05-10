using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquetes= ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {
        ViewBag.Destinos=ORTWorld.ListaDestinos;
        ViewBag.Aerolineas=ORTWorld.ListaAereos;
        ViewBag.Hoteles=ORTWorld.ListaHoteles;
        ViewBag.Excursiones=ORTWorld.ListaExcursiones;
        return View();
    }
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    {
        if(Destino>0 && Hotel>0 && Aereo>0 && Excursion>0)
        {
            Paquete i = new Paquete(Hotel, Aereo, Excursion);
        }

    }

}
