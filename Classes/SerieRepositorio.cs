using System;
using System.Collections.Generic;
using System.Linq;
using Cad.Series.Interfaces;

namespace Cad.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            var _serie = listaSerie.FirstOrDefault(o => o.Id == id);
            if (_serie is null)
                return;

            listaSerie[listaSerie.IndexOf(_serie)] = objeto;
        }

        public void Exclui(int id)
        {
            var _serie = listaSerie.FirstOrDefault(o => o.Id == id);
            if (_serie is null)
                return;

            listaSerie.Remove(_serie);
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie.FirstOrDefault(o => o.Id == id);
        }
    }
}