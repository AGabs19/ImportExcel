using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using AppContext = ImportExcel.DataBase.AppContext;
using ImportExcel;

namespace ImportExcel.Pages
{
    public class IndexModel : PageModel //Aqui é meu Controllers
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

        public void OnGet()
        {

        }
      
        public ActionResult DownloadExcel() //Para efetuar o dowload do arquivo
        {
            string Arquivo = @"C:\Users\anaga\OneDrive\Área de Trabalho\Projetos\ExcelSQL\ImportExcel\ImportExcel\Planilha.cs"; //String de ligação com meu arquivo
            byte[] fileBytes = System.IO.File.ReadAllBytes(Arquivo);
            System.IO.File.WriteAllBytes(Arquivo, fileBytes);
            MemoryStream ms = new MemoryStream(fileBytes);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "Ferias.xls");
        }
        public async Task<IActionResult> Salvar()//Para Salvar no banco de dados 
        {
            IFormFile file = Request.Form.Files[0];
            //string folderName = "Salvar";
            //Fazendo a passagem dos meus dados do Excel para meu BD
            using (Stream stream = file.OpenReadStream()) //Abri a leitura
            using (StreamReader reader = new StreamReader(stream))
            {
                string data = await reader.ReadToEndAsync(); //Ler o async
                var salvar = new Planilha() //Pegar meus comandos do arquivo planilha.cs e depois salvar no meu SQL "FeriasApp"
                {

                };
            }
        } //Teste depois: public static System.IO.FileStream Open Read(string path);


    }
}
