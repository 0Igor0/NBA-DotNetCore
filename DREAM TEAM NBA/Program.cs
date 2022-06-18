using DREAM_TEAM_NBA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DREAM_TEAM_NBA.Data;
using DREAM_TEAM_NBA.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DREAM_TEAM_NBAContextConnection") ?? throw new InvalidOperationException("Connection string 'DREAM_TEAM_NBAContextConnection' not found.");

builder.Services.AddDbContext<DREAM_TEAM_NBAContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<DREAM_TEAM_NBAContext>();;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DREAM_TEAM_NBAContext>
    (options => options.UseSqlServer("Data Source=DESKTOP-7EM4M9E\\MSSQLSERVER01;Initial Catalog=NBA;Integrated Security=True"));




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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
