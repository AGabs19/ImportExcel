using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ImportExcel.Models
{
    public class Autorizacao
    {
        [Key()]
        public long Id { get; set; }
        public string? ObservacaoFuncionario { get; set; }
        public long IdGerente1 { get; set; }
        public string? ObservacaoGerente1 { get; set; }
        public bool StatusGerente1 { get; set; }
        public long IdGerente2 { get; set; }
        public string? ObservacaoGerente2 { get; set; }
        public bool StatusGerente2 { get; set; }
    }
}
