using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    internal class Jogo
    {
        public int vidas = 5;
        public int acertos = 0;
        public int acertosAnteriores = 0;
        #region Desenhando a Forca
        public void DesenhandoForca()
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

        #region Verifica se foi erro
        public void VerificaErro()
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

        #region Verifica se acertou a palavra completa
        public void VerificaAcerto(char[] letrasPalavra, char[] espacos)
        {
            int verificaPalavra = 0;

            for (int i = 0; i < letrasPalavra.Length; i++)
            {
                if (letrasPalavra[i] == espacos[i])
                {
                    verificaPalavra++;
                }
            }
            if (verificaPalavra == espacos.Length)
            {
                Console.WriteLine("\nVocê Adivinhou a Palavra, Parabéns!");
                vidas = 0;
            }
        }
        #endregion

        #region Atualiza o Numero de Acertos Anteriores
        public void AtualizaAcertos()
        {
            //atualiza os acertos anteriores para os atuais
            acertosAnteriores = acertos;
        }

        public char[] PreenchendoArrayUnline(char[] palavraSorteada)
        {
            int tamanho = palavraSorteada.Length;

            char[] arrayUnderline = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                arrayUnderline[i] = '_';
            }

            return arrayUnderline;
        }

        private void DesenhaBoneco()
        {
            switch (vidas)
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
                    break;
            }
        }

        public void RodaOJogo(char[] letrasPalavra,char letraDigitada, char[] espacos)
        {
            for (int j = 0; j < letrasPalavra.Length; j++)
            {
                if (letraDigitada == letrasPalavra[j])
                {
                    espacos[j] = letrasPalavra[j];
                    acertos++;
                }
            }
        }
        public char CabecalhoJogo(char[] espacos)
        {
            Console.WriteLine($"\nVidas Restantes: {vidas}");
            DesenhandoForca();
            Console.WriteLine(espacos);
            Console.WriteLine("\nDigite uma Letra Maiúscula Aleatoria: ");
            return char.Parse(Console.ReadLine().ToUpper());
        }
        #endregion
    }
}
