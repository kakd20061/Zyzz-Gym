using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using ZyzzGymOriginal.Areas.Identity.Pages.Account;
using ZyzzGymOriginal.Data;
using ZyzzGymOriginal.Data.Repositories;
using ZyzzGymOriginal.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<NewIdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddTransient<IAnnouncementsRepository, AnnouncementsRepository>();
builder.Services.AddTransient<IPricingRepository, PricingRepository>();
builder.Services.AddTransient<IExerciseNameRepository, ExerciseNameRepository>();
builder.Services.AddTransient<IAchievementsRepository, AchievementsRepository>();
builder.Services.AddTransient<IUserRepository, NewIdentityUserRepository>();
builder.Services.AddTransient<IRequestRepository, RequestRepository>();
builder.Services.AddTransient<IMainAnnouncementsViewModelProvider, MainAnnouncementsViewModelProvider>();
builder.Services.AddTransient<IMainPricingViewModelProvider, MainPricingViewModelProvider>();
builder.Services.AddTransient<IAchivementsViewModelProvider, AchievementsViewModelProvider>();
builder.Services.AddTransient<IAdministrationViewModelProvider, AdministrationAdminPanelViewModelProvider>();


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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Home}/{id?}");
app.MapRazorPages();

app.Run();
