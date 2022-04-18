using DocumentFormat.OpenXml.Office2010.Excel;
using ImportExcel.Models;
using OfficeOpenXml;
using AppContext = ImportExcel.DataBase.AppContext;
using System.IO;

namespace ImportExcel
{
    public class Planilha
    {
        public void Main(string[] args) 
        {
            ReadXls();
        } 

        public static void ReadXls()

        {
            string existingFile = @"C:\Users\anaga\OneDrive\Área de Trabalho\Ferias.xls";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelPackage package = new(new System.IO.FileInfo(existingFile));
            
                
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Planilha1"]; //Abas
               // int colCount = worksheet.Dimension.End.Column; //Contar quantas colunas ele tem
                
                int rowCount = 5;  //Contar quantas linhas ele tem

                using (var conexao = new AppContext())
                {
                    for (int row = 2; row <= rowCount; row++) //Começar a ler linha 2

                    {
                        var funcionario = new Funcionario();


                        funcionario.Nome = worksheet.Cells[row, 1].Value.ToString(); //row e col (linha e coluna)
                        funcionario.Sobrenome = worksheet.Cells[row, 2].Value.ToString();
                        funcionario.CPF = Convert.ToInt32(worksheet.Cells[row, 3].Value.ToString()); //Arrumar aqui 

                        conexao.Funcionario.Add(funcionario);
                        conexao.SaveChanges();
                   

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var telefone = new Telefone();


                        telefone.Numero = Convert.ToInt32(worksheet.Cells[row, 4].Value.ToString());
                        telefone.Descricao = worksheet.Cells[row, 5].Value.ToString();

                        conexao.Telefone.Add(telefone);
                        conexao.SaveChanges();
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var endereco = new Endereco();

                        endereco.Longadouro = worksheet.Cells[row,6].Value.ToString();
                        endereco.Numero = Convert.ToInt32(worksheet.Cells[row,7].Value.ToString());
                        endereco.CEP = Convert.ToInt32(worksheet.Cells[row, 8].Value.ToString());
                        endereco.Complemento = worksheet.Cells[row, 9].Value.ToString();

                        conexao.Endereco.Add(endereco);
                        conexao.SaveChanges();
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var cargo = new Cargo();
                       
                        cargo.Tipo = worksheet.Cells[row, 10].Value.ToString();

                        conexao.Cargo.Add(cargo);
                        conexao.SaveChanges();
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var contrato = new Contrato();

                        contrato.DataInicio = Convert.ToDateTime(worksheet.Cells[row, 11].Value.ToString());
                        contrato.DataFim = Convert.ToDateTime(worksheet.Cells[row, 12].Value.ToString());
                        contrato.Salario = Convert.ToDouble(worksheet.Cells[row, 13].Value.ToString());

                        conexao.Contrato.Add(contrato);
                        conexao.SaveChanges();
                    }
                    for (int row = 2; row <= rowCount; row++)
                    {
                        var ferias = new Ferias();

                        ferias.AdiantamentoDecimoTerceiro = Convert.ToBoolean(worksheet.Cells[row, 14].Value.ToString());
                        ferias.DataInicio = Convert.ToDateTime(worksheet.Cells[row, 15].Value.ToString());
                        ferias.DataFim = Convert.ToDateTime(worksheet.Cells[row, 16].Value.ToString());
                        ferias.AutorizacaoGerente1 = Convert.ToBoolean(worksheet.Cells[row, 17].Value.ToString());
                        ferias.AutorizacaoGerente2 = Convert.ToBoolean(worksheet.Cells[row, 18].Value.ToString());

                        conexao.Ferias.Add(ferias);
                        conexao.SaveChanges();

                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var autorizacao = new Autorizacao();

                        autorizacao.ObservacaoFuncionario = worksheet.Cells[row, 19].Value.ToString();
                        autorizacao.IdGerente1 = Convert.ToInt32(worksheet.Cells[row, 20].Value.ToString());
                        autorizacao.ObservacaoGerente1 = worksheet.Cells[row, 21].Value.ToString();
                        autorizacao.StatusGerente1 = Convert.ToBoolean(worksheet.Cells[row, 22].Value.ToString());
                        autorizacao.IdGerente2 = Convert.ToInt32(worksheet.Cells[row, 23].Value.ToString());
                        autorizacao.ObservacaoGerente2 = worksheet.Cells[row, 24].Value.ToString();
                        autorizacao.StatusGerente2 = Convert.ToBoolean(worksheet.Cells[row, 25].Value.ToString());

                        conexao.Autorizacao.Add(autorizacao);
                        conexao.SaveChanges();
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var historico = new Historico();

                        historico.QuantidadeDeDias = Convert.ToInt32(worksheet.Cells[row, 26].Value.ToString());
                        historico.Venda = Convert.ToBoolean(worksheet.Cells[row, 27].Value.ToString());
                        historico.UltimoPeriodo = Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString());

                        conexao.Historico.Add(historico);
                        conexao.SaveChanges();
                    }

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var periodoAquisitivo = new PeriodoAquisitivo();

                        periodoAquisitivo.DataDaContratacao = Convert.ToDateTime(worksheet.Cells[row,29].Value.ToString());
                        periodoAquisitivo.UltimoPeriodo = Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString());

                        conexao.PeriodoAquisitivo.Add(periodoAquisitivo);
                        conexao.SaveChanges();
                    }
                }
                
            
        }
    }
}
            