using tabuleiro;

namespace xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            this.tab = new Tabuleiro(8, 8);
            this.turno = 1;
            this.jogadorAtual = Cor.Branca;
            this.Terminada = false;
            colocarPecas();
        }

        public void executaMotivmento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('a', 1).toPosicao());
            tab.colocarPeca(new Cavalo(Cor.Branca, tab), new PosicaoXadrez('b', 1).toPosicao());
            tab.colocarPeca(new Bispo(Cor.Branca, tab), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Rei(Cor.Branca, tab), new PosicaoXadrez('d', 1).toPosicao());
            tab.colocarPeca(new Dama(Cor.Branca, tab), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Bispo(Cor.Branca, tab), new PosicaoXadrez('f', 1).toPosicao());
            tab.colocarPeca(new Cavalo(Cor.Branca, tab), new PosicaoXadrez('g', 1).toPosicao());
            tab.colocarPeca(new Torre(Cor.Branca, tab), new PosicaoXadrez('h', 1).toPosicao());

            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('a', 2).toPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('b', 2).toPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('f', 2).toPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('g', 2).toPosicao());
            tab.colocarPeca(new Peao(Cor.Branca, tab), new PosicaoXadrez('h', 2).toPosicao());

            tab.colocarPeca(new Torre(Cor.Amarela, tab), new PosicaoXadrez('a', 8).toPosicao());
            tab.colocarPeca(new Cavalo(Cor.Amarela, tab), new PosicaoXadrez('b', 8).toPosicao());
            tab.colocarPeca(new Bispo(Cor.Amarela, tab), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Rei(Cor.Amarela, tab), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Dama(Cor.Amarela, tab), new PosicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Bispo(Cor.Amarela, tab), new PosicaoXadrez('f', 8).toPosicao());
            tab.colocarPeca(new Cavalo(Cor.Amarela, tab), new PosicaoXadrez('g', 8).toPosicao());
            tab.colocarPeca(new Torre(Cor.Amarela, tab), new PosicaoXadrez('h', 8).toPosicao());

            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('a', 7).toPosicao());
            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('b', 7).toPosicao());
            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('f', 7).toPosicao());
            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('g', 7).toPosicao());
            tab.colocarPeca(new Peao(Cor.Amarela, tab), new PosicaoXadrez('h', 7).toPosicao());
        }
    }
}
