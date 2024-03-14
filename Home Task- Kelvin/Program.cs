using System.Security.Cryptography.X509Certificates;

namespace Home_Task__Kelvin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin temperature = new(100);
            Celcius celcius = temperature;
            Console.WriteLine(celcius.Temp);
        }
    }
}
