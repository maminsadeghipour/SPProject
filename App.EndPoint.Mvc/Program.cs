using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add SeriLog
builder.Host.ConfigureLogging(loggingBuilder =>
{
    loggingBuilder.ClearProviders();
}).UseSerilog((context, configs) =>
{
    configs.WriteTo.Console(Serilog.Events.LogEventLevel.Verbose);

    configs.WriteTo.Seq("http://localhost:5341", Serilog.Events.LogEventLevel.Information, apiKey: "sOT1arqVtufKGchjjDgd")
    .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Error);
    

});
   


// Add services to the container.
builder.Services.AddControllersWithViews();

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

