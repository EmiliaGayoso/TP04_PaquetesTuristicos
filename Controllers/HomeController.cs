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
        CargarListas();
        return View();
    }
    public IActionResult GuardarPaquete (int destino, int hotel, int aereo, int excursion)
    {
        if(destino>=0 && hotel>0 && aereo>0 && excursion>0)
        {
            Paquete i = new Paquete(ORTWorld.ListaHoteles[hotel-1],ORTWorld.ListaAereos[aereo-1],ORTWorld.ListaExcursiones[excursion-1]);
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[destino],i);
            return RedirectToAction("Index");
        }
        else
        {
            Console.WriteLine("Datos Erroneos");
            CargarListas();
            return View("SelectPaquete");
        }
    }
    public void CargarListas()
    {
        ViewBag.Destinos=ORTWorld.ListaDestinos;
        ViewBag.Aerolineas=ORTWorld.ListaAereos;
        ViewBag.Hoteles=ORTWorld.ListaHoteles;
        ViewBag.Excursiones=ORTWorld.ListaExcursiones;
    }

}
