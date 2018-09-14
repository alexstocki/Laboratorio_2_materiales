using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grado;

namespace programa24
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void conversorFahrenheit_Click(object sender, EventArgs e)
    {
      double grados;
      if(double.TryParse(textBoxFahrenheit.Text, out grados))
      {
        Fahrenheit fahrenheit = new Fahrenheit(grados);
        textBoxFahAFah.Text = fahrenheit.GetGrados().ToString();
        textBoxFahACelsius.Text = ((Celsius)fahrenheit).GetGrados().ToString();
        textBoxFahAKelvin.Text = ((Kelvin)fahrenheit).GetGrados().ToString();
      }
      else
      {
        textBoxFahAFah.Text = "Ingreso inválido";
      }
    }

    private void conversorCelsius_Click(object sender, EventArgs e)
    {
      double grados;
      if (double.TryParse(textBoxCelsius.Text, out grados))
      {
        Celsius celsius = new Celsius(grados);
        textBoxCelsiusAFah.Text = ((Fahrenheit)celsius).GetGrados().ToString();
        textBoxCelsiusACelsius.Text = celsius.GetGrados().ToString();
        textBoxCelsiusAKelvin.Text = ((Kelvin)celsius).GetGrados().ToString();
      }
      else
      {
        textBoxCelsiusAFah.Text = "Ingreso inválido";
      }
    }

    private void conversorKelvin_Click(object sender, EventArgs e)
    {
      double grados;
      if (double.TryParse(textBoxKelvin.Text, out grados))
      {
        Kelvin kelvin = new Kelvin(grados);
        textBoxKelvinAFah.Text = ((Fahrenheit)kelvin).GetGrados().ToString();
        textBoxKelvinACelsius.Text = ((Celsius)kelvin).GetGrados().ToString();
        textBoxKelvinAKelvin.Text = kelvin.GetGrados().ToString();
      }
      else
      {
        textBoxKelvinAFah.Text = "Ingreso inválido";
      }
    }
  }
}
