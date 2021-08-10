using System;
using System.Collections.Generic;

namespace sistemaEspecialista
{
    public class Loan
    {  
        
        public static String ArvoreDecisoria()
        {
            List<BinaryAnswerTreeNode> listaNos = BuildArvore();

            int opcao; 

            for (int i = 0; i < listaNos.Count; i++)
            {
                Console.WriteLine(listaNos[i].Pergunta);
                Console.WriteLine(listaNos[i].RespostaOpcaoUm);
                Console.WriteLine(listaNos[i].RespostaOpcaoDois);

                opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao == 1){
                    if(i >= 4){
                       Console.WriteLine("SIM - Autorizar empréstimo até R$1000");
                        break; 
                    }    
                    Console.WriteLine("Solicitação Negada.");
                    break;                
                }
                
                if(opcao == 2 && i == 5){
                    Console.WriteLine("SIM - Autorizar empréstimo acima de R$1000");
                }        
            }
            return "Solicitação Negada.";
        }

            // Console.WriteLine($"Qual a idade do solicitante?");
            // Console.WriteLine($"1 - Menor que 20 anos.");
            // Console.WriteLine($"2 - Maior ou igual a 20 anos.");
            // opcao = Convert.ToInt32(Console.ReadLine());

            // if (opcao == 2)
            // {
            //     Console.WriteLine($"Possui renda?");
            //     Console.WriteLine($"1 - Não possui");
            //     Console.WriteLine($"2 - Possui");

            //     opcao = Convert.ToInt32(Console.ReadLine());

            //     if (opcao == 2)
            //     {
            //         Console.WriteLine($"A renda é menor ou maior que 3 salários?");
            //         Console.WriteLine($"1 - Menor");
            //         Console.WriteLine($"2 - Maior");

            //         opcao = Convert.ToInt32(Console.ReadLine());
            //         if (opcao == 2)
            //         {
            //             Console.WriteLine($"Como é o hitórico de crédito do solicitante?");
            //             Console.WriteLine($"1 - Possui dívidas.");
            //             Console.WriteLine($"2 - Nenhuma dívida.");

            //             opcao = Convert.ToInt32(Console.ReadLine());
            //             if (opcao == 2)
            //             {
            //                 Console.WriteLine($"Já deixou de pagar alguma vez?");
            //                 Console.WriteLine($"1 - Sim");
            //                 Console.WriteLine($"2 -Não");

            //                 opcao = Convert.ToInt32(Console.ReadLine());
            //                 if (opcao == 1)
            //                 {
            //                     return ("SIM - Autorizar empréstimo até R$1000");
            //                 }
            //                 else if (opcao == 2)
            //                 {
            //                     Console.WriteLine($"Quanto tempo de conta no banco?");
            //                     Console.WriteLine($"1 - Até um ano.");
            //                     Console.WriteLine($"2 - Mais de um ano.");

            //                     opcao = Convert.ToInt32(Console.ReadLine());

            //                     if (opcao == 1)
            //                     {
            //                         return ("SIM - Autorizar empréstimo até R$1000");
            //                     } else if(opcao == 2){
            //                         return ("SIM - Autorizar empréstimo acima de R$1000");
            //                     }
            //                 }
            //             }
            //         }
            //     // }
            // }

            // return ("Solicitação Negada.");
        // }

     public static List<BinaryAnswerTreeNode> BuildArvore() {
            BinaryAnswerTreeNode node1 = new BinaryAnswerTreeNode(1, "Qual a idade do solicitante?", "1 - Menor que 20 anos.", "2 - 20 anos ou mais.");
            BinaryAnswerTreeNode node2 = new BinaryAnswerTreeNode(2, "Possui renda?", "1 - Não possui", "2 - Possui");
            BinaryAnswerTreeNode node3 = new BinaryAnswerTreeNode(3, "Menor ou maior que 3 salários?", "1 - Menor", "2 - Maior");
            BinaryAnswerTreeNode node4 = new BinaryAnswerTreeNode(4, "Como é o hitórico de crédito do solicitante?", "1 - Possui dívidas.", "2 - Nenhuma dívida.");
            BinaryAnswerTreeNode node5 = new BinaryAnswerTreeNode(5, "Já deixou de pagar alguma vez?", "1 - Sim.", "2 - Não.");
            BinaryAnswerTreeNode node6 = new BinaryAnswerTreeNode(6, "Quanto tempo de conta no banco?", "1 - Até um ano.", "2 - Mais de um ano.");

            List<BinaryAnswerTreeNode> listaNos = new List<BinaryAnswerTreeNode>();

            listaNos.Add(node1);
            listaNos.Add(node2);
            listaNos.Add(node3);
            listaNos.Add(node4);
            listaNos.Add(node5);
            listaNos.Add(node6);

            return listaNos;
        }   

    }
     
    
}
