using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Entities
{
    public class Membro
    {
       
        public int MembroId { get; set; }

        public string Nome { get; set; }
               
        public DateTime DataNascimento { get; set; }

        public DateTime DataEntradada { get; set; }

        public enum Sexo {
            Masculino, 
            Feminino
        }

        public Familia Pertence { get; set; }
        public int? FamiliaId { get; set; }

        public enum TipoEntrada
        {
            Aclamacao,
            Batismo
        }

       // public IEnumerable<Endereco> Endereco { get; set; }
    }
}
