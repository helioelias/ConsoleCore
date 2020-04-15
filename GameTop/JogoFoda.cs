using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly iJogador _Jogador;

        public JogoFoda(iJogador jogador){
            _Jogador = jogador;
        }

        public void IniciarJogo(){
            _Jogador.Corre();
            _Jogador.Chuta();
            _Jogador.Passe();
        }
    }
}