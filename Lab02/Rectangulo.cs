using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Rectangulo
    {

        public Punto p1 { get; set; }

        public Punto p2 { get; set; }

        public Punto p3 { get; set; }

        public Punto p4 { get; set; }

        public double CalcularDistancia(Punto pf, Punto pi)
        {
            return Math.Sqrt(Math.Pow(pf.x - pi.x, 2) + Math.Pow(pf.y - pi.y, 2));
        }

 
        public double CalcularArea()
        {
            double dh = CalcularDistancia(p2, p1);
            double dv = CalcularDistancia(p4, p1);
            return dh * dv;
        }

        public double CalcularPerimetro()
        {
            double dh = CalcularDistancia(p2, p1);
            double dv = CalcularDistancia(p4, p1);
            return dh + dh + dv + dv;
        }

    }
}
