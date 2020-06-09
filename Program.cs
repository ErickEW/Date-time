using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var fechaActual = System.DateTime.Now;
            var utc = System.DateTime.UtcNow;
            System.Console.WriteLine("Dia");
            int dia = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Año");
            int año = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Horas");
            int hr = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Minutos");
            int min = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Segundos");
            int seg = Convert.ToInt32(Console.ReadLine());
            var fecha = new System.DateTime(año, mes, dia, hr, min, seg);
            System.Console.WriteLine($"Fecha ingresada: {fecha}");
            System.Console.WriteLine($"En 2hrs y 30min serán las {fechaActual.AddHours(2).AddMinutes(30)}");
            System.Console.WriteLine($"Actualmente son las {utc}");

            System.Console.WriteLine("Fecha y hora en Tokio"); //Amo Tokio
            System.Console.WriteLine(TimeZoneInfo.ConvertTime(fechaActual, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time")));

            System.Console.WriteLine("Comparar la fecha y hora actual con la fecha y hora ingresada.");

        }
    }
}
//To do : Comparar la fecha y hora actual con la fecha y hora ingresada. Si la fecha ingresada está en el futuro, mostrar cuántos días faltan. Si la fecha ingresada está en el pasado, mostrar cuántos días han transcurrido.