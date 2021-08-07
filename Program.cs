using System;

namespace sistemaEspecialista
{
    class Program
    {
        static void Main(string[] args)
        {
            static int contadorPerguntas = 1;
            static int arrojado = 0;
            static int moderado = 0;
            static int conservador = 0;

            opcaoPerguntas(contadorPerguntas);
            
            static void menuPergunta1() {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("Digite 1 para:");
                Console.WriteLine("Variar os investimentos.");
                Console.WriteLine("Digite 2 para:");
                Console.WriteLine("Arriscar é fundamental.");
                Console.WriteLine("Digite 3 para:"); 
                Console.Write("Quero segurança, não me importo com o prazo.");            
            }

            static void menuPergunta2() {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("Digite 1 para:");
                Console.WriteLine("Ganhar acima da inflação, com renda.");
                Console.WriteLine("Digite 2 para:");
                Console.WriteLine("Proteger meu dinheiro e não perder.");
                Console.WriteLine("Digite 3 para:"); 
                Console.Write("Aumentar o meu capital.");         
            }

            static void menuPergunta3() {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("Digite 1 para:");
                Console.WriteLine("Rentabilidade.");
                Console.WriteLine("Digite 2 para:");
                Console.WriteLine("Diversificação e ganhos.");
                Console.WriteLine("Digite 3 para:"); 
                Console.Write("Segurança.");   
            }

            static void menuPergunta4() {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("Digite 1 para:");
                Console.WriteLine("Conheço e já investi em renda variável.");
                Console.WriteLine("Digite 2 para:");
                Console.WriteLine("Já ouvi sobre Tesouro e CDB.");
                Console.WriteLine("Digite 3 para:"); 
                Console.Write("Invisto rotineiramente na bolsa.");       
            }

            static void menuPergunta5() {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("Digite 1 para:");
                Console.WriteLine("Posso correr algum risco pequeno.");
                Console.WriteLine("Digite 2 para:");
                Console.WriteLine("Vejo como oportunidade de aumentar ganhos.");
                Console.WriteLine("Digite 3 para:"); 
                Console.Write("Sou totalmente avesso.");
            }

            static void contadorPerfil() {

                int opcao = Int32.Parse(Console.ReadLine());

                switch(opcao) {
                    case 1:
                        arrojado += 10;
                        break;
                    case 2:
                        moderado += 20;
                        break;
                    case 3:
                        conservador += 30;
                        break;
                    default:
                        Console.WriteLine("Essa opcao não está dentro do range, tente novamente:");
                        opcaoPerguntas(contadorPerguntas);
                        break;
                }        
            }            
                                                                         
            static void opcaoPerguntas(int contadorPerguntas) {
                do {
                    switch(contadorPerguntas) {
                    case 1:
                        Console.WriteLine("Quando tem planos para o dinheiro render, costumar pensar em:");
                        menuPergunta1();
                        contadorPerfil();
                        contadorPerguntas++;
                        break;
                    case 2:
                        Console.WriteLine("Qual seu objetivo ao investir?");
                        menuPergunta2();
                        contadorPerfil();
                        contadorPerguntas++;
                        break;
                    case 3:
                        Console.WriteLine("Quais suas prioridades?");
                        menuPergunta3();
                        contadorPerfil();
                        contadorPerguntas++;
                        break;
                    case 4:
                        Console.WriteLine("O que vc sabe sobre o mercado de investimentos?");
                        menuPergunta4();
                        contadorPerfil();
                        contadorPerguntas++;
                        break;
                    case 5:
                        Console.WriteLine("Como reage diante de riscos?");
                        menuPergunta5();
                        contadorPerfil();
                        contadorPerguntas++;
                        break;
                    }
                }while(contadorPerguntas <= 5);
            }
            
            Console.WriteLine($"Perfil arrojado tem {arrojado} pontos.");
            Console.WriteLine($"Perfil moderado tem {moderado} pontos.");
            Console.WriteLine($"Perfil conservador tem {conservador} pontos.");

        }
    }
}
                 
