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

        public Boolean validarTriangulosRectangulos(Punto pb, Punto pa, Punto pc) {

            double dh = CalcularDistancia(pa, pc);
            double dv = CalcularDistancia(pa, pb);
            double Hipotenusa = Math.Sqrt(Math.Pow(dh, 2) + Math.Pow(dv, 2));

            double igualdad = Math.Sqrt(Math.Pow(dh, 2) + Math.Pow(dv, 2));

            if (Hipotenusa == igualdad)
            {
                Console.WriteLine(igualdad);
                Console.WriteLine(Hipotenusa);
                return true;

            }
            else
            {
                Console.WriteLine(igualdad);
                Console.WriteLine(Hipotenusa);
                return false;
            }

        }

        public Boolean validarExistencia() {

            double area = CalcularDistancia(p2,p1) * CalcularDistancia(p4,p1);

            Boolean t1 = validarTriangulosRectangulos(p4, p1, p2);
            Boolean t2 = validarTriangulosRectangulos(p3, p2, p1);

            if (t1 == t2 && area != 0) {

                return true;

            }
            
            return false;
        }

    }
}
