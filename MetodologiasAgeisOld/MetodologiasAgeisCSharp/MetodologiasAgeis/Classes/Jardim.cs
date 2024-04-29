using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasAgeis.Classes
{
    public class Jardim
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public string Descricao { get; set; }
        public double Area { get; set; }
        public string TopoGrafia { get; set; }
        public string EquipaResponsavel { get; set; } //dps
        public string CaractristicaCanteiros { get; set; }
        public List<Arvore> Arvores { get; set; }
    }
}
