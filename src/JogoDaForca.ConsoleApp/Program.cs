namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forca forca1 = new Forca();
            do
            {
                forca1.Desenho();
                forca1.EscolherPalavra();
                forca1.Chute();

                bool letraFoiEncontrada = false;

                for (int i = 0; i < forca1.EscolherPalavra().Length; i++)
                {
                    char letraAtual = forca1.letrasEncontradas[i];

                    if (forca1.chute == letraAtual)
                    {
                        forca1.letrasEncontradas[i] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    forca1.quantidadeErros++;

                forca1.palavraEncontrada = string.Join("", forca1.letrasEncontradas);

                if (forca1.palavraEncontrada == forca1.palavraAchada)
                    Console.WriteLine("\nVocê acertou a palavra secreta, parabéns!");

                else if (forca1.quantidadeErros > 5)
                    Console.WriteLine("\nQue azar! Tente novamente!");

            } while (forca1.quantidadeErros > 5);

            Console.ReadLine();


        }
    }
}
