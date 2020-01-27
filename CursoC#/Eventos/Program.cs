using System;
using System.IO;

namespace Eventos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"C:\Usuarios\gerardo.ku\Desktop\Eventos.txt");
           
            Propiedades _propiedades = new Propiedades();
            Console.WriteLine("Evento:");
            _propiedades.SetNombre(Console.ReadLine());
            //Console.WriteLine("Fecha Evento: ");

            //_propiedades.SetFecha(Console.ReadLine());
           // Console.WriteLine(_propiedades.getFecha());
            Console.ReadKey();

            Archivo.EscribirArchivo(_propiedades.getNombre(), _propiedades.getFecha(), file.ToString());
            Archivo.LeeArchivo(file.ToString());          
        }

       
    }
}
