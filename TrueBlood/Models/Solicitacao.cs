using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrueBlood.Models
{
    public class Solicitacao : BaseModel
    {
        public Paciente Paciente { get; set; }
        public Hospital Hospital { get; set; }
        public EnumTipoSangue TipoSangue { get; set; }
        public int QuantidadeBolsa { get; set; }
    }
}