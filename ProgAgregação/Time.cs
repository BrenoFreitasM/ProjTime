using System;
using System.Collections.Generic;
using System.Text;

namespace ProjFutebol_01
{
    class Time
    {
        /*Atributos*/
        private string nome;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empates;
        private List<Jogador> Jogadores;

        /* Construtor */
        public Time(string Nome)
        {
            this.nome = nome;
            this.vitorias = 0;
            this.derrotas = 0;
            this.empates = 0;
            this.Jogadores = new List<Jogador>();
        }

        /* metodos */
        public string Nome
        {
            get { return nome; }
        }
        public string getStatus()
        {
            return "O status do Time " + this.Nome +
                "é Vitorias: " + this.Vitorias +
                "\tDerrotas: " + this.Derrotas +
                "\tEmpates: " + this.Empates;
        }
        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }
        public Int32 Derrotas
        {
        get { return derrotas; }
            set { derrotas += value; }
        }
        public Int32 Empates
        {
            get { return empates;}
            set { empates += value; }
         }
        public void contratarJogador(Jogador J)
        {
            this.Jogadores.Add(J);
        }
        private string demitirJogador(Jogador J)
        {
            int buscaJogador = this.Jogadores.IndexOf(J);

            string strRetorno = "Jogador" + J.getNome();
            if (buscaJogador != -1)
            {
                this.Jogadores.RemoveAt(buscaJogador);
                return strRetorno + " demitido. ";
            }
            return " Não foi possível demitir " + strRetorno;
        }

        private Jogador getJogador(int camisa)
        {
            return Jogadores.Find(J => J.getCamisa().Equals(camisa));
        }

        public void gol(int camisa)
        {
            this.getJogador(camisa).Gols = 1;
        }

        public void getDescricaoJogadores()
        {
            foreach (Jogador jog in Jogadores){
                Console.WriteLine(jog.getDescricao()) ;
            }
        }
    }
}
