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
                Console.Clear();

                Console.WriteLine(string.Join("", letrasEncontradas));

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

                // desenhar a forca

                // revelar o enforcado conforme o usuário erra
            } while (jogadorEnforcou == false && jogadorAcertou == false);

            Console.ReadLine();
        }
    }
}
