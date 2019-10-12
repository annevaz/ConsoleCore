using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1() { }
        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string Chuta()
        {
            return $"{_Nome} está Chutando";
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo";
        }
        public string Passe()
        {
            return $"{_Nome} está Passendo";
        }        
    }
}