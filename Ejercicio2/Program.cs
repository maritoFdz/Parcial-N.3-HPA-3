using Newtonsoft.Json;

namespace Ejercicio2
{
    public class Program
    {
        public static void Main()
        {
            var persona = new
            {
                Nombre = "Cristell",
                Edad = 20,
                Carrera = "Ingenieria en Sistemas"
            };

            string json = JsonConvert.SerializeObject(persona);
            Console.WriteLine(json);
        }
    }
}