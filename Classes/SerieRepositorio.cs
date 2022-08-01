using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Series.Interfaces;

namespace Projeto.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualizar(int id, Serie Objeto)
        {
            listaSerie[id] = Objeto;
        }

        public void Excluir(int id)
        {   
            listaSerie[id].Excluir();
        }

        public void Inserir(Serie Objeto)
        {
            listaSerie.Add(Objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
           return listaSerie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}