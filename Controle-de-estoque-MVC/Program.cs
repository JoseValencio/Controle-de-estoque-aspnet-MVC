using Controle_de_estoque_MVC.Data;
using Controle_de_estoque_MVC.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BancoContext>
    (options => options.UseSqlServer("Data Source=PTIIGT01NB93FB\\SQLEXPRESS; Initial Catalog=DB_ControleDeEstoque; Integrated Security=True; User ID=sa;Password=123; Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();