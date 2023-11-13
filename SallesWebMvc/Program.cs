using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SallesWebMvc.Data;
using SallesWebMvc.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionStr = "server=localhost;userid=DevNatan;password=24101966n;database=testdatabase";
builder.Services.AddDbContext<SallesWebMvcContext>(options =>
        options.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr)));
//options.UseSqlServer(builder.Configuration.GetConnectionString("SallesWebMvcContext") ?? throw new InvalidOperationException("Connection string 'SallesWebMvcContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentsService>();

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
