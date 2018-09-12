using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa21
{
    class Fahrenheit
    {
        double gradosFahrenheit;

        public Fahrenheit()
        {
            this.gradosFahrenheit = 0;
        }
        public Fahrenheit(double grados)
        {
            this.gradosFahrenheit = grados;
        }
        public double GetGrados()
        {
            return this.gradosFahrenheit;
        }
        // Área conversiones //
        public static implicit operator Fahrenheit(double d)
        {
            Fahrenheit retorno = new Fahrenheit(d);
            return retorno;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius retorno = new Celsius((f.GetGrados() - 32) * 5/9);
            return retorno;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin retorno = new Kelvin((f.GetGrados() + 459.67) * 5/9);
            return retorno;
        }

        // Área comparaciones // 
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return (f1.GetGrados() == f2.GetGrados());
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return (f1 == f2);
        }
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return (f == (Fahrenheit)c);
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == (Fahrenheit)c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return (f == (Fahrenheit)k);
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == (Fahrenheit)k);
        }
    }
}
