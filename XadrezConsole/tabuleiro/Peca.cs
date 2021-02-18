namespace tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tab = tab;
            this.QteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        protected bool podeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
