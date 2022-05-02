/*using DocumentFormat.OpenXml.Office2010.Excel;
using ImportExcel.Models;
using OfficeOpenXml;
using AppContext = ImportExcel.DataBase.AppContext;
using System.IO;

namespace ImportExcel
{
    public class Planilha
    {
        public Planilha()
        {
            //string sFileName = @"Ferias.xls";
        }

        public void Main(string[] args) 
        {
            string existingFile = @"C:\Users\anaga\OneDrive\Área de Trabalho\Ferias.xls"; //Minha string de conexão para o meu arquivo Excel

            ExcelPackage package = new(new System.IO.FileInfo(existingFile));
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelWorksheet worksheet = package.Workbook.Worksheets["Planilha1"]; //Abas

            int rowCount = worksheet.Dimension.End.Row;  //Contar quantas linhas ele tem(Ferias.xls)

            // int colCount = worksheet.Dimension.End.Column; //Contar quantas colunas ele tem

            using (var conexao = new AppContext()) //Fazendo conexão com banco de dados

            { //Organizei como eu quero que meu arquivo Excel seja lido 

                for (int row = 2; row <= rowCount; row++) //Começar a ler linha 2

                {
                    Funcionario funcionario = conexao.Funcionario.FirstOrDefault(x => x.CPF == Convert.ToInt32(worksheet.Cells[row, 3].Value.ToString()));
                    if(funcionario == null) //Utilizei o First Our Default para toda vez que não tiver no banco ele fazer
                    {

                        funcionario.Nome = worksheet.Cells[row, 1].Value.ToString(); //row e col (linha e coluna)
                        funcionario.Sobrenome = worksheet.Cells[row, 2].Value.ToString();
                        funcionario.CPF = Convert.ToInt32(worksheet.Cells[row, 3].Value.ToString());

                        conexao.Funcionario.Add(funcionario);
                        
                    };

                    Telefone telefone = conexao.Telefone.FirstOrDefault(x => x.Numero == Convert.ToInt32(worksheet.Cells[row, 4].Value.ToString()));
                    if (telefone == null)
                    {
                        telefone.Numero = Convert.ToInt32(worksheet.Cells[row, 4].Value.ToString());
                        telefone.Descricao = worksheet.Cells[row, 5].Value.ToString();

                        conexao.Telefone.Add(telefone);
                    }

                    Endereco endereco = conexao.Endereco.FirstOrDefault(X => X.CEP == Convert.ToInt32(worksheet.Cells[row, 8].Value.ToString()));
                    if (endereco == null)
                    {
                        endereco.Longadouro = worksheet.Cells[row, 6].Value.ToString();
                        endereco.Numero = Convert.ToInt32(worksheet.Cells[row, 7].Value.ToString());
                        endereco.CEP = Convert.ToInt32(worksheet.Cells[row, 8].Value.ToString());
                        endereco.Complemento = worksheet.Cells[row, 9].Value.ToString();
                    }

                    Cargo cargo = conexao.Cargo.FirstOrDefault(x => x.Tipo == worksheet.Cells[row, 10].Value.ToString());
                    if (cargo == null)
                    {
                        cargo.Tipo = worksheet.Cells[row, 10].Value.ToString();
                    }
                    
                    Contrato contrato = conexao.Contrato.FirstOrDefault(x => x.DataInicio == Convert.ToDateTime(worksheet.Cells[row, 11].Value.ToString()));
                    if (contrato == null)
                    {
                        contrato.DataInicio = Convert.ToDateTime(worksheet.Cells[row, 11].Value.ToString());
                        contrato.DataFim = Convert.ToDateTime(worksheet.Cells[row, 12].Value.ToString());
                        contrato.Salario = Convert.ToDouble(worksheet.Cells[row, 13].Value.ToString());
                    }

                    Ferias ferias = conexao.Ferias.FirstOrDefault(x => x.DataInicio == Convert.ToDateTime(worksheet.Cells[row, 15].Value.ToString()));
                    if(ferias == null)
                    {
                        ferias.AdiantamentoDecimoTerceiro = Convert.ToBoolean(worksheet.Cells[row, 14].Value.ToString());
                        ferias.DataInicio = Convert.ToDateTime(worksheet.Cells[row, 15].Value.ToString());
                        ferias.DataFim = Convert.ToDateTime(worksheet.Cells[row, 16].Value.ToString());
                        ferias.AutorizacaoGerente1 = Convert.ToBoolean(worksheet.Cells[row, 17].Value.ToString());
                        ferias.AutorizacaoGerente2 = Convert.ToBoolean(worksheet.Cells[row, 18].Value.ToString());
                    }

                    Autorizacao autorizacao = conexao.Autorizacao.FirstOrDefault(x => x.ObservacaoFuncionario == worksheet.Cells[row, 19].Value.ToString());
                    if (autorizacao == null)
                    {
                        autorizacao.ObservacaoFuncionario = worksheet.Cells[row, 19].Value.ToString();
                        autorizacao.IdGerente1 = Convert.ToInt32(worksheet.Cells[row, 20].Value.ToString());
                        autorizacao.ObservacaoGerente1 = worksheet.Cells[row, 21].Value.ToString();
                        autorizacao.StatusGerente1 = Convert.ToBoolean(worksheet.Cells[row, 22].Value.ToString());
                        autorizacao.IdGerente2 = Convert.ToInt32(worksheet.Cells[row, 23].Value.ToString());
                        autorizacao.ObservacaoGerente2 = worksheet.Cells[row, 24].Value.ToString();
                        autorizacao.StatusGerente2 = Convert.ToBoolean(worksheet.Cells[row, 25].Value.ToString());
                    }
                   
                    Historico historico = conexao.Historico.FirstOrDefault(x => x.UltimoPeriodo == Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString()));
                    if(historico == null)
                    {
                        historico.QuantidadeDeDias = Convert.ToInt32(worksheet.Cells[row, 26].Value.ToString());
                        historico.Venda = Convert.ToBoolean(worksheet.Cells[row, 27].Value.ToString());
                        historico.UltimoPeriodo = Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString());
                    }

                    PeriodoAquisitivo periodoAquisitivo = conexao.PeriodoAquisitivo.FirstOrDefault(x => x.UltimoPeriodo == Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString()));
                    if(periodoAquisitivo == null)
                    {
                        periodoAquisitivo.DataDaContratacao = Convert.ToDateTime(worksheet.Cells[row, 29].Value.ToString());
                        periodoAquisitivo.UltimoPeriodo = Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString());
                    }
                    
                    conexao.SaveChanges();
                }
            }
        }
    }
}*/
