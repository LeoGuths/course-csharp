using tabuleiro;

namespace xadrez
{
    public class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.Coluna = coluna;
            this.Linha = linha;
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
    }
}
