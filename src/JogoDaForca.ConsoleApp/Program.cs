namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // escolher uma palavra aleatória
            string palavraEscolhida = "MELANCIA";

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
            {
                letrasEncontradas[caractere] = '-';
            }

            // usuário irá chutar uma letra
            Console.WriteLine("Digite uma letra ");
            char chute = Console.ReadLine()[0];

            // checa se a letra está na palavra
            for (int i = 0; i < palavraEscolhida.Length; i++)
            {
                char letraAtual = palavraEscolhida[i];

                // preenche o espaço da letra na palavra tracejada
                if (chute == letraAtual)
                    letrasEncontradas[i] = letraAtual;
            }

            Console.WriteLine(string.Join("", letrasEncontradas));

            // desenhar a forca

            // revelar o enforcado conforme o usuário erra

            Console.ReadLine();
        }
    }
}
