﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjFutebol_01
{
    public class Jogador
    {
        private string nome;
        private int idade;
        private int habilidade;
        private int camisa;
        private int gols;

        public Jogador(string pNome, int pIdade, int pHab, int pCamisa)
        {
            this.nome = pNome;
            this.idade = pIdade;
            this.habilidade = pHab;
            // ???????  = pCamisa;
        }

        public string getNome()
        {
            return nome;
        }

        public int getCamisa()
        {
            return camisa;
        }
        public int getHabilidade()
        {
            return habilidade;
        }
        public int Gols
        {
            get { return gols; }
            set { gols += value; }
        }
        public string getDescricao()
        {
            return "Nome: " + this.getNome() +
                   "\tIdade: " + this.idade +
                   "\tHabil.: " + this.habilidade +
                   "\tCamisa: " + this.camisa +
                   "\tGols: " + this.gols;
        }
    }
}
