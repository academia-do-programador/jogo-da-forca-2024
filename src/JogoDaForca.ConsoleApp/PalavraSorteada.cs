using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    internal class PalavraSorteada
    {
        #region Lista de Palavras
        string[] listaPalavras =
               {
                "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA",
                "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO",
                "MAÇÃ", "MANGABA", "MANGA","MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA",
                "UMBU", "UVA", "UVAIA"
               };
        #endregion

        //1 - Sortear um indice aleatorio
        #region Indice Aleatorio
        public int IndiceAleatorio()
        {
            //sorteando um indice aleatorio
            Random aleatorio = new Random();
            var indicePalavra = aleatorio.Next(0, listaPalavras.Length);
            return indicePalavra;
        }
        #endregion

        //2 - Selecionar a palavra aleatoria baseada no indice anterior
        #region Sorteando a Palavra
        public string SorteandoPalavra(int indice)
        {
            //salvando a palavra aleatoria em uma variavel
            var palavraSorteada = listaPalavras[indice];
            return palavraSorteada;
        }
        #endregion
        
        #region Separando a Palavra em m Array de Char
        public char[] SeparandoEmChar(string palavra)
        {
            //salvando as letras separadas
            return palavra.ToCharArray();
        }

        public char[] PegarLetrasJogo()
        {
            var indice = IndiceAleatorio();
            var palavra = SorteandoPalavra(indice);
            return SeparandoEmChar(palavra);
        }
        #endregion

    }
}
