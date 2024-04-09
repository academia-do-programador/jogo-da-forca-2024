using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Da_Forca
{
    public class Jogo
    {
        public int indiceAleatorio;
        string[] palavras = {"ABACATE","ABACAXI","ACEROLA","AÇAÍ","ARAÇA","ABACATE","BACABA","BACURI","BANANA",
                    "CAJÁ","CAJÚ","CARAMBOLA","CUPUAÇU","GRAVIOLA","GOIABA","JABUTICABA","JENIPAPO","MAÇÃ","MANGABA",
                    "MANGA","MARACUJÁ","MURICI","PEQUI","PITANGA","PITAYA","SAPOTI","TANGERINA","UMBU","UVA","UVAIA"};

        public string MostrarMenu()
        {
            string menu =
                    "Seja Bem vindo(a) ao Jogo Da Forca!\n" +
                    "Você tem 5 chances\n" +
                    "----------\n" +
                    " |/      |\n" +
                    " |        \n" +
                    " |        \n" +
                    " |        \n" +
                    " |        \n" +
                    " |        \n" +
                    " |        \n" +
                    " |        \n" +
                    "-----\n";

            return menu;
        }

        public string PalavraAleatoria()
        {
            Random random = new Random();

            indiceAleatorio = random.Next(palavras.Length);

            return palavras[indiceAleatorio];
        }

        public void ForcaErros(int erros)
        {
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

        public bool Perdeu(string palavraEscolhida, int erros)
        {
            if (erros >= 6)
            {
                Console.Clear();
                Console.WriteLine($"Você Perdeu! A palavra era: {palavraEscolhida}");
                return true;
            }
            return false;
        }

        public bool Ganhou(string palavraEscolhida, char[] letrasCorretas)
        {
            if (new string(letrasCorretas) == palavraEscolhida)
            {
                Console.Clear();
                Console.WriteLine($"Parabéns! Você acertou a palavra: {palavraEscolhida}!");
                return true;
            }
            return false;
        }

        public string LetrasDigitadas(char[] letrasCorretas)
        {
            Console.WriteLine($"\nPalavra: {string.Join(" ", letrasCorretas)}");

            Console.Write("\nDigite a próxima letra: ");
            string palpite = Console.ReadLine().ToUpper();
            return palpite;
        }

        public bool Advinhar(string palavraEscolhida, char[] letrasCorretas, string palpite, bool letraAdv)
        {
            for (int j = 0; j < palavraEscolhida.Length; j++)
            {
                if (palpite == palavraEscolhida[j].ToString())
                {
                    letraAdv = true;
                    letrasCorretas[j] = palpite[0];
                }
            }

            return letraAdv;
        }

        public void CriaEspaços(char[] letrasCorretas)
        {
            for (int i = 0; i < letrasCorretas.Length; i++)
            {
                letrasCorretas[i] = '_';
            }
        }
    }
}
