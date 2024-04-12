/*
    *Thanks for Frank Liu for his tutorial:
    *Full Course - Learn ASP.NET Core MVC in .NET 8 | CRUD Operations | EntityFramework | MVC Tutorial
    *https://www.youtube.com/watch?v=BzlPrVB_DwA
    *2024.09.03
 */
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}") ;

app.Run();


