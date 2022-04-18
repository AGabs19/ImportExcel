using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImportExcel.Models
{
    public class PeriodoAquisitivo
    {
        [Key()]
        public int Id { get; set; }
        public DateTime DataDaContratacao { get; set; }
        public DateTime UltimoPeriodo { get; set; }
    }
}
