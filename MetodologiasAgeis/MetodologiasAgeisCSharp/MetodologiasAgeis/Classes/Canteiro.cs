using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MetodologiasAgeis.Classes
{
    public class Canteiro : Jardim 
    {
        public int Id { get; set; }
        public string Localizacao { get; set; }
        public int JardimId { get; set; }
        public string ComposicaoCanteiro { get; set; }
        public float Area { get; set; }
        public float AreaSemeada { get; set; }
        public Arvore Arvore { get; set; }
    }
}

/*
 * 
 * 
 *  public int Id { get; set; }
        public string Localizacao { get; set; }
        public int JardimId { get; set; }
        public string ComposicaoCanteiro { get; set; }
        public float Area { get; set; }
        public float AreaSemeada { get; set; }
        public Arvore Arvore { get; set; }*/