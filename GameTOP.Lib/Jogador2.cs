using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "O outro jogador está chutando";
        }

        public string Corre()
        {
            return "O outro jogador está correndo";
        }

        public string Passe()
        {
            return "O outro jogador está dando um passe";
        }
    }
}