using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa21
{
    class Celsius
    {
        double gradosCelsius;

        public Celsius()
        {
            this.gradosCelsius = 0;
        }
        public Celsius(double grados)
        {
            this.gradosCelsius = grados;
        }
        public double GetGrados()
        {
            return this.gradosCelsius;
        }
    // Área conversiones //
        public static implicit operator Celsius(double d)
        {
            Celsius retorno = new Celsius(d);
            return retorno;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit retorno = new Fahrenheit(c.GetGrados() * 9/5 + 32);
            return retorno;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin retorno = new Kelvin((((Fahrenheit)c).GetGrados() + 459.67)* 5/9);
            return retorno;
        }
        // Área comparaciones //
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return (c1.GetGrados() == c2.GetGrados());
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return (c1 == c2);
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return (c == (Celsius)f);
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == (Celsius)f);
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return (c == (Celsius)k);
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == (Celsius)k);
        }
    }
}
