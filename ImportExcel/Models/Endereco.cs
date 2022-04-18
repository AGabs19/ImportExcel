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
        public int Id { get; set; }
        public string? Longadouro { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string? Complemento { get; set; }

    }
}