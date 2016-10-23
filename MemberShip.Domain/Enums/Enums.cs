using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Enums
{
    public class Enums
    {
        public enum TipoEntrada
        {
            [Description("Aclamação")]
            Aclamacao,
            [Description("Batismo")]
            Batismo
        }
    }
}
