using Morgana.Domain.Core.Entities;
using System.Collections.Generic;

namespace Morgana.Domain.Entities.Vocabulario
{
    public class Significado : EntityBase
    {
        //public int ID_SIGNIFICADO { get; set; }
        public string Descricao { get; set; }
        public virtual AreaConhecimento AreaConhecimento { get; set; }
    }
}
