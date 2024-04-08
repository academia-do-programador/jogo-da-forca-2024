using System;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tentativas = 0;
            int erro = 0;
            Random palavraForca = new Random();
            int escolhePalavra = palavraForca.Next(1, 29);
            string palavraEscolhida = "";
            switch (escolhePalavra)
            {
                case 1:
                    palavraEscolhida = "ABACATE";
                    break;

                case 2:
                    palavraEscolhida = "ABACAXI";
                    break;

                case 3:
                    palavraEscolhida = "ACEROLA";
                    break;

                case 4:
                    palavraEscolhida = "AÇAÍ";
                    break;

                case 5:
                    palavraEscolhida = "ARAÇA";
                    break;

                case 6:
                    palavraEscolhida = "BACABA";
                    break;

                case 7:
                    palavraEscolhida = "BACURI";
                    break;

                case 8:
                    palavraEscolhida = "BANANA";
                    break;

                case 9:
                    palavraEscolhida = "CAJÁ";
                    break;

                case 10:
                    palavraEscolhida = "CAJÚ";
                    break;

                case 11:
                    palavraEscolhida = "CARAMBOLA";
                    break;

                case 12:
                    palavraEscolhida = "CUPUAÇU";
                    break;

                case 13:
                    palavraEscolhida = "GRAVIOLA";
                    break;

                case 14:
                    palavraEscolhida = "GOIABA";
                    break;

                case 15:
                    palavraEscolhida = "JABUTICABA";
                    break;

                case 16:
                    palavraEscolhida = "JENIPAPO";
                    break;

                case 17:
                    palavraEscolhida = "MAÇÃ";
                    break;

                case 18:
                    palavraEscolhida = "MANGABA";
                    break;

                case 19:
                    palavraEscolhida = "MANGA";
                    break;

                case 20:
                    palavraEscolhida = "MARACUJÁ";
                    break;

                case 21:
                    palavraEscolhida = "MURICI";
                    break;

                case 22:
                    palavraEscolhida = "PEQUI";
                    break;

                case 23:
                    palavraEscolhida = "PITANGA";
                    break;

                case 24:
                    palavraEscolhida = "PITAYA";
                    break;

                case 25:
                    palavraEscolhida = "SAPOTI";
                    break;

                case 26:
                    palavraEscolhida = "TANGERINA";
                    break;

                case 27:
                    palavraEscolhida = "UMBU";
                    break;

                case 28:
                    palavraEscolhida = "UVA";
                    break;

                case 29:
                    palavraEscolhida = "UVAIA";
                    break;
            }

            Console.WriteLine("BEM VINDO A FORCA 2024");
            Console.WriteLine(" ___________ ");
            Console.WriteLine(" |/        | ");
            Console.WriteLine(" |           ");
            Console.WriteLine(" |           ");
            Console.WriteLine(" |           ");
            Console.WriteLine(" |           ");
            Console.WriteLine(" |           ");
            Console.WriteLine(" |           ");
            Console.WriteLine("_|____       ");

            char[] palavraEscondida = esconderPalavra(palavraEscolhida);
            while (tentativas != 0)
            {
                
                Console.Write(palavraEscondida);
                Console.WriteLine("\nDigite uma letra: ");
                char letra = char.ToUpper(Console.ReadLine()[0]);
                if (palavraEscolhida.Contains(letra))
                {
                    for (int i = 0; i < palavraEscolhida.Length; i++)
                    {
                        if (palavraEscolhida[i] == letra)
                        {
                            palavraEscondida[i] = letra;
                        }
                        else 
                        {
                            tentativas--;
                        }

                    }
                }
                if (string.Join("", palavraEscondida) == palavraEscolhida)
                {
                    Console.WriteLine("Parabéns, você acertou a palavra!!");
                }
               

            }
            
Console.ReadKey();




            //switch (erro)
            //{
            //    case erro = 1;
            //        {
            //            Console.WriteLine(" ___________ ");
            //            Console.WriteLine(" |/        | ");
            //            Console.WriteLine(" |         O ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine("_|____       ");
            //            break;
            //        }
            //    case erro = 2;
            //        {
            //            Console.WriteLine(" ___________ ");
            //            Console.WriteLine(" |/        | ");
            //            Console.WriteLine(" |         O ");
            //            Console.WriteLine(" |         X ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine("_|____       ");
            //        }
            //    case erro = 3;
            //        {
            //            Console.WriteLine(" ___________ ");
            //            Console.WriteLine(" |/        | ");
            //            Console.WriteLine(" |         O ");
            //            Console.WriteLine(" |         X ");
            //            Console.WriteLine(" |         X ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine("_|____       ");
            //        }
            //    case erro = 4;
            //        {
            //            Console.WriteLine(" ___________ ");
            //            Console.WriteLine(" |/        | ");
            //            Console.WriteLine(" |         O ");
            //            Console.WriteLine(" |        /X ");
            //            Console.WriteLine(" |         X ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine("_|____       ");
            //        }
            //    case erro = 5;
            //        {
            //            Console.WriteLine(" ___________ ");
            //            Console.WriteLine(" |/        | ");
            //            Console.WriteLine(" |         O ");
            //            Console.WriteLine(" |        /X\\ ");
            //            Console.WriteLine(" |         X ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine(" |           ");
            //            Console.WriteLine("_|____       ");
            //            Console.WriteLine("GAME OVER A PALAVRA ERA: " + palavraEscolhida);
            //        }

        }

        public static char[] esconderPalavra(string palavraEscolhida)
        {
            char[] palavraEscondida = palavraEscolhida.ToCharArray();
            for (int i = 0; i < palavraEscondida.Length; i++)
            {
                palavraEscondida[i] = '_';
            }
            return palavraEscondida;


        }
    }
    
}
    





        
    


