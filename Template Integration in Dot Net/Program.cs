var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern : "{controller=home}/{action=index}" 
    );

app.UseStaticFiles();
app.Run();
