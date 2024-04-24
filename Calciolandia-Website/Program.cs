using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data;
using Calciolandia_Website.Core.Data.Common;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SqlServerConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = true;
    options.User.RequireUniqueEmail = true;

})
    .AddRoles<IdentityRole<Guid>>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<ILeagueService, LeagueService>();
builder.Services.AddScoped<IStadiumService, StadiumService>();
builder.Services.AddScoped<IFootballClubService, FootballClubService>();
builder.Services.AddScoped<IManagerService, ManagerService>();
builder.Services.AddScoped<IPresidentService, PresidentService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IFixtureService, FixtureService>();


builder.Services.AddAntiforgery(options => options.HeaderName = "XSRF-TOKEN");


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/User/Login";
    
   

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseStatusCodePagesWithRedirects("/Error/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();


app.Run();
