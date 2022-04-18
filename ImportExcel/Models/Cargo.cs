using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImportExcel.Models
{
    public class Cargo
    {
        [Key()]
        public int Id { get; set; }
        public String? Tipo { get; set; }
    }
}
