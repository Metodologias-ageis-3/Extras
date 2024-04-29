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
        public int Id { get; set; } // Identificador único do jardim
        public string Nome { get; set; } // Nome do jardim
        public string Localizacao { get; set; } // Localização do jardim
        public string Descricao { get; set; } // Descrição do jardim
        public double Area { get; set; } // Área do jardim em metros quadrados
        public string TopoGrafia { get; set; } // Descrição do topo da grafia do jardim
        public string EquipaResponsavel { get; set; } // Nome da equipe responsável pelo jardim
        public string CaractristicaCanteiros { get; set; } // Características dos canteiros do jardim
        public List<Arvore> Arvores { get; set; } // Lista de árvores presentes  no jardim
    }  
}
