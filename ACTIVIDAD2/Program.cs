// Program.cs
// Este archivo configura los servicios de la aplicaci�n y el pipeline de solicitudes HTTP.

var builder = WebApplication.CreateBuilder(args);

// A�ade los servicios para controladores y vistas a la colecci�n de servicios.
// Esto es esencial para que ASP.NET Core MVC funcione.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura el pipeline de solicitudes HTTP.
// Si la aplicaci�n NO est� en entorno de desarrollo, configura el manejador de errores.
if (!app.Environment.IsDevelopment())
{
    // Configura una p�gina de error predeterminada.
    app.UseExceptionHandler("/Home/Error");
    // Configura HTTP Strict Transport Security (HSTS) para forzar HTTPS.
    app.UseHsts();
}

// Redirige las solicitudes HTTP a HTTPS.
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ACTIVIDAD}/{action=Index}/{id?}"); 


app.Run();
