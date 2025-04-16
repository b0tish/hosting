
using WebApp5BySaugat.Models;
using WebApp5BySaugat.Repository;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<StudentdbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("conStr"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("conStr"))
    ));

// builder.Services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(conStr));
builder.Services.AddScoped<IRepository<Student>, StudentRepo>();

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
