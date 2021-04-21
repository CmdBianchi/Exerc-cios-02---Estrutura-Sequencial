using System;

namespace Exercícios_02___Estrutura_Sequencial
{
    class Program
    {
        /// -------> START
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            Msg();
            Formula();

        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg()
        {
            Console.WriteLine("Valor da área deste círculo com quatro casas decimais.");
        }
        /*------------------------------------------------------------------------------------------*/
        static void Formula()
        {
            double area, raio, pi = 3.14159;
            Console.Write("Digite o valor do RAIO: ");
            raio = double.Parse(Console.ReadLine());
            area = pi * raio * raio;
            Console.Write("O valor da área é: " + area.ToString("F4"));

        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END

    }
}
