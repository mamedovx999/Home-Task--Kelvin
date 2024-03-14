using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task__Kelvin
{
    internal class Celcius
    {

        public double Temp { get; set; }
        public Celcius(double temp)
        {
            Temp = temp;
        }
        public static implicit operator Kelvin(Celcius celcius)
        {
            return new Kelvin(celcius.Temp +273.15);
        }

    }
}