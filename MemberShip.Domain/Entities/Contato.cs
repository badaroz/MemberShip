using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Entities
{
   public class Contato
    {
        public long ContatoId  { get; set; }

        public long MembroId { get; set; }
        public virtual Membro Membro { get; set; }

        public string Tipo { get; set; }
        public string Descricao { get; set; }

    }
}
