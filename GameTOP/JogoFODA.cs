using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }
        public void IniciarJogo()
        {
            //System.Console.WriteLine($"{_jogador._Nome} deu um passe");
            Console.WriteLine(_jogadorA.Chuta());
            Console.WriteLine(_jogadorA.Corre());
            Console.WriteLine(_jogadorA.Passe());

            Console.WriteLine("PRÓXIMO JOGADOR");

            Console.WriteLine(_jogadorB.Chuta());
            Console.WriteLine(_jogadorB.Corre());
            Console.WriteLine(_jogadorB.Passe());
        }        
    }
}