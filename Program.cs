using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Linq.Expressions;

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
                Console.WriteLine("Escriba Nombre Usuario Nuevo");
                var user = Console.ReadLine();
                Console.WriteLine("Escriba Nombre Nuevo");
                var name = Console.ReadLine();
                Console.WriteLine("Escriba Apellido Usuario Nuevo");
                var surname = Console.ReadLine();
                Console.WriteLine("Escriba Password Usuario Nuevo");
                var pass = Console.ReadLine();
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
                    var nuevovideo = new Video
                    {
                        Url = url,
                        Title = title,
                        Tags = tags
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
                                Console.WriteLine(dato.Title);
                            }
                        }
                    }
                }
            }
           
        }
        public class Video
        {
            public string Url;  //propiedad de la clase video o campos de clase 
            public string Title;  //propiedad de la clase video o campos de clase 
            public string Tags;  //propiedad de la clase video o campos de clase 
            public string Estado; // indica si esta en reproduccion o en que estado esta.

            
        }
        public class User
        {
            public string Username;  //propiedad de la clase video o campos de clase 
            public string Name;  //propiedad de la clase video o campos de clase 
            public string Surname;  //propiedad de la clase video o campos de clase
            public string xPassword;  //propiedad de la clase video o campos de clase
            public DateTime Regdate;
        }
        public class Alquiler : Video
        {
            public string Username;
            public new string Title;
        }
        public enum Reproductor { Rewind, Stop, Play, FastForward };
        public enum Tags { Tag1, Tag2, Tag3, Tag4 };

    }
}






