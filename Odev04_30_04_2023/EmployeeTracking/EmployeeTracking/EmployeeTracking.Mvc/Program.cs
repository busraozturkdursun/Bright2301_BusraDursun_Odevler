using EmployeeTracking.Business.Abstract;
using EmployeeTracking.Business.Concrete;
using EmployeeTracking.Data.Abstract;
using EmployeeTracking.Data.Concrete.EfCore.Contexts;
using EmployeeTracking.Data.Concrete.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DbContext, EmployeeTrackingContext>();
builder.Services.AddScoped<IEmployeeService, EmployeeManager>();
builder.Services.AddScoped<IDepartmentService, DepartmentManager>();

builder.Services.AddScoped<IEmployeeRepository, EfCoreEmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, EfCoreDepartmentRepository>();


var app = builder.Build();



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
