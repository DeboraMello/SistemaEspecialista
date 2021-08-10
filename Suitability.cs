using System;

namespace sistemaEspecialista
{
    class Suitability
    {
        public static void questions(int question, int sub_question)
        {
            switch (question)
            {
                case 1:
                    Console.WriteLine("O que você pensa sobre investimentos?");
                    break;

                case 2:
                    Console.WriteLine("Qual seu objetivo ao investir?");
                    break;

                case 3:
                    Console.WriteLine("Quais suas prioridades?");
                    break;

                case 4:
                    Console.WriteLine("O que sabe sobre o mercado de investimentos?");
                    break;

                case 5:
                    Console.WriteLine("Como reage diante de riscos?");
                    break;
            }

            switch (sub_question)
            {

                case 1:
                    Console.WriteLine("[1] - Gostaria de variar os investimentos!");
                    Console.WriteLine("[2] - Penso que arriscar é fundamental!");
                    Console.WriteLine("[3] - Gostaria de segurança, não me importo com o prazo!");
                    break;

                case 2:
                    Console.WriteLine("[1] - Ganhar dinheiro acima da inflação e com renda!");
                    Console.WriteLine("[2] - Proteger meu dinheiro e não perder!");
                    Console.WriteLine("[3] - Aumentar meu capital!");
                    break;

                case 3:
                    Console.WriteLine("[1] - Rentabilidade!");
                    Console.WriteLine("[2] - Diversificação e ganhos!");
                    Console.WriteLine("[3] - Segurança!");
                    break;

                case 4:
                    Console.WriteLine("[1] - Conheço e já investi em renda variável!");
                    Console.WriteLine("[2] - Já ouvi sobre Tesouro Direito e CDB!");
                    Console.WriteLine("[3] - Invisto rotineiramente na bolsa!");
                    break;

                case 5:
                    Console.WriteLine("[1] - Posso correr algum risco pequeno!");
                    Console.WriteLine("[2] - Vejo como oportunidade de aumentar ganhos!");
                    Console.WriteLine("[3] - Sou totalmente avesso!");
                    break;
            }
        }

        public static int point(int question, int answer)
        {
            int count = 0;
            if (question == 1)
            {
                if (answer == 1) count = 50;
                else if (answer == 2) count = 100;
                else if (answer == 3) count = 10;
            }
            else if (question == 2)
            {
                if (answer == 1) count = 50;
                else if (answer == 2) count = 10;
                else if (answer == 3) count = 80;
            }
            else if (question == 3)
            {
                if (answer == 1) count = 80;
                else if (answer == 2) count = 50;
                else if (answer == 3) count = 10;
            }
            else if (question == 4)
            {
                if (answer == 1) count = 70;
                else if (answer == 2) count = 20;
                else if (answer == 3) count = 100;
            }
            else if (question == 5)
            {
                if (answer == 1) count = 50;
                else if (answer == 2) count = 80;
                else if (answer == 3) count = 10;
            }
            return count;
        }

        public static void decision()
        {
            int option;
            int points = 0;
            for (int i = 1; i < 6; i++)
            {
                questions(i, i);
                do
                {
                    Console.Write("Resposta: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (option != 1 && option != 2 && option != 3) Console.WriteLine("Opção Inválida, tente novamente!");

                } while (option != 1 && option != 2 && option != 3);
                points = points + point(i, option);
            }
            
            if (points / 5 < 50) Console.WriteLine("PERFIL CONSERVADOR!");
            else if (points / 5 >= 50 && points / 5 <= 75) Console.WriteLine("PERFIL MODERADO!");
            else if (points / 5 > 75) Console.WriteLine("PERFIL ARROJADO!");
        }
    }
}
