var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


// LINHA DE PROCESSOS
// 1 - rodar dotnet new mvc
// 2 - rodar dotnet run para verificar se tudo está funcionando
// 3 - Codar os models
// 4 - Baixar os pacotes (comandos no classroom)
// 5 - Se o Entity Framework não estiver instalado, executar o comando "dotnet tool install --global dotnet-ef"
// 6 - Executar o comando "dotnet ef migrations add InitialCreate"
// 7 - Executar o comando "dotnet ef database update"
