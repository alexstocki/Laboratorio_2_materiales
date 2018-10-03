using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Comensal
  {
    #region Atributos

    private string _apellido;
    private string _nombre;

    #endregion

    #region Propiedades

    public string Apellido
    {
      get
      {
        return this._apellido;
      }
    }

    public string Nombre
    {
      get
      {
        return this._nombre;
      }
    }

    #endregion

    #region Métodos

    public Comensal(string nombre, string apellido)
    {
      this._nombre = nombre;
      this._apellido = apellido;
    }

    public virtual string Mostrar()
    {
      StringBuilder cadena = new StringBuilder();
      cadena.AppendFormat("Nombre Apellido: ", this.Nombre, this.Apellido);
      return cadena.ToString();
    }

    #endregion
  }
}
