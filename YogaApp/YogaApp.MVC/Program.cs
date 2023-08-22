using AspNetCoreHero.ToastNotification;
using Microsoft.EntityFrameworkCore;
using YogaApp.Business.Abstract;
using YogaApp.Business.Concrete;
using YogaApp.Data.Abstract;
using YogaApp.Data.Concrete.EfCore.Contexts;
using YogaApp.Data.Concrete.EfCore.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<YogaAppContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddScoped<IInstructorService, InstructorManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IInstructorRepository, EfCoreInstructorRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();

builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 5;
    config.IsDismissable = true;
    config.Position = NotyfPosition.BottomRight;
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();


app.MapControllerRoute(
    name: "ýnstructorcategory",
    pattern: "ýnstructor/{categoryurl?}",
    defaults: new { controller = "InstructorController", action = "InstructorList" }
    );
app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "admin/{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
