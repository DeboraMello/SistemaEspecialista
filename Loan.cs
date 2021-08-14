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

                if (opcao == 1) 
                {
                    if(i >= 4) 
                    { 
                       return "SIM - Autorizar empréstimo até R$1000";
                    }      
                    
                    return "Solicitação Negada.";                
                }
                
                if(opcao == 2 && i == 5) 
                {
                    return "SIM - Autorizar empréstimo acima de R$1000";
                }        
            }
            return string.Empty;
        }

        public static List<BinaryAnswerTreeNode> BuildArvore() 
        {
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
