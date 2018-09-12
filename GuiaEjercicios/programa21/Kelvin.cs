using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa21
{
    class Kelvin
    {
        double gradosKelvin;

        public Kelvin()
        {
            this.gradosKelvin = 0;
        }
        public Kelvin(double grados)
        {
            this.gradosKelvin = grados;
        }

        public double GetGrados()
        {
            return this.gradosKelvin;
        }
        // Área conversiones //
        public static  implicit operator Kelvin(double d)
        {
            Kelvin retorno = new Kelvin(d);
            return retorno;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Celsius retorno = new Celsius((((Fahrenheit)k).GetGrados() -32) * 5/9);
            return retorno;
        }        

        public static  explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit retorno = new Fahrenheit(k.GetGrados() * 9/5 - 459.67);
            return retorno;
        }
        // Área comparaciones //
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return (k1.GetGrados() == k2.GetGrados());
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return (k1 == k2);
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (k == (Kelvin)f);
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == (Kelvin)f);
        }
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return (k == (Kelvin)c);
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == (Kelvin)c);
        }
    }
}
