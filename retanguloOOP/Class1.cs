using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retanguloOOP
{
    internal class Class1
    {
        public double altura;
        public double largura;
        public double diagonal;

        public double Area() { 
            return  altura * largura;
        }

        public double Perimetro() { 
            return 2 * (altura + largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }
        public override string ToString()
        {
            return "Área: " + Area().ToString("F2", CultureInfo.InvariantCulture) + ", Perimetro: " + Perimetro().ToString("F2" ,CultureInfo.InvariantCulture) + ", Diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
