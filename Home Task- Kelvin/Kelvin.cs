using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task__Kelvin
{
    internal class Kelvin
    {
        public double Temp { get; set; }
        public Kelvin(double temp)
        {
            Temp = temp; 
        }
        public static implicit operator Celcius(Kelvin kelvin)
        {
            return new Celcius(kelvin.Temp - 273.15);
        }
    }
}

