using System;
using System.Collections.Generic;

namespace sistemaEspecialista
{
    public class Loan
    {
        public static void ArvoreDecisoria()
        {
            var dic = new Dictionary<int, string>();

            int opcao;
            Console.WriteLine($"Qual a idade do solicitante?");
            Console.WriteLine($"1 - Menor que 20 anos.");
            Console.WriteLine($"2 - Maior ou igual a 20 anos.");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao ==2)
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
                        Console.WriteLine($"Solicitação Negada.");
                        break;
                    case 3:
                        ArvoreDecisoriaHistorico();
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Solicitação Negada.");
            }
        }

        static void ArvoreDecisoriaHistorico()
        {
            int opcao;
            int opcao2;
            int opcao3;
            Console.WriteLine("Qual o histórico de crédito do solicitante?");
            Console.WriteLine("1 - Endividado.");
            Console.WriteLine("2 - Nenhuma dívida.");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Solicitação Negada.");
                    break;
                case 2:
                    Console.WriteLine("Você já deixou de pagar alguma dívida?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Não");
                    opcao2 = Convert.ToInt32(Console.ReadLine());

                    if (opcao2 == 1)
                    {
                        Console.WriteLine("Crédito de até R$ 1000 reais.");
                    }
                    else if (opcao2 == 2)
                    {
                        Console.WriteLine("Há quanto tempo já tem conta no Banco?");
                        Console.WriteLine("1 - Até 1 ano.");
                        Console.WriteLine("2 - Mais de 1 ano.");
                        opcao3 = Convert.ToInt32(Console.ReadLine());

                        switch (opcao3)
                        {
                            case 1:
                                Console.WriteLine("Crédito de até R$ 1000 reais.");
                                break;
                            case 2:
                                Console.WriteLine("Crédito mais de R$ 1000 reais.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

    }
}
