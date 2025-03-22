namespace actividadN1POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear Objeto Libros
            Libros libro1 = new Libros();
            libro1.titulo = "1984";
            libro1.autor = "George Orwell";
            libro1.anioPublicacion = 1949;
            libro1.puntaje = "10/10";

            Libros libro2 = new Libros();
            libro2.titulo = "El señor de las moscas";
            libro2.autor = "William Golding";
            libro2.anioPublicacion = 1954;
            libro2.puntaje = "7.5/10";

            Libros libro3 = new Libros();
            libro3.titulo = "El Gran Gatsby";
            libro3.autor = "F. Scott Fitzgerald";
            libro3.anioPublicacion = 1925;
            libro3.puntaje = "8.5/10";

            //Array Libros
            Libros[] biblioteca = {libro1, libro2, libro3};

            //Mostrar Informacion
            for (int i = 0; i < biblioteca.Length; i++)
            {
                Console.WriteLine($"Libro {i + 1}:");
                biblioteca[i].MostrarInformacion(); //Acción 1 Libros
                Console.WriteLine();
            }

            libro1.LeerLibro(); //Acción 2 Libros

            Console.WriteLine();
            Console.WriteLine();

            //Crear Objeto Playlist
            Playlist cancion1 = new Playlist();
            cancion1.nomCancion = "Bohemian Rapsody";
            cancion1.artista = "Queen";
            cancion1.album = "A Night at the Opera";
            cancion1.releaseDate = 1975;

            Playlist cancion2 = new Playlist();
            cancion2.nomCancion = "Creep";
            cancion2.artista = "RadioHead";
            cancion2.album = "Pablo Head";
            cancion2.releaseDate = 1993;

            Playlist cancion3 = new Playlist();
            cancion3.nomCancion = "Here Without You";
            cancion3.artista = "3 Doors Down";
            cancion3.album = "Away From The Sun";
            cancion3.releaseDate = 2002;

            Playlist cancion4 = new Playlist();
            cancion4.nomCancion = "Higher";
            cancion4.artista = "Creed";
            cancion4.album = "Human Clay";
            cancion4.releaseDate = 1999;

            Playlist cancion5 = new Playlist();
            cancion5.nomCancion = "Look What You've Done";
            cancion5.artista = "Jet";
            cancion5.album = "Get Born";
            cancion5.releaseDate = 2003;

            //Array Playlist
            Playlist[] playlist = { cancion1, cancion2, cancion3, cancion4, cancion5 };

            //Mostrar canciones de la playlist
            for (int i = 0; i < playlist.Length; i++)
            {
                Console.WriteLine($"Canción {i + 1}:");
                playlist[i].MostrarInfo(); //Acción 1 Playlist
                Console.WriteLine();
            }

            cancion3.EscucharCancion(); //Acción 2 Playlist
        }
    }

    public class Libros
    {
        //Atributos
        public string titulo;
        public string autor;
        public int anioPublicacion;
        public string puntaje;

        //Metodos
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo}, Autor: {autor}, Año de publicación: {anioPublicacion}, Rating: {puntaje}.");
        }

        public void LeerLibro()
        {
            Console.WriteLine($"Estas leyendo {titulo} de {autor}.");
        }
    }

    public class Playlist
    {
        //Atributos
        public string nomCancion;
        public string artista;
        public string album;
        public int releaseDate;

        //metodos
        public void MostrarInfo()
        {
            Console.WriteLine($"Canción: {nomCancion}, Artista: {artista}, Album: {album}, Año de publicación: {releaseDate}.");
        }

        public void EscucharCancion()
        {
            Console.WriteLine($"Estas escuchando '{nomCancion}' de {artista}.");
        }
    }
}
