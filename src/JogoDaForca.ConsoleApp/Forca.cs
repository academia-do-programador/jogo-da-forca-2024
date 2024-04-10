using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    public class Forca
    {
        public int quantidadeErros = 0;
        public bool jogadorEnforcou = false;
        public bool jogadorAcertou = false;
        public char chute;
        public char[] letrasEncontradas;
        public string palavraEncontrada;
        public string palavraAchada;
        public char[] EscolherPalavra()
        {
            string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);
            palavraEncontrada = palavras[indiceEscolhido];
            letrasEncontradas = new char[palavras[indiceEscolhido].Length];

            for (int caractere = 0; caractere < palavraEncontrada.Length; caractere++)
            {
                Console.Write(letrasEncontradas[caractere] = '-');
            }
            palavraAchada = string.Join("", letrasEncontradas);
            return letrasEncontradas;
        }
        public char Chute()
        {
            Console.Write("Digite uma letra: ");

            chute = Console.ReadLine()[0];

            return chute;
        }
        public void Desenho()
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
        public bool JogadorPerdeu()
        {
            return quantidadeErros >= 5;
        }

        public bool JogadorAcertou()
        {
            string palavraEscolhida = null;
            return palavraEncontrada == palavraEscolhida;
        }

    }
}



