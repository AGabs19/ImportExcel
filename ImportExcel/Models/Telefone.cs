using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImportExcel.Models
{
    public class Telefone
    {
        [Key()]
        public long Id { get; set; }
        public string? Descricao { get; set; }
        public long Numero { get; set; }
    }
}


