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
    public void MensajeError()
    {
        ViewBag.MensajeError="Datos erroneos. Ingrese nuevamente";

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
            MensajeError();
            CargarListas();
            return View("SelectPaquete");
        }
    }
    public IActionResult EliminarPaquete(string destino)
    {
        ORTWorld.Paquetes.Remove(destino);
        return RedirectToAction("Index");
    }
    public void CargarListas()
    {
        ViewBag.Destinos=ORTWorld.ListaDestinos;
        ViewBag.Aerolineas=ORTWorld.ListaAereos;
        ViewBag.Hoteles=ORTWorld.ListaHoteles;
        ViewBag.Excursiones=ORTWorld.ListaExcursiones;
    }
}