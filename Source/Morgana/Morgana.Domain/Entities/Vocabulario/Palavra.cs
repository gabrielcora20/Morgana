using Morgana.Domain.Core.Entities;
using System.Collections.Generic;

namespace Morgana.Domain.Entities.Vocabulario
{
    public class Palavra: EntityBase
    {
        //public int ID_PALAVRA { get; set; }
        public string Descricao { get; set; }

        public virtual ClasseGramatical ClasseGramatical { get; set; }
        public virtual List<Significado> Significados { get; set; }
    }
}
