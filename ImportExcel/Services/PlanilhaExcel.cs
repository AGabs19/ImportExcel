using AppContext = ImportExcel.DataBase.AppContext;
using ImportExcel.Models;
using OfficeOpenXml;
using Ganss.Excel;

namespace ImportExcel.Services
{
    public class PlanilhaExcel : IPlanilhaExcel
    {
        private readonly AppContext conexao;

        public PlanilhaExcel(AppContext conexao) //To chamando minha conexao com o banco de dados
        {
            this.conexao = conexao;
        }
        private Stream AbrirExcel(IFormFile arquivo) ///private Stream AbrirExcel
        {
            var stream = arquivo.OpenReadStream(); //Convertendo em Stream

            //Organizei como eu quero que meu arquivo Excel seja lido 
            var planilhaExcel = new ExcelMapper(arquivo.OpenReadStream()).Fetch<ExcelModel>(); //Usando o Excel Mapper

            foreach (var linha in planilhaExcel) //Optei por usar o FirstOurDefault
            {
                Funcionario funcionario = this.conexao.Funcionario.FirstOrDefault(x => x.CPF == linha.CPF);
                if (funcionario == null)
                {
                    funcionario = new Funcionario();

                    funcionario.Nome = linha.Nome;
                    funcionario.Sobrenome = linha.Sobrenome;
                    funcionario.CPF = linha.CPF;

                    this.conexao.Funcionario.Add(funcionario);
                }

                Telefone telefone = this.conexao.Telefone.FirstOrDefault(x => x.Numero == linha.Numero);
                if (telefone == null)
                {
                    telefone = new Telefone();

                    telefone.Numero = linha.Numero;
                    telefone.Descricao = linha.Descricao;

                    this.conexao.Telefone.Add(telefone);
                }

                Endereco endereco = this.conexao.Endereco.FirstOrDefault(x => x.NumeroCasa == linha.NumeroCasa);
                if (endereco == null)
                {
                    endereco = new Endereco();

                    endereco.Longadouro = linha.Longadouro;
                    endereco.NumeroCasa = linha.NumeroCasa;
                    endereco.CEP = linha.CEP;
                    endereco.Complemento = linha.Complemento;

                    this.conexao.Endereco.Add(endereco);
                }

                Cargo cargo = this.conexao.Cargo.FirstOrDefault(x => x.Tipo == linha.Cargo);
                if (cargo == null)
                {
                    cargo = new Cargo();

                    cargo.Tipo = linha.Cargo;

                    this.conexao.Cargo.Add(cargo);

                }
                this.conexao.SaveChanges();
            }
            return stream;
        }
        public string SalvarExcel(IFormFile arquivo)
        {
            Stream arquivoaberto = AbrirExcel(arquivo);
            if (arquivo == null)
            {
                return "o arquivo não possui dados";
            }
            //Quero acrescentar a validação dos dados preciso fazer alterções!
            return "ok";
        }
    }
}