using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {"ABACATE","ABACAXI","ACEROLA","AÇAÍ","ARAÇA","ABACATE","BACABA","BACURI","BANANA",
                    "CAJÁ","CAJÚ","CARAMBOLA","CUPUAÇU","GRAVIOLA","GOIABA","JABUTICABA","JENIPAPO","MAÇÃ","MANGABA",
                    "MANGA","MARACUJÁ","MURICI","PEQUI","PITANGA","PITAYA","SAPOTI","TANGERINA","UMBU","UVA","UVAIA"};

            Random random = new Random();

            int IndicePalavra = random.Next(0, palavras.Length);

            int erros = 0;

            string palavraEscolhida = palavras[IndicePalavra];

            char[] letrasCorretas = new char[palavraEscolhida.Length];

            for (int i = 0; i < letrasCorretas.Length; i++)
            {
                letrasCorretas[i] = '_';
            }

            Console.WriteLine("Seja Bem vindo(a) ao Jogo Da Forca!");
            Console.WriteLine("Você tem 5 chances");
            Console.WriteLine("----------");
            Console.WriteLine(" |/      |");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |        ");
            Console.WriteLine("-----");

            while (true)
            {
                Console.WriteLine($"\nPalavra: {string.Join(" ", letrasCorretas)}");

                Console.Write("\nDigite a próxima letra: ");
                string palpite = Console.ReadLine().ToUpper();

                bool letraAdv = false;

                for (int j = 0; j < palavraEscolhida.Length; j++)
                {
                    if (palpite == palavraEscolhida[j].ToString())
                    {
                        letraAdv = true;
                        letrasCorretas[j] = palpite[0];
                    }
                }

                if (!letraAdv)
                {
                    erros++;
                    Console.Clear();
                    Console.WriteLine($"Errou! Erros: {erros}");
                    switch (erros)
                    {
                        case 1:
                            Console.WriteLine("---------- ");
                            Console.WriteLine(" |/      | ");
                            Console.WriteLine(" |       O ");
                            Console.WriteLine(" |       x ");
                            Console.WriteLine(" |       x ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine("-----");
                            break;
                        case 2:
                            Console.WriteLine("----------  ");
                            Console.WriteLine(" |/      |  ");
                            Console.WriteLine(" |       O  ");
                            Console.WriteLine(" |       x  ");
                            Console.WriteLine(" |       x  ");
                            Console.WriteLine(" |      /   ");
                            Console.WriteLine(" |          ");
                            Console.WriteLine(" |          ");
                            Console.WriteLine(" |          ");
                            Console.WriteLine("-----");
                            break;
                        case 3:
                            Console.WriteLine("----------   ");
                            Console.WriteLine(" |/      |   ");
                            Console.WriteLine(" |       O   ");
                            Console.WriteLine(" |       x   ");
                            Console.WriteLine(" |       x   ");
                            Console.WriteLine(" |      / \\ ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine("-----");
                            break;
                        case 4:
                            Console.WriteLine("----------   ");
                            Console.WriteLine(" |/      |   ");
                            Console.WriteLine(" |       O   ");
                            Console.WriteLine(" |       x\\ ");
                            Console.WriteLine(" |       x   ");
                            Console.WriteLine(" |      / \\ ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine("-----");
                            break;
                        case 5:
                            Console.WriteLine("----------   ");
                            Console.WriteLine(" |/      |   ");
                            Console.WriteLine(" |       O   ");
                            Console.WriteLine(" |      /x\\ ");
                            Console.WriteLine(" |       x   ");
                            Console.WriteLine(" |      / \\ ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine(" |           ");
                            Console.WriteLine("-----");
                            break;
                        case 6:
                            Console.WriteLine("Você perdeu! Fim!");
                            break;
                    }
                }

                if (new string(letrasCorretas) == palavraEscolhida)
                {
                    Console.Clear();
                    Console.WriteLine($"Parabéns! Você acertou a palavra: {palavraEscolhida}!");
                    break;
                }

                if (erros >= 6)
                {
                    Console.Clear();
                    Console.WriteLine($"Você Perdeu! A palavra era: {palavraEscolhida}");
                    break;
                }
            }
        }
    }
}
