using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImportExcel.Models
{
    public class Endereco
    {
        [Key()]
        public long Id { get; set; }
        public string? Longadouro { get; set; }
        public long NumeroCasa { get; set; }
        public long CEP { get; set; }
        public string? Complemento { get; set; }

    }
}
