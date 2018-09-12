using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            SetTinta(tinta);
        }
        public Boligrafo(short tinta)
        {
            SetTinta(tinta);
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "No se pudo imprimir";

            if (this.tinta - gasto >= 0)
            {
                dibujo = "";

                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }

                if (this.GetTinta() == 0)
                {
                    this.Recargar();
                }

                return true;
            }

            return false;
        }

        public bool Recargar()
        {
            this.tinta = cantidadTintaMaxima;

            return true; 
        }

        private void SetTinta(short tinta)
        {
            if(this.tinta + tinta >= 0 && this.tinta <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }
    }
}
