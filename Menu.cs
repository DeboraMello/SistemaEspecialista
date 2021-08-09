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
                    // sistemaEspecialista.Suitability.decision();
                    sistemaEspecialista.SuitabilityForm.run();
                    break;
                case 2:
                    //assim que acabar sobe o codigo
                    Dictionary<int, BinaryAnswerTreeNode> dic = new Dictionary<int, BinaryAnswerTreeNode>();
                    
                    BinaryAnswerTreeNode node1 = new BinaryAnswerTreeNode("Qual a idade do solicitante?", "1 - Menor que 20 anos.","2 - 20 anos ou mais.");
                    BinaryAnswerTreeNode node2 = new BinaryAnswerTreeNode("Possui renda?", "1 - Não possui","2 - Possui");
                    BinaryAnswerTreeNode node3 = new BinaryAnswerTreeNode("Mais alguém depende da renda do solicitante?", "1 - Sim","2 - Não");
                    BinaryAnswerTreeNode node4 = new BinaryAnswerTreeNode("Menor ou maior que 3 salários?", "1 - Menor","2 - Maior");
                    BinaryAnswerTreeNode node5 = new BinaryAnswerTreeNode("Como é o hitórico de crédito do solicitante?", "1 - Possui dívidas.","2 - Nenhuma dívida.");
                    BinaryAnswerTreeNode node6 = new BinaryAnswerTreeNode("Já deixou de pagar alguma vez?", "1 - Sim.","2 - Não.");
                    BinaryAnswerTreeNode node7 = new BinaryAnswerTreeNode("Quanto tempo de conta no banco?", "1 - Até um ano.","2 - Mais de um ano.");
                    
                    dic.Add(1, node1);
                    dic.Add(2, node2);
                    dic.Add(3, node3);
                    dic.Add(4, node4);
                    dic.Add(5, node5);
                    dic.Add(6, node6);
                    dic.Add(7, node7);
                
                    Loan.ArvoreDecisoria();
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
    }
}