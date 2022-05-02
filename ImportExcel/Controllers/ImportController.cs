using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using AppContext = ImportExcel.DataBase.AppContext;
using DocumentFormat.OpenXml.Office2010.Excel;
using ImportExcel.Models;
using OfficeOpenXml;
using System.IO;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IWebHostEnvironment;
using Ganss.Excel;
using ImportExcel.Services;
using ImportExcel.Views;

namespace ImportExcel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImportController : Controller
    {
        private readonly ILogger<ImportController> _logger;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly AppContext conexao;
        //private readonly ExcelModelValidator validation;
        
        public ImportController(ILogger<ImportController> logger, IWebHostEnvironment hostingEnvironment, AppContext conexao, IPlanilhaExcel services ) //, ExcelModelValidator validation )
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
            this.conexao = conexao;
           // this.services = services;
            //this.validation = validation;
        }
        public ActionResult Index()
        {
            List<ExcelModel> list = new List<ExcelModel>();
            
            return View("feriaspage"); //"feriasapp"
        }
        
        [HttpPost]
        public ActionResult PegarArquivo(IFormFile arquivo)
        {
            return StatusCode(StatusCodes.Status200OK, "Executado com sucesso!");
        }
    }
}
/// Outra forma de leitura, pelo EPPLUS, porem preciso ajustar ainda!!!
/* [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(IFormFile FeriasApp)
        {
            IFormFile File = Request.Form.Files[0];
            string folderName = "Ferias.xls";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);

            if (ModelState.IsValid) //Se o modelo for xls ou xlxs ou seja valido
            {
                if (FeriasApp?.Length > 0)
                {
                    var stream = FeriasApp.OpenReadStream(); //Convertendo em Stream
                   
                    try
                    {
                        using (var conexao = new AppContext())  //Fazendo conexão com banco de dados
                        {
                            string existingFile = @"C:\Users\anaga\OneDrive\Área de Trabalho\Ferias.xls"; //Minha string de conexão para o meu arquivo Excel

                            ExcelPackage package = new(new System.IO.FileInfo(existingFile));
                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                            ExcelWorksheet worksheet = package.Workbook.Worksheets["Planilha1"]; //Abas
                            int rowCount = worksheet.Dimension.End.Row;  //Contar quantas linhas ele tem(Ferias.xls)

                            //Organizei como eu quero que meu arquivo Excel seja lido 

                            for (int row = 2; row <= rowCount; row++) //Começar a ler linha 2

                            {
                                Funcionario funcionario = conexao.Funcionario.FirstOrDefault(x => x.CPF == Convert.ToInt32(worksheet.Cells[row, 3].Value.ToString()));
                                if (funcionario == null) //Utilizei o First Our Default para toda vez que não tiver no banco ele fazer
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

                                    conexao.Endereco.Add(endereco);
                                }

                                Cargo cargo = conexao.Cargo.FirstOrDefault(x => x.Tipo == worksheet.Cells[row, 10].Value.ToString());
                                if (cargo == null)
                                {
                                    cargo.Tipo = worksheet.Cells[row, 10].Value.ToString();

                                    conexao.Cargo.Add(cargo);
                                }

                                Contrato contrato = conexao.Contrato.FirstOrDefault(x => x.DataInicio == Convert.ToDateTime(worksheet.Cells[row, 11].Value.ToString()));
                                if (contrato == null)
                                {
                                    contrato.DataInicio = Convert.ToDateTime(worksheet.Cells[row, 11].Value.ToString());
                                    contrato.DataFim = Convert.ToDateTime(worksheet.Cells[row, 12].Value.ToString());
                                    contrato.Salario = Convert.ToDouble(worksheet.Cells[row, 13].Value.ToString());

                                    conexao.Contrato.Add(contrato);
                                }

                                Ferias ferias = conexao.Ferias.FirstOrDefault(x => x.DataInicio == Convert.ToDateTime(worksheet.Cells[row, 15].Value.ToString()));
                                if (ferias == null)
                                {
                                    ferias.AdiantamentoDecimoTerceiro = Convert.ToBoolean(worksheet.Cells[row, 14].Value.ToString());
                                    ferias.DataInicio = Convert.ToDateTime(worksheet.Cells[row, 15].Value.ToString());
                                    ferias.DataFim = Convert.ToDateTime(worksheet.Cells[row, 16].Value.ToString());
                                    ferias.AutorizacaoGerente1 = Convert.ToBoolean(worksheet.Cells[row, 17].Value.ToString());
                                    ferias.AutorizacaoGerente2 = Convert.ToBoolean(worksheet.Cells[row, 18].Value.ToString());

                                    conexao.Ferias.Add(ferias);
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

                                    conexao.Autorizacao.Add(autorizacao);
                                }

                                Historico historico = conexao.Historico.FirstOrDefault(x => x.UltimoPeriodo == Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString()));
                                if (historico == null)
                                {
                                    historico.QuantidadeDeDias = Convert.ToInt32(worksheet.Cells[row, 26].Value.ToString());
                                    historico.Venda = Convert.ToBoolean(worksheet.Cells[row, 27].Value.ToString());
                                    historico.UltimoPeriodo = Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString());

                                    conexao.Historico.Add(historico);
                                }

                                PeriodoAquisitivo periodoAquisitivo = conexao.PeriodoAquisitivo.FirstOrDefault(x => x.UltimoPeriodo == Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString()));
                                if (periodoAquisitivo == null)
                                {
                                    periodoAquisitivo.DataDaContratacao = Convert.ToDateTime(worksheet.Cells[row, 29].Value.ToString());
                                    periodoAquisitivo.UltimoPeriodo = Convert.ToDateTime(worksheet.Cells[row, 28].Value.ToString());

                                    conexao.PeriodoAquisitivo.Add(periodoAquisitivo);

                                    Console.Write("Funcionario");
                                    Console.ReadLine();
                                }

                                conexao.SaveChanges();
                            }
                        }
                        return View("Index");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

        public ActionResult DownloadExcel() //Para efetuar o download do arquivo
       {
           string Arquivo = @"C:\Users\anaga\OneDrive\Área de Trabalho\Ferias.xls"; //String de ligação com meu arquivo
           byte[] fileBytes = System.IO.File.ReadAllBytes(Arquivo);
           System.IO.File.WriteAllBytes(Arquivo, fileBytes); //Para ler tudo do arquivo
           MemoryStream ms = new MemoryStream(fileBytes); //Novo fluxo de memoria 
           return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "Ferias.xls");
       }*/
