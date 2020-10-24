using Morgana.Domain.Core.Entities;

namespace Morgana.Domain.Entities.Vocabulario
{
    public class ClasseGramatical : EntityBase
    {
        //public int ID_CLASSE_GRAMATICAL { get; set; }
        public string DS_CLASSE_GRAMATICAL { get; set; }

        public virtual Idioma Idioma { get; set; }
    }
}
