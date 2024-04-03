using System;
using System.ComponentModel.Design;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        #region Lista de Palavras
        static string[] listaPalavras =
               {
                "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA",
                "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO",
                "MAÇÃ", "MANGABA", "MANGA","MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA",
                "UMBU", "UVA", "UVAIA"
               };
        #endregion

        static char[] espacos;
        static char[] letrasPalavra;
        static int vidas = 5;
        static int acertos;
        static int acertosAnteriores;

        static void Main(string[] args)
        {
            ExibirTitulo();

            int indicePalavra = IndiceAleatorio();

            string palavraSorteada = SorteandoPalavra(indicePalavra);

            SeparandoEmChar(palavraSorteada);

            int numeroEspacos = ArrayDeUnderline();

            //rodando enquando ainda tiver chances
            while (vidas != 0)
            {
                Console.WriteLine($"\nVidas Restantes: {vidas}");
                Console.WriteLine(espacos);

                Console.WriteLine("\nDigite uma Letra Maiúscula Aleatoria: ");
                char letraDigitada = char.Parse(Console.ReadLine().ToUpper());

                for (int j = 0; j < letrasPalavra.Length; j++)
                {
                    if (letraDigitada == letrasPalavra[j])
                    {
                        espacos[j] = letrasPalavra[j];
                        acertos++;
                    }

                }

                ///verificando se foi erro, neste caso eu verifico se o numero de acertos anteriores permanece o mesmo
                ///se continuar igual significa que o usuário errou, já que quando ele acerta é aumentada a variavel
                ///acertos
                if (acertosAnteriores == acertos)
                {
                    Console.WriteLine("Voce errou, Tente Novamente!");
                    vidas--;
                }

                //verifica se o usuário acertou todas as letras
                if (acertos == numeroEspacos)
                {
                    Console.WriteLine("Voce Adivinhou a Palavra, Parabéns!");
                    break;
                }

                AtualizaAcertos();
            }

            #region Desenhando a Forca
            ////Desenhando a Forca
            //Console.WriteLine("\n-------------------");
            //Console.WriteLine("|/                |");
            //Console.Write("|");
            #endregion
        }

        #region Exibir Titulo
        private static void ExibirTitulo()
        {
            Console.WriteLine("******************");
            Console.WriteLine("* Jogo da Forca! *");
            Console.WriteLine("******************");
        }
        #endregion

        #region Indice Aleatorio
        private static int IndiceAleatorio()
        {
            //sorteando um indice aleatorio
            Random aleatorio = new Random();
            int indicePalavra = aleatorio.Next(0, listaPalavras.Length);
            return indicePalavra;
        }
        #endregion

        #region Sorteando a Palavra
        private static string SorteandoPalavra(int indicePalavra)
        {
            //salvando a palavra aleatoria em uma variavel
            string palavraSorteada = listaPalavras[indicePalavra];
            Console.WriteLine($"A Palavra Escolhida era: {palavraSorteada}");
            return palavraSorteada;
        }
        #endregion

        #region Separando a Palavra em m Array de Char
        private static void SeparandoEmChar(string palavraSorteada)
        {
            //salvando as letras separadas
            letrasPalavra = palavraSorteada.ToCharArray();
        }
        #endregion

        #region Preenche o array de espaços com underline
        private static int ArrayDeUnderline()
        {
            //pegando a quantidade de _ necessarios baseado no tamanho da palavra
            int numeroEspacos = letrasPalavra.Length;

            //criando o array com os tamanho certo da palavra
            espacos = new char[numeroEspacos];

            //preenchendo com underline
            for (int i = 0; i < numeroEspacos; i++)
            {
                espacos[i] = '_';
            }

            return numeroEspacos;
        }
        #endregion

        #region Atualiza o Numero de Acertos Anteriores
        private static void AtualizaAcertos()
        {
            //atualiza os acertos anteriores para os atuais
            acertosAnteriores = acertos;
        }
        #endregion
    }
}
