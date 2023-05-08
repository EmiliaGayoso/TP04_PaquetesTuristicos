class ORTWorld
{
    public static  List<string> ListaDestinos {get; private set;}= new List<string>(){"Catamarca","Tucuman","Formosa", "Salta","Santa Fe","Rio Negro","Mendoza","Cordoba","Tierra del Fuego","Neuquen"};
    public static List<string> ListaHoteles {get; private set;}= new List<string>(){"American Park Hotel", "Sheranton","Howard Johnson", "Alejandro I","InterTower","MonteCarlo","Diplomatic", "Amerian","Cilene del Faro","Hilton Garden"};
    public static List<string> ListaAereos {get; private set;}= new List<string>(){"Aerolineas Argentina", "GOL","Latam","FlyBondi","JetSmart","Emirates","American Airline","Andes","Azul","Austral"};
    public static List<string> ListaExcursiones {get; private set;}=new List<string>(){"Sky","Caminata Montaña","Ferias","Taller de pintura","Culipatin","PaintBall","Tiroleza", "Degustacion de Vino","Museos","Shopping"};
    public static SortedDictionary<string, Paquete> Paquetes {get; private set;}

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        return Paquetes.ContainsKey(destinoSeleccionado);
        if(!Paquetes.ContainsKey(destinoSeleccionado))
        Paquetes.Add(destinoSeleccionado,paquete);
        
    }
}