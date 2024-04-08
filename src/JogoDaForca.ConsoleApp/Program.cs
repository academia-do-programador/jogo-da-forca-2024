namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // o jogo acaba quando quantidadeErros = 5;
            int quantidadeErros = 0;

            bool jogadorEnforcou = false;
            bool jogadorAcertou = false;

            // escolher uma palavra aleatória
            string palavraEscolhida = "MELANCIA";

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
            {
                letrasEncontradas[caractere] = '-';
            }

            do
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

                Console.WriteLine("\n" + string.Join("", letrasEncontradas));

                // usuário irá chutar uma letra
                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];

                // checa se a letra está na palavra
                bool letraFoiEncontrada = false;

                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    char letraAtual = palavraEscolhida[i];

                    // preenche o espaço da letra na palavra tracejada
                    if (chute == letraAtual)
                    {
                        letrasEncontradas[i] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                string palavraEncontrada = string.Join("", letrasEncontradas);

                jogadorAcertou = palavraEncontrada == palavraEscolhida;
                jogadorEnforcou = quantidadeErros >= 5;

                if (jogadorAcertou)
                    Console.WriteLine("\nVocê acertou a palavra secreta, parabéns!");

                else if (jogadorEnforcou)
                    Console.WriteLine("\nQue azar! Tente novamente!");

            } while (jogadorEnforcou == false && jogadorAcertou == false);

            Console.ReadLine();
        }
    }
}
