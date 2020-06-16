using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Linq.Expressions;
using ExVideos.Clases;
using System.IO;

namespace ExVideos
{
    class Program
    {
        public static Dictionary<string, User> usuariosvideoclub = new Dictionary<string, User>();
        public static Dictionary<string, Video> videos = new Dictionary<string, Video>();
        public static Dictionary<string, Alquiler> videosusuario = new Dictionary<string, Alquiler>();
        static void Main(string[] args)
        {
            nuevoUsuario();
            static void nuevoUsuario()
            {
                static void errorpersonalizado(Exception ex) { Console.WriteLine("error", ex.Message); }
                Console.WriteLine("Escriba Nombre Usuario Nuevo");
                var user = Console.ReadLine();
                Console.WriteLine("Escriba Nombre Nuevo");
                var name = Console.ReadLine();
                //if (string.IsNullOrEmpty(name)) errorpersonalizado();
                Console.WriteLine("Escriba Apellido Usuario Nuevo");
                var surname = Console.ReadLine();
                //if (string.IsNullOrEmpty(surname)) errorpersonalizado();
                Console.WriteLine("Escriba Password Usuario Nuevo");
                var pass = Console.ReadLine();
                //if (string.IsNullOrEmpty(pass)) errorpersonalizado();
                var nuevouser = new User
                {
                    Username = user,
                    Name = name,
                    Surname = surname,
                    xPassword = pass,
                    Regdate = DateTime.Now
                };
                usuariosvideoclub.Add(nuevouser.Username, nuevouser);
                menuprincipal();
            }
            static void verusuarios()
            {
                foreach (var usuarios in usuariosvideoclub.Values)
                {
                    Console.WriteLine(usuarios.Username + "" + usuarios.Surname);
                }
                menuprincipal();
            }        
            static void alquiler()
            {
                Console.WriteLine("Indique Usuario");
                string usuario = Console.ReadLine();
                if (usuariosvideoclub.ContainsKey(usuario))
                {
                    Console.WriteLine("El usuario va a crear un nuevo video");
                    Console.WriteLine("indique nombre video");
                    var title = Console.ReadLine();
                    Console.WriteLine("indique url video");
                    var url = Console.ReadLine();
                    Console.WriteLine("indique tag video");
                    var tags = Console.ReadLine();
                    Console.WriteLine("indique estado video (0) (1) (2) (3)");
                    var estado = Int32.Parse(Console.ReadLine());
                    Reproductor estado2 = (Reproductor)estado;
                    var nuevovideo = new Video
                    {
                        Url = url,
                        Title = title,
                        Tags = tags,
                        Estado = estado2
                    };
                    videos.Add(nuevovideo.Title, nuevovideo);
                    var alquiler = new Alquiler
                    {
                        Username = usuario,
                        Title = title
                    };
                    videosusuario.Add(title, alquiler);
                    menuprincipal();
                }
                else Console.WriteLine("no existe el usuario");
            }
            static void menuprincipal()
            {
                Console.WriteLine("Bienvenido al Video Club");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Para menu usuario escriba usuario");
                Console.WriteLine("Para ver usuarios escriba ver");
                Console.WriteLine("Para ver videos de usuarios escriba videos");
                Console.WriteLine("Para ver todos los videos y reproducir escriba repro");
                var opcion = Console.ReadLine();
                var continua = true;
                while (continua)
                {
                    if (opcion == "usuario")
                    {
                        Console.WriteLine("Escriba Nuevo para Nuevo Usuario o Enter Para Nuevo Video");
                        opcion = Console.ReadLine();
                        if (opcion == "nuevo") nuevoUsuario();
                        else
                        {
                            alquiler();
                        }
                    }
                    if (opcion == "ver")
                    {
                        verusuarios();
                        menuprincipal();
                    }
                    if (opcion == "videos")
                    {
                        vervideos();
                    }                 
                }
            }
            static void vervideos()
            {
                Console.WriteLine("Indique Usuario");
                var usuario = Console.ReadLine();
                foreach (var dato in videosusuario.Values)
                {
                    if (dato.Username == usuario)
                    {
                        Console.WriteLine("Indique Password");
                        var xpass = Console.ReadLine();
                        foreach (var pass in usuariosvideoclub.Values)
                        {
                            if (pass.xPassword == xpass)
                            {
                                Console.WriteLine(dato.Title +" /// "+dato.Estado);
                            }
                        }
                    }
                }
            }
        }     
    }
}






