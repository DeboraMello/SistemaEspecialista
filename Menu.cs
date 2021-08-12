using System;
using System.Collections.Generic;

namespace sistemaEspecialista
{
    class Menu 
    {
        public static void main() 
        {
            int option;

            do
            {
                Console.WriteLine("+------------------------------+");
                Console.WriteLine("|     SISTEMA ESPECIALISTA     |");
                Console.WriteLine("+------------------------------+");
                Console.WriteLine(" Escolha uma das opçoes abaixo:");
                Console.WriteLine(" [1] - Perfil do investidor");
                Console.WriteLine(" [2] - Concessão de crédito");
                Console.WriteLine(" [3] - Sair");
                Console.WriteLine("+------------------------------+");
                Console.Write("Resposta: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            } while (option != 1 && option != 2 && option != 3);

            switch (option)
            {
                case 1:
                    sistemaEspecialista.Suitability.decision();
                    // sistemaEspecialista.Form.Start();
                    break;
                case 2:                    
                    Console.WriteLine(sistemaEspecialista.Loan.ArvoreDecisoria());
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
    }
}