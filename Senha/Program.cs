using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            do
            {
                Console.Write("Insira a senha: ");
                numero = double.Parse(Console.ReadLine());
                if (numero == 2002)
                {
                    Console.WriteLine();
                    Console.WriteLine("Acesso Permitido");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Senha Invalida");
                }     
            } while (numero != 2002);

        }
    }
}
