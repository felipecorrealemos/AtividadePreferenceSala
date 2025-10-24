using AtividadePreferenceSala.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePreferenceSala.Components.Services
{
    public class AtividadeService
    {
        private int LIMITE = 5;

        public List<Atividade> Carregar()
        {
            var lista = new List<Atividade>();

            for (int i = 1; i <= LIMITE; i++)
            {
                var nome = Preferences.Get($"Atividade{i}", "");

                if (!string.IsNullOrEmpty(nome))
                {
                    lista.Add(new Atividade { nome = nome });
                }
            }

            return lista;
        }


    }
}
