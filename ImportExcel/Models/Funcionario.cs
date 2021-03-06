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
		public long Id { get; set; }
		public string? Nome { get; set; }
		public string? Sobrenome { get; set; }
		public long CPF { get; set; }
		public virtual Telefone? Telefone { get; set; }
		//public long TelefoneId { get; set; }
		public virtual Endereco? Endereco { get; set; }
		//public long EnderecoId { get; set; }
	}
}

