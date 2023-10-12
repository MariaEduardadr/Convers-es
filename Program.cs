using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine("1. Converter de centímetros para metros");
            Console.WriteLine("2. Converter de metros para centímetros");
            Console.WriteLine("3. Converter de milímetros para metros");
            Console.WriteLine("4. Converter de metros para milímetros");
            Console.WriteLine("         ");

            Console.WriteLine("informe uma das opções acima: ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            switch (op)
            {
                case 1:
                    Console.WriteLine("Converter de centímetros para metros");
                    double metro, centimetro;
                    Console.WriteLine("Digite um valor: ");
                    centimetro = double.Parse(Console.ReadLine());
                    metro = centimetro / 100;
                    Console.WriteLine("Resultado da converção: " + metro);
                    break;

                case 2:
                    Console.WriteLine("Converter de metros para centímetros");
                    double m, c;
                    Console.WriteLine("Digite um valor: ");
                    m = double.Parse(Console.ReadLine());
                    c = m * 100;
                    Console.WriteLine("Resultado da converção: " + c);
                    break;

                case 3:
                    Console.WriteLine("Converter de milímetros para metros");
                    double milimetros, metros;
                    Console.WriteLine("Digite um valor: ");
                    milimetros = double.Parse(Console.ReadLine());
                    metros = milimetros / 1000;
                    Console.WriteLine("Resultado da converção: " + metros);
                    break;

                case 4:
                    Console.WriteLine("Converter de metros para milímetros");
                    double metros4, milimetro;
                    Console.WriteLine("Digite um valor: ");
                    metros4 = double.Parse(Console.ReadLine());
                    milimetro = metros4 * 1000;
                    Console.WriteLine("Resultado da converção: " + milimetro);
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA");
                    break;
            }
            Console.ReadLine();
        }
    }
}
