using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO__Poliformismo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }

    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }

    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }

    class Programa
    {
        static void Main()
        {
            Figura rectangulo = new Rectangulo(10, 5);
            Figura circulo = new Circulo(7);
            Figura triangulo = new Triangulo(6, 4);

            Console.WriteLine("Área del Rectángulo: " + rectangulo.CalcularArea());
            Console.WriteLine("Área del Círculo: " + circulo.CalcularArea());
            Console.WriteLine("Área del Triángulo: " + triangulo.CalcularArea());
        }
    }

}
