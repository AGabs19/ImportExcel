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
        public IActionResult Index()
        {
            return new JsonResult("");
        }
        public IActionResult Excel()
        {
            var listaPlanilha = new List<Planilha>
            {
                Nome = "",
                Sobrenome = "",
                CPF = 0
            };
           
        }
        public IActionResult DataBase()
        {
            
        }
       //var planilha = new Planilha //Lista e essa lista vou passar varios comandos do tipo minhas linhas 
        
    }
}
