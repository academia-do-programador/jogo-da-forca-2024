using System;
using System.Xml;

namespace Jogo_Da_Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            string palavraEscolhida = jogo.PalavraAleatoria();

            int erros = 0;

            char[] letrasCorretas = new char[palavraEscolhida.Length];

            jogo.CriaEspaços(letrasCorretas);

            string menu = jogo.MostrarMenu();
            Console.WriteLine(menu);

            while (true)
            {
                string palpite = jogo.LetrasDigitadas(letrasCorretas);

                bool letraAdv = false;

                letraAdv = jogo.Advinhar(palavraEscolhida, letrasCorretas, palpite, letraAdv);

                if (!letraAdv)
                {
                    erros++;
                    Console.Clear();
                    Console.WriteLine($"Errou! Erros: {erros}");
                    jogo.ForcaErros(erros);
                }

                jogo.Ganhou(palavraEscolhida, letrasCorretas);

                jogo.Perdeu(palavraEscolhida, erros);

                if (jogo.Ganhou(palavraEscolhida, letrasCorretas) || jogo.Perdeu(palavraEscolhida, erros))
                    break;
            }
        }
    }
}