public  static class Juego{
   public  static  List<Palabra> ListaPalabras  {get; set;}
public static  List<Usuario> Jugadores { get; set;}
public   static Usuario JugadorActual {get; set;}

private static void LlenarListaPalabras(){
//Debe crear una lista con 40 palabras, 10 de cada dificultad (dificultades de 1 a 4).

        // 1 = Fácil
        ListaPalabras.Add(new Palabra { Texto = "GATO", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "PERRO", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "CASA", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "MESA", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "SOL", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "LUNA", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "LIBRO", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "PAN", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "AGUA", Dificultad = 1 });
        ListaPalabras.Add(new Palabra { Texto = "COCHE", Dificultad = 1 });

        // 2 = Medio
        ListaPalabras.Add(new Palabra { Texto = "VENTANA", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "SILLA", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "JARDIN", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "PLAYA", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "ZAPATO", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "CAMISA", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "MONTANA", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "RELOJ", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "ESCUELA", Dificultad = 2 });
        ListaPalabras.Add(new Palabra { Texto = "PUENTE", Dificultad = 2 });

        // 3 = Difícil
        ListaPalabras.Add(new Palabra { Texto = "AEROPUERTO", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "LABERINTO", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "CATEDRAL", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "MURCIELAGO", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "OCEANO", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "GUITARRA", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "HELICOPTERO", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "DINOSAURIO", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "ASTRONOMIA", Dificultad = 3 });
        ListaPalabras.Add(new Palabra { Texto = "PLANIFICACION", Dificultad = 3 });

        // 4 = Hardcore
        ListaPalabras.Add(new Palabra { Texto = "ANTICONSTITUCIONAL", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "OTORRINOLARINGOLOGO", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "ELECTROENCEFALOGRAMA", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "PARALELEPIPEDO", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "MICROSCOPICO", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "INCONSTITUCIONALIDAD", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "ESTERNOCLEIDOMASTOIDEO", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "ELECTRODOMESTICO", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "CARACTERIZACION", Dificultad = 4 });
        ListaPalabras.Add(new Palabra { Texto = "FITOSANITARIO", Dificultad = 4 });
}
}

public static void InicializarJuego(string usuario, int dificultad){
//inicializar todos los atributos privados de la clase que dan inicio el juego:
//CantidadIntentos en 0
//JugadorActual debe tener al usuario recibido.

}

public static string CargarPalabra(int dificultad){
//Retorna una palabra al azar de la lista de palabras según la dificultad recibida.
}

static void   FinJuego(int intentos){
// Debe guardar en la lista de usuarios al jugador que compitió con su cantidad de intentos.
}

static List<Usuario> DevolverListaUsuarios(){
// Retorna la lista de usuarios ordenada por los intentos de cada uno (de menor a mayor)

/*static void PalabraRandom(){
      
            Random rnd = new Random();
            int num = rnd.Next(0, listaPalabras.Count());
            Palabra = listaPalabras[num];

        }

        foreach(char i in Palabra){
            listaChar.Add('_');
*/
}
