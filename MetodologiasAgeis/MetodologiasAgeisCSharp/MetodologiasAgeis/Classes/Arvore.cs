using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasAgeis.Classes
{
    public class Arvore : Jardim
    {
        public int Id { get; set; } // Identificador único da árvore
        public string Especie { get; set; } // Nome da espécie da árvore
        public double Altura { get; set; } // Altura da árvore em metros
        public double DiametroTronco { get; set; } // Diâmetro do tronco da árvore em metros
        public int Idade { get; set; } // Idade estimada da árvore em anos
        public string Localizacao { get; set; } // Localização da árvore dentro do jardim
        public List<string> HistoricoTratamentos { get; set; } // Histórico de tratamentos aplicados à árvore
        public string CondicaoSaude { get; set; } // Condição de saúde da árvore (por exemplo, saudável, doente)
        public Jardim Jardim { get; set; } // Referência ao jardim ao qual a árvore pertence

        public Arvore(int id, string especie, double altura, double diametroTronco, int idade, string localizacao, List<string> historicoTratamentos, string condicaoSaude, Jardim jardim)
        {
            Id = id;
            Especie = especie;
            Altura = altura;
            DiametroTronco = diametroTronco;
            Idade = idade;
            Localizacao = localizacao;
            HistoricoTratamentos = historicoTratamentos;
            CondicaoSaude = condicaoSaude;
            Jardim = jardim;
        }
    }
}
