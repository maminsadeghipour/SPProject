using App.Domain.AppService.ExpertAgg;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;
using App.Domain.Service.ExpertAgg;
using App.Infrastructure.DataAccess.DatabaseContext;
using App.Infrastructure.Repository.ExpertAgg;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>();


builder.Services.AddScoped<IExpertAppService, ExpertAppService>();
builder.Services.AddScoped<IExpertService, ExpertService>();
builder.Services.AddScoped<IExpertRepository, ExpertRepository>();



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

