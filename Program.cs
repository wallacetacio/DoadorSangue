using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.Write("Olá, usuário! Por favor, digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(idade > 18 && idade < 67){
                Console.Write("Você ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("pode ");
                Console.ResetColor();
                Console.Write("ser doador de ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("sangue");
                Console.ResetColor();
                Console.WriteLine("!");

            }else
            {
                Console.Write("Você ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("não ");
                Console.ResetColor();
                Console.Write("pode ser doador de ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("sangue");
                Console.ResetColor();
                Console.WriteLine("!");

            }
        }
    }
}
