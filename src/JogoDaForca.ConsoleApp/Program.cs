using System;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PalavraSorteada palavraSorteada = new PalavraSorteada();

            var palavra = palavraSorteada.PegarLetrasJogo();

            Jogo jogo = new Jogo();

            ExibirTitulo();

            var espacos = jogo.PreenchendoArrayUnline(palavra);

            while (jogo.vidas != 0)
            {

                char letraDigitada = jogo.CabecalhoJogo(espacos);

                jogo.RodaOJogo(palavra, letraDigitada, espacos);

                jogo.VerificaErro();

                jogo.VerificaAcerto(palavra, espacos);

                jogo.AtualizaAcertos();
            }
        }

        #region Exibir Titulo
        private static void ExibirTitulo()
        {
            Console.WriteLine("******************");
            Console.WriteLine("* Jogo da Forca! *");
            Console.WriteLine("******************");
        }
        #endregion
    }
}
