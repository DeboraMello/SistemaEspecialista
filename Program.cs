using System;

namespace sistemaEspecialista
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Bem vindo ao jogo de texto");
                Console.WriteLine("Escolha uma das opçoes abaixo:");
                Console.WriteLine("1 - Perfil do investidor");
                Console.WriteLine("2 - Concessão de crédito");
                Console.WriteLine("3 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            } while (opcao != 1 && opcao != 2 && opcao != 3);

            switch (opcao)
            {
                case 1:
                    sistemaEspecialista.Suitability.decision();
                    break;
                case 2:
                    // ArvoreDecisoria();
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
    }
}
