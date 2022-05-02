using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImportExcel.Models
{
    public class Contrato
    {
        [Key()]
        public long Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Double Salario { get; set; }
        public virtual Cargo? Cargo { get; set; }
        //public long CargoId { get; set; }
        public virtual Funcionario? Funcionario { get; set; }
        //public long FuncionarioId { get; set; }
    }
}
