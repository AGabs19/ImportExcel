namespace ImportExcel.Models
{
    public class ExcelModel //É o que eu quero que apareça na tela de leitura da page!
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public long CPF { get; set; }
        public long Numero { get; set; }
        public string Descricao { get; set; }
        public string Longadouro { get; set; }
        public long NumeroCasa { get; set; }
        public long CEP { get; set; }
        public string Complemento { get; set; }
        public string Cargo { get; set; }
    }
}
