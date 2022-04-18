using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImportExcel.Models
{
	public class Funcionario
	{
		[Key()]
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? Sobrenome { get; set; }
		public int CPF { get; set; }
		public virtual Telefone? Telefone { get; set; }
		public int TelefoneId { get; set; }
		public virtual Endereco? Endereco { get; set; }
		public int EnderecoId { get; set; }
	}
}

