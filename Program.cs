using System;

namespace sistemaEspecialista
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool sair = false;

            do
            {
                Console.WriteLine("Bem vindo ao jogo de texto");
                Console.WriteLine("Escolha uma das opçoes abaixo:");
                Console.WriteLine("1 - Perfil do investidor");
                Console.WriteLine("2 - Concessão de crédito");
                opcao = Convert.ToInt32(Console.ReadLine());
            } while (opcao != 1 && opcao != 2);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Aqui entram as perguntas");
                    break;
                case 2:
                    ArvoreDecisoria();
                    break;
            }
        }

        static void ArvoreDecisoria()
        {

            int idade;
            int opcao;
            Console.WriteLine($"Qual a idade do solicitante?");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 20 || idade == 20)
            {
                Console.WriteLine($"Qual a renda do solicitante?");
                Console.WriteLine($"1 - Não possui");
                Console.WriteLine($"2 - Até 3 salários");
                Console.WriteLine($"3 - Mais de 3 salários");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Solicitação Negada.");
                        break;
                    case 2:
                        ArvoreDecisoria();
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Solicitação Negada.");
            }
        }

    }
}
