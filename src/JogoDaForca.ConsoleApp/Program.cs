namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forca forca = new Forca();

            forca.EscolherPalavraAleatoria();
            forca.InicializarLetrasEncontradas();

            while (true)
            {
                DesenharForca(forca.quantidadeErros);

                ExibirLetrasEncontradas(forca.letrasEncontradas);

                char chute = ObterChute();

                if (forca.JogadorAcertou(chute) || forca.JogadorPerdeu())
                {
                    Console.WriteLine(forca.mensagemFinal);
                    break;
                }
            };

            Console.ReadLine();
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
    }
}
