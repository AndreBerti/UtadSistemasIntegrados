using Microsoft.EntityFrameworkCore;
using Projeto20.Models;

var builder = WebApplication.CreateBuilder(args);

// Registrar o contexto do banco de dados
builder.Services.AddDbContext<MeuDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MeuBancoDeDados")));

// Adicionar servi�os ao cont�iner
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura��es de middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configura o roteamento padr�o
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
