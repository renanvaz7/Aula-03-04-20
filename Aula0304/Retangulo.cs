using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula0304
{
    class Retangulo
    {
        public double largura { get; set; }
        public double altura { get; set; }


        /*Passei as variáveis por parametro, pra ele funcionar eu preciso de dois 
         * valores double*/
        public double Area(double altura, double largura)
        {
            double Area = altura * largura;
            return Area;
        }
        public double Perimetro()
        {
            double perimetro = 2.0 * (largura + altura);
            return perimetro;
        }
        public double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(2, altura) + Math.Pow(2, largura));
            return diagonal;
        }
    }
}
