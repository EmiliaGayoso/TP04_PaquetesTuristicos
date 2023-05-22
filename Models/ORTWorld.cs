class ORTWorld
{
    public static  List<string> ListaDestinos {get; private set;}= new List<string>(){"Catamarca","Tucuman","Formosa", "Salta","Santa Fe","Rio Negro","Mendoza","Cordoba","Tierra del Fuego","Neuquen"};
    public static List<string> ListaHoteles {get; private set;}= new List<string>(){"hotel1.jpg", "hotel2.jpg","hotel3.jpg", "hotel4.jpg","hotel5.jpg","hotel6.jpg","hotel7.jpg", "hotel8.jpg","hotel9.jpg","hotel10.jpg"};
    public static List<string> ListaAereos {get; private set;}= new List<string>(){"aero1.jpg", "aero2.jpg","aero3.jpg","aero4.jpg","aero5.jpg","aero6.jpg","aero7.jpg","aero8.jpg","aero9.jpg","aero10.jpg"};
    public static List<string> ListaExcursiones {get; private set;}=new List<string>(){"exc1.jpg","exc2.jpg","exc3.jpg","exc4.jpg","exc5.jpg","exc6.jpg","exc7.jpg", "exc8.jpg","exc9.jpg","exc10.jpg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}=new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        
        if(!Paquetes.ContainsKey(destinoSeleccionado))
        Paquetes.Add(destinoSeleccionado,paquete);
        return Paquetes.ContainsKey(destinoSeleccionado);
    }
}