using Microsoft.EntityFrameworkCore;
using AppContext = ImportExcel.DataBase.AppContext;
using System.Data.OleDb;
using System.Data;
using ImportExcel;
using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("FeriasPage").ToString()));
//Conexão com Banco de Dados

var app = builder.Build();

//if (!app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//}
//else
//{
//    app.UseExceptionHandler("/Error");

//    app.UseHsts(); 
//}
app.UseDeveloperExceptionPage();

app.UseDatabaseErrorPage();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllers();
});

app.MapRazorPages();

app.Run();




