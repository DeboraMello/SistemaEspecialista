using System;
using System.Collections.Generic;

namespace sistemaEspecialista
{
    class SuitabilityForm
    {
        public static void generateForm()
        {
            List<Alternative> alternativesQuestion1 = new List<Alternative>()
            {
                new Alternative(1, "Gostaria de variar os investimentos!", 50),
                new Alternative(2, "Penso que arriscar é fundamental!", 100),
                new Alternative(3, "Gostaria de segurança, não me importo com o prazo!", 10),
            };

            List<Alternative> alternativesQuestion2 = new List<Alternative>()
            {
                new Alternative(1, "Ganhar dinheiro acima da inflação e com renda!", 50),
                new Alternative(2, "Proteger meu dinheiro e não perder!", 10),
                new Alternative(3, "Aumentar meu capital!", 80),
            };            
            
            List<Alternative> alternativesQuestion3 = new List<Alternative>()
            {
                new Alternative(1, "Rentabilidade!", 80),
                new Alternative(2, "Diversificação e ganhos!", 50),
                new Alternative(3, "Segurança!", 10),
            };

            List<Alternative> alternativesQuestion4 = new List<Alternative>()
            {
                new Alternative(1, "Conheço e já investi em renda variável!", 70),
                new Alternative(2, "Já ouvi sobre Tesouro Direito e CDB!", 20),
                new Alternative(3, "Invisto rotineiramente na bolsa!", 100),
            };

            List<Alternative> alternativesQuestion5 = new List<Alternative>()
            {
                new Alternative(1, "Posso correr algum risco pequeno!", 50),
                new Alternative(2, "Vejo como oportunidade de aumentar ganhos!", 80),
                new Alternative(3, "Sou totalmente avesso!", 10),
            };

            List<Question> questions = new List<Question>()
            {
                new Question(1, "O que você pensa sobre investimentos?", alternativesQuestion1),
                new Question(2, "Qual seu objetivo ao investir?", alternativesQuestion2),
                new Question(3, "Quais suas prioridades?", alternativesQuestion3),
                new Question(4, "O que sabe sobre o mercado de investimentos?", alternativesQuestion4),
                new Question(5, "Como reage diante de riscos?", alternativesQuestion5),
            };
            
            Form form = new Form(1, "Suitability", questions);
            
            int option;
            int points = 0;
            
            foreach (Question question in form.Questions)
            {
                Console.WriteLine(question.Description);

                foreach (Alternative alternative in question.Alternatives)
                {
                    Console.WriteLine("[{0}] - {1}", alternative.Id, alternative.Description);
                } 

                do
                {
                    Console.Write("Resposta: ");
                    option = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();  

                    if (option != 1 && option != 2 && option != 3) 
                    {
                        Console.WriteLine("Opção Inválida, tente novamente!");
                    }

                } while (option != 1 && option != 2 && option != 3);

                points = points + question.Alternatives[option - 1].Points;
                Console.WriteLine(points);
            }

            if (points / 5 < 50) Console.WriteLine("PERFIL CONSERVADOR!");
            else if (points / 5 >= 50 && points / 5 <= 75) Console.WriteLine("PERFIL MODERADO!");
            else if (points / 5 > 100) Console.WriteLine("PERFIL ARROJADO!");
        } 
    }
}
