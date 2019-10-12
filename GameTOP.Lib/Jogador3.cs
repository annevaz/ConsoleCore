using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Terceiro jogador chuta";
        }

        public string Corre()
        {
            return "Terceiro jogador corre";
        }

        public string Passe()
        {
            return "Terceiro jogador passa";
        }
    }
}