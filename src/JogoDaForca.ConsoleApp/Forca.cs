namespace JogoDaForca.ConsoleApp
{
    public class Forca
    {
        public int quantidadeErros;

        public string palavraEscolhida;
        public char[] letrasEncontradas;

        public string mensagemFinal;

        public bool JogadorAcertou(char chute)
        {
            bool letraFoiEncontrada = false;

            for (int i = 0; i < palavraEscolhida.Length; i++)
            {
                char letraAtual = palavraEscolhida[i];

                if (chute == letraAtual)
                {
                    letrasEncontradas[i] = letraAtual;
                    letraFoiEncontrada = true;
                }
            }

            if (letraFoiEncontrada == false)
                quantidadeErros++;

            bool jogadorAcertou = string.Join("", letrasEncontradas) == palavraEscolhida;

            if (jogadorAcertou)
                mensagemFinal = "Você acertou a palavra secreta, parabéns!";

            else if (JogadorPerdeu())
                mensagemFinal = "Que azar! Tente novamente!";

            return jogadorAcertou;
        }

        public bool JogadorPerdeu()
        {
            return quantidadeErros >= 5;
        }

        public void EscolherPalavraAleatoria()
        {
            string[] palavras = {
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
                "BERGAMOTA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);

            palavraEscolhida = palavras[indiceEscolhido];
        }

        public void InicializarLetrasEncontradas()
        {
            letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
            {
                letrasEncontradas[caractere] = '-';
            }
        }
    }
}
