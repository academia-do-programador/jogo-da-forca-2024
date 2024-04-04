using System;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

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
        static string palavraSorteada;
        static int numeroEspacos;
        static int indicePalavra;
        static void Main(string[] args)
        {
            ExibirTitulo();

            indicePalavra = IndiceAleatorio();

            palavraSorteada = SorteandoPalavra(indicePalavra);

            SeparandoEmChar(palavraSorteada);

            numeroEspacos = ArrayDeUnderline();

            JogoCompleto();

            DesejaContinuar();
        }

        ///Jogo Completo desde a parte de Coleta de letras digitadas pelo usuário até a parte de calculo de pontuação
        ///Verificação de acertos e erros, desenho da forca e do boneco, etc.
        #region Jogo Completo
        private static void JogoCompleto()
        {
            //rodando enquando ainda tiver chances
            while (vidas != 0)
            {
                Console.WriteLine($"\nVidas Restantes: {vidas}");
                DesenhandoForca();
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

                VerificaErro();

                VerificaAcerto();

                AtualizaAcertos();
            }
        }
        #endregion

        private static void DesejaContinuar()
        {
            Console.WriteLine("Deseja Continuar? S/N");
            string continuar = Console.ReadLine();



            if(continuar == "S" || continuar == "s")
            {
                vidas = 5;
                ExibirTitulo();
                indicePalavra = IndiceAleatorio();
                palavraSorteada = SorteandoPalavra(indicePalavra);
                SeparandoEmChar(palavraSorteada);
                numeroEspacos = ArrayDeUnderline();
                JogoCompleto();
                DesejaContinuar();
            }
            else if(continuar == "N" || continuar == "n")
            {
                Environment.ExitCode = 0;
            }
        }

        #region Verifica se acertou a palavra completa
        private static void VerificaAcerto()
        {
            int verificaPalavra = 0;

            for(int i = 0; i < letrasPalavra.Length; i++)
            {
                if (letrasPalavra[i] == espacos[i])
                {
                    verificaPalavra++;
                }
            }
            if (verificaPalavra == numeroEspacos)
            {

                Console.WriteLine("\nVocê Adivinhou a Palavra, Parabéns!");
                Console.WriteLine($"A Palavra Escolhida era: {palavraSorteada}\n");
                vidas = 0;
            }
        }
        #endregion

        #region Verifica se foi erro
        private static void VerificaErro()
        {
            ///verificando se foi erro, neste caso eu verifico se o numero de acertos anteriores permanece o mesmo
            ///se continuar igual significa que o usuário errou, já que quando ele acerta é aumentada a variavel
            ///acertos
            if (acertosAnteriores == acertos)
            {
                Console.WriteLine("Voce errou, Tente Novamente!");
                vidas--;
            }
        }
        #endregion

        #region Desenhando a Forca
        private static void DesenhandoForca()
        {
            //Desenhando a Forca
            Console.WriteLine("\n __________");
            Console.WriteLine(" |/       |");
            DesenhaBoneco();
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____\n");
        }
        #endregion

        #region Desenha o Boneco
        private static void DesenhaBoneco()
        {
            switch(vidas)
            {
                case 5:
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    break;
                case 4:
                    Console.WriteLine(" |        O");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    break;
                case 3:
                    Console.WriteLine(" |        O");
                    Console.WriteLine(" |        X");
                    Console.WriteLine(" |");
                    break;
                case 2:
                    Console.WriteLine(" |        O");
                    Console.WriteLine(" |       [X] ");
                    Console.WriteLine(" |");
                    break;
                case 1:
                    Console.WriteLine(" |        O");
                    Console.WriteLine(" |       [X] ");
                    Console.WriteLine(" |        X");
                    break;
                default:
                    Console.WriteLine();
                    break ;
            }
        }
        #endregion

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
