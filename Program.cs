using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Verifique em que quadrante do referencial cartesiano se 
            //encontra um ponto com as corrdenas (x,y) introduzidas pelo utilizador.

            Console.WriteLine("Insira um valor para x ?");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira um valor para y ?");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Pertence ao primeiro quadrante!");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine("Pertence ao quarto quadrante!");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Pertence ao segundo quadrante!");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Pertence ao terceiro quandrante!");
            }

            if (x == 0 && y == 0) 
            {
                Console.WriteLine("Origem do referencial");
            }

        }
    }
}
