using tabuleiro;

namespace xadrez
{
    class Dama : Peca
    {
        public Dama(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "D";
        }
    }
}
