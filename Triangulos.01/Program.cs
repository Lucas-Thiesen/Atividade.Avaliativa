using System;

namespace Triangulos._01
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            do
            {
                int x, y, z;
                Console.WriteLine("Verificação de triângulos: ");
                Console.WriteLine("Insira o valor de X: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o valor de Y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o valor de Z: ");
                z = Convert.ToInt32(Console.ReadLine());

                if (x + y < z || x + z < y || y + z < x)
                {
                    Console.WriteLine("Triangulo inválido! Tente novamente");
                }
                else if(x <= 0 || y <= 0 || z <= 0)
                {
                    Console.WriteLine("Insira um valor maior que 0");
                }
                else if (x == y && y == z && z == x)
                {
                    Console.WriteLine("Triângulo EQUILATERO!");
                }
                else if (x == y && y != z && z != x)
                {
                    Console.WriteLine("Triângulo ISÓSCELES!");
                }
                else if (x != y && y != z && y != x)
                {
                    Console.WriteLine("Triângulo ESCALENO!");
                }

                Console.WriteLine("Deseja fazer novamente? S/Sim N/Não: ");
                string resp = Console.ReadLine();
                if (resp == "s")
                {
                    continue;
                }
                else
                {
                    break;
                }
                Console.ReadKey();
            }while (true);
        }
    }
}
