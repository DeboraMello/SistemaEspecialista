﻿using System;

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
                    // ArvoreDecisoria();
                    break;
            }
        }
    }
}
