using Microsoft.EntityFrameworkCore;
using AppContext = ImportExcel.DataBase.AppContext;
using System.Data.OleDb;
using System.Data;
using ImportExcel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("FeriasApp").ToString()));


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    
    app.UseHsts(); 
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

Planilha.ReadXls();

app.Run();

/*
String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0:" + "Data Source=" + ServerMapPath("Caminhoexcel") + ":" + "Extended Proprities=Exce 8.0";

OleDbConnection objConn = new OleDbConnection(sConnectionString);

objConn.Open();

OleDbCommand objCmdSelect = OleDbCommand("SELECT * FROM My Rangel, objConn");

OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();

objAdapter1.SelectCommand = objCmdSelect;
DataSet objDataset1 = DataSet();

objAdapter1.Fill(objDataset1, "XLData");

DataGrid1.DataSource = objDataset1.Tables[0].DefaultView;
DataGrid1.DataBind();

objConn.Close();
*/

