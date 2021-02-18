using tabuleiro;

namespace xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0,0);

            // Acima
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Nordeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Sudeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Sudoeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Noroeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            return mat;
        }
    }
}
