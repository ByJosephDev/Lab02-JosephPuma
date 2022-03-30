using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangulo rectangulo = new Rectangulo();


            Console.WriteLine("Ingrese los primeros valores del primer punto");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            rectangulo.p1 = new Punto(x1, y1);
            Console.WriteLine("Ingrese los primeros valores del segundo punto");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            rectangulo.p2 = new Punto(x2, y2);
            Console.WriteLine("Ingrese los primeros valores del tercer punto");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            rectangulo.p3 = new Punto(x3, y3);
            Console.WriteLine("Ingrese los primeros valores del cuarto punto");
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            rectangulo.p4 = new Punto(x4, y4);

            Console.WriteLine("Area del rectangulo es " + rectangulo.CalcularArea());
            Console.WriteLine("Perimetro del rectangulo es " + rectangulo.CalcularPerimetro());
            Console.WriteLine("El rectangulo es real ? -- " + rectangulo.validarExistencia());

            Console.Read();

        }
    }
}
