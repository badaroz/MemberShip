using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Enums
{
    public class EnumsMembros
    {
        public enum TipoEntradaEnum
        {
            [Description("Aclamação")]
            Aclamacao,
            [Description("Batismo")]
            Batismo
        }

        public enum SexoEnum
        {
            Masculino,
            Feminino
        }
    }
}
