using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ServiceStack;
using Ueh.Application.Services;
using Ueh.Data.EF;
using Ueh.Utilities.Constants;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UEH_DbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("UehDb")));

builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddSession();

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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
