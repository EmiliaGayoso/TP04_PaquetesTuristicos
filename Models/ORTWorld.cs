class ORTWorld
{
    public static  List<string> ListaDestinos {get; private set;}= new List<string>(){"Catamarca","Tucuman","Formosa", "Salta","Santa Fe","Rio Negro","Mendoza","Cordoba","Tierra del Fuego","Neuquen"};
    public static List<string> ListaHoteles {get; private set;}= new List<string>(){"hotel1.jfif", "hotel2.jfif","hotel3.jfif", "hotel4.jfif","hotel5.jfif","hotel6.jfif","hotel7.jfif", "hotel8.jfif","hotel9.jpg","hotel10.jfif"};
    public static List<string> ListaAereos {get; private set;}= new List<string>(){"aero1.jpg", "aero2.jfif","aero3.jfif","aero4.jfif","aero5.jfif","aero6.jfif","aero7.jfif","aero8.jfif","aero9.jfif","aero10.jfif"};
    public static List<string> ListaExcursiones {get; private set;}=new List<string>(){"exc1.jpg","exc2.jpg","exc3.jpg","exc4.jpg","exc5.jpg","exc6.jpg","exc7.jpg", "exc8.jpg","exc9.jpg","exc10.jpg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}=new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        
        if(!Paquetes.ContainsKey(destinoSeleccionado))
        Paquetes.Add(destinoSeleccionado,paquete);
        return Paquetes.ContainsKey(destinoSeleccionado);
    }
}