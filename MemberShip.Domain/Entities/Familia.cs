using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Entities
{
    public class Familia
    {
        public int FamiliaId { get; set; }
        public ICollection<Membro> Membros{ get; set; }

        public Membro Responsavel { get; set; }
        public int MembroId { get; set; }
    }
}
