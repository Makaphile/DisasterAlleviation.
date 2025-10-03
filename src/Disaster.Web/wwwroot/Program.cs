using DisasterAlleviation.Data;
using DisasterAlleviation.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to DI
builder.Services.AddControllersWithViews();

// Configure DbContext to use Azure SQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register services for dependency injection
builder.Services.AddScoped<IDonationService, DonationService>();
builder.Services.AddScoped<IIncidentService, IncidentService>();
builder.Services.AddScoped<IVolunteerService, VolunteerService>();

var app = builder.Build();

// Seed sample data if needed
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    DataSeeder.Seed(db); // Make sure DataSeeder works with AppDbContext
}

// Middleware pipeline
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
