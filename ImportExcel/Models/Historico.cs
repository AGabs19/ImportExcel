using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImportExcel.Models
{
    public class Historico
    {
        [Key()]
        public long Id { get; set; }
        public long QuantidadeDeDias { get; set; }
        public bool Venda { get; set; }
        public DateTime UltimoPeriodo { get; set; }
    }
}
