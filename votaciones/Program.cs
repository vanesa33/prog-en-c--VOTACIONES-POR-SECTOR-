using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int CANN = 0;
            int CANS = 0;
            int CANC = 0;
            char OP;
            string ZONA, linea;
            CANN = 0;
            CANC = 0;
            CANS = 0;
            do
            {
                Console.Write("QUE SECTOR NORTE,CENTRO,SUR:");
                ZONA = Console.ReadLine();
                switch (ZONA.ToUpper())
                {
                    case "NORTE":
                        CANN = CANN + 1;
                        break;
                    case "CENTRO":
                        CANC = CANC + 1;
                        break;
                    case "SUR":
                        CANS = CANS + 1;
                        break;
                }
                Console.Write(" HAY OTRA PERSONA S/N:");
                linea = Console.ReadLine();
                OP = char.Parse(linea.ToUpper());
            } while (OP.ToString().Contains("S"));
            Console.WriteLine("DE LA ZONA NORTE :" + CANN);
            Console.WriteLine("DE LA ZONA CENTRO :" + CANC);
            Console.WriteLine("DE LA ZONA SUR :" + CANS);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
