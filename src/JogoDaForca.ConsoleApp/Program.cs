namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeErros = 0;

            bool jogadorEnforcou = false;
            bool jogadorAcertou = false;

            string palavraEscolhida = EscolherPalavraAleatoria();

            char[] letrasEncontradas = InicializarLetrasEncontradas(palavraEscolhida);

            string palavraEncontrada;

            do
            {
                DesenharForca(quantidadeErros);

                ExibirLetrasEncontradas(letrasEncontradas);

                char chute = ObterChute();

                bool letraFoiEncontrada = false;

                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    char letraAtual = palavraEscolhida[i];

                    if (chute == letraAtual)
                    {
                        letrasEncontradas[i] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                palavraEncontrada = string.Join("", letrasEncontradas);

                if (JogadorAcertou(palavraEscolhida, palavraEncontrada))
                    Console.WriteLine("\nVocê acertou a palavra secreta, parabéns!");

                else if (JogadorPerdeu(quantidadeErros))
                    Console.WriteLine("\nQue azar! Tente novamente!");

            } while (JogadorAcertou(palavraEscolhida, palavraEncontrada) == false && JogadorPerdeu(quantidadeErros) == false);

            Console.ReadLine();
        }

        private static bool JogadorPerdeu(int quantidadeErros)
        {
            return quantidadeErros >= 5;
        }

        private static bool JogadorAcertou(string palavraEscolhida, string palavraEncontrada)
        {
            return palavraEncontrada == palavraEscolhida;
        }

        private static char ObterChute()
        {
            Console.Write("Digite uma letra: ");

            char chute = Console.ReadLine()[0];

            return chute;
        }

        private static void ExibirLetrasEncontradas(char[] letrasEncontradas)
        {
            Console.WriteLine("\n" + string.Join("", letrasEncontradas));
        }

        private static void DesenharForca(int quantidadeErros)
        {
            string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
            string tronco = quantidadeErros >= 2 ? "x" : " ";
            string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
            string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
            string bracoDireito = quantidadeErros >= 3 ? @"\" : " ";
            string pernas = quantidadeErros >= 4 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }

        private static char[] InicializarLetrasEncontradas(string palavraEscolhida)
        {
            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
            {
                letrasEncontradas[caractere] = '-';
            }

            return letrasEncontradas;
        }

        private static string EscolherPalavraAleatoria()
        {
            string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);

            return palavras[indiceEscolhido];
        }
    }
}
