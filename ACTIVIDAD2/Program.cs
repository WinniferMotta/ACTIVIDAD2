// Program.cs
// Este archivo configura los servicios de la aplicación y el pipeline de solicitudes HTTP.

var builder = WebApplication.CreateBuilder(args);

// Añade los servicios para controladores y vistas a la colección de servicios.
// Esto es esencial para que ASP.NET Core MVC funcione.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura el pipeline de solicitudes HTTP.
// Si la aplicación NO está en entorno de desarrollo, configura el manejador de errores.
if (!app.Environment.IsDevelopment())
{
    // Configura una página de error predeterminada.
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
