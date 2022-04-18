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
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Double Salario { get; set; }
        public Cargo? Cargo { get; set; }
        public int CargoId { get; set; }
        public virtual Funcionario? Funcionario { get; set; }
        public int FuncionarioId { get; set; }

        //int id expediente .. fk
        //int id modalidade cargo.. fk
    }
}
