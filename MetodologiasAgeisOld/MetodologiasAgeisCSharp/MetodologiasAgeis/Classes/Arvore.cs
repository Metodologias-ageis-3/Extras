using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasAgeis.Classes
{
    public class Arvore : Jardim
    {
        

        public int Id { get; set; }
        public string Especie { get; set; }
        public double Altura { get; set; }
        public double DiametroTronco { get; set; }
        public int Idade { get; set; }
        public string Localizacao { get; set; }
        public List<string> HistoricoTratamentos { get; set; }
        public string CondicaoSaude { get; set; }
        public Jardim Jardim { get; set; }
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
