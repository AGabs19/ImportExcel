using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using AppContext = ImportExcel.DataBase.AppContext;
using DocumentFormat.OpenXml.Office2010.Excel;
using ImportExcel.Models;
using OfficeOpenXml;
using System.IO;

namespace ImportExcel.Views
{
    public class IndexModel : Controller 
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }

    }
}