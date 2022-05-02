//ESSA É A ANTIGA PROGRAMAÇÃO DA PAGE, COMO IREI REFAZER NOVAMENTE IREI DEIXAR ALGUMAS COISAS AQUI!!!
/*namespace ImportExcel.ANTIGA_PAGE
{
    public class AntigaPage
    {
        @page
@using ImportExcel.Controllers
@using static Microsoft.EntityFrameworkCore.DbLoggerCategory
@model ImportController
@{
    ViewData["Title"] = "FeriasApp";
}
<link rel = "stylesheet" type="text/css" href="~/js/site.js" />
<link rel = "stylesheet" type="text/css" href="~/css/site.css" />
<script type = "text/javascript" src="~/lib/jquery/dist/jquery.min.js"> </script>
<script src = "~/js/site.js" ></ script >
< script src="https://localhost:7004/ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js%20n"></script>
<script src = "/_framework/aspnetcore-browser-refresh.js" ></ script >

< div class="text-center">
    <h1 class="display-4">Bem Vindo</h1>
    <p>Importando uma Tabela Excel para um banco de dados!</p>
    <p>Fique a vontade sempre que quiser fazer uma atualização!</p>
 </div>
 <div class ="row">
     <div class="col-ml-12">
         <a href = "@Url.Action("Index", new{id=1})" class ="btn btn-primary">DownloadExcel</a>
     </div>
 </div>

 <div class="col-md-6">
     <a href = "@Url.Action("Index", new{id=2})" class="btn btn-primary">Salvar</a>
</div>

 <div class= "row">
     <div class="col-ml-12">
         <input type = "File" id="Select" accept=".xls,.xlxs" style="float:left;"/>
     </div>
 </div>

 <div class="row">
     <div class ="col-md-12">
         <table class ="Ferias.App">
             <thead>
                 <tr>
                     <td>Funcionario</td>
                     <td>Telefone</td>
                     <td>Endereco</td>
                     <td>Cargo</td>
                     <td>Contrato</td>
                     <td>Ferias</td>
                     <td>Autorizacao</td>
                     <td>PeriodoAquisitivo</td>
                     <td>Historico</td>
                 </tr>
             </thead>
             <tbody>
               
            </tbody>
         </table>
     </div>
 </div>

<style>
  table{
      font-family: arial, sans-serif;
      border-collapse: collapse;     
      width:100%;}
th
{
border: 1px solid #ADD8E6;
       text - align: left;
padding: 8px;
}
tr: nth - child(even) {
    background - color: #ADD8E6;}

</ style >



< script type = "text/javascript" >

     @functions{
        public string DownloadExcel()
        {

            return "Olá!";

        }
    }

    Select.onclick = function(){
        var fileExtension = ["Xls", "xlxs"]; //Só aceitar esse tipo
        var fileName = $("Ferias.xls") //Nome do arquivo
        if (fileName)
        {
            alert("Por favor, selecione um arquivo.");
        }
        else
        {
            alert("Por favor, selecione apenas arquivos Excel.") //Caso selecione outro tipo de arquivo
        }
    };

    DownloadExcel.onclick = function(){
        //var fileExtension = ["xls", "xlxs"];
        //var fileName = $("Ferias.xls")
        var reader = new FileReader();
        reader.onload = function(){ //Ajustar aqui, onde vai ser feito a leitura do arquivo 
            console.log(FeriasApp.target.result) //Quero que apareça na tabela da minha tela  
            };
        reader.readAsText("Ferias.xls") //O arquivo está em Planilha.cs
    };

    Salvar.onclick = function(){
        //var fileExtension = ["xls", "xlxs"]; //Tipo aceitado
        //var fileName = $("Ferias.xls").val(); //Nome do arquivo e valor
        if (done)
        {
            alert("Salvo com sucesso!") //Quando salvar no Banco de dados
        }
        if (fail)
        {
            alert("Ocorreu um erro")
        }
        else
        {
            alert("Nenhum arquivo encontrado")
        }
    };

</ script >


    }
}
*/