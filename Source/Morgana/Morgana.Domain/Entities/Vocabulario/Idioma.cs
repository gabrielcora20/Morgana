using Morgana.Domain.Core.Entities;
using System.Collections.Generic;

namespace Morgana.Domain.Entities.Vocabulario
{
    public class Idioma : EntityBase
    {
        //public int ID_IDIOMA { get; set; }
        public string Descricao { get; set; }

        public virtual List<ClasseGramatical> ClassesGramaticais { get; set; }
    }
}
