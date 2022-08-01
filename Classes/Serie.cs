using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Series.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido {get; set;}

        public Serie(int id, Genero Genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Gênero: {this.Genero}{Environment.NewLine}";
            retorno += $"Titulo: {this.Titulo}{Environment.NewLine}";
            retorno += $"Descrição: {this.Descricao}{Environment.NewLine}";
            retorno += $"Ano de lançamento: {this.Ano}{Environment.NewLine}";
             retorno += $"Excluido: {this.Excluido}";
            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }
         public int RetornaId()
        {
            return this.Id;
        }
         public bool RetornaExcluir()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}