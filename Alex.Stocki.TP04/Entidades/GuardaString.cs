using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Entidades
{
    static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            StreamWriter sw = null;
            bool condicion = false;

            try
            {
                sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo, true);
                sw.Write(texto);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                sw.Close();
            }
            return condicion;
        }
    }
}
