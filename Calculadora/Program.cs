using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Procesos pro = new Procesos();
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\t\t*CALCULADORA BASICA*");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] SUMAR\n");
                Console.WriteLine("[-] RESTAR\n");
                Console.WriteLine("[*] MULTIPLICAR\n");
                Console.WriteLine("[/] DIVIDIR\n");
                Console.WriteLine("[Esc] Salir");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Seleciones Una Opcion: ");
                op = Console.ReadKey(true);

                switch (op.Key)
                {
     
                         case ConsoleKey.Add:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\t*Has Selecionado Sumar*");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\nIngrese el Primer Numero: ");
                        int A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\nIngrese el Segundo Numero: ");
                        int B = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\nSu Resultado es: " + pro.Sumar(A, B));
                        Console.ReadLine();
                        break;

                         case ConsoleKey.Subtract:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\t*Has Selecionado Restar*");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\nIngrese el Primer Numero: ");
                        int A1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\nIngrese el Segundo Numero: ");
                        int B1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\nSu Resultado es: " + pro.Restar(A1, B1));
                        Console.ReadLine();
                        break;

                        case ConsoleKey.Multiply:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\t*Has Selecionado Multiplicar*");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\nIngrese el Primer Numero: ");
                        int A2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\nIngrese el Segundo Numero: ");
                        int B2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\nSu Resultado es: " + pro.Multiplicar(A2, B2));
                        Console.ReadLine();
                        break;

                        case ConsoleKey.Divide:
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t\t*Has Selecionado Dividir*");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\nIngrese el Primer Numero: ");
                        float A3 = (float)Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("\n\nIngrese el Segundo Numero: ");
                        float B3 = (float)Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("\n\nSu Resultado es: " + pro.Dividir(A3, B3));
                        Console.ReadLine();
                        break;

                        default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcion Inexistente");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (op.Key != ConsoleKey.Escape);                   
        }
    }
}
