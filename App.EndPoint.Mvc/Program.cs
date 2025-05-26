using Serilog;
using App.Domain.AppService.CustomerAgg;
using App.Domain.AppService.ExpertAgg;
using App.Domain.AppService.RequestAgg;
using App.Domain.AppService.SkillServeAgg;
using App.Domain.Core.CustomerAgg.Contracts.CustomerContracts;
using App.Domain.Core.EnumAgg.Contracts;
using App.Domain.Core.ExpertAgg.Contracts.ExpertContract;
using App.Domain.Core.RequestAgg.Contracts.RequestContracts;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeCategoryContracts;
using App.Domain.Core.SkillServeAgg.Contracts.SkillServeContracts;
using App.Domain.Service.CustomerAgg;
using App.Domain.Service.EnumAgg;
using App.Domain.Service.ExpertAgg;
using App.Domain.Service.RequestAgg;
using App.Domain.Service.SkillServeAgg;
using App.Infrastructure.DataAccess.DatabaseContext;
using App.Infrastructure.Repository.CustomerAgg;
using App.Infrastructure.Repository.ExpertAgg;
using App.Infrastructure.Repository.RequestAgg;
using App.Infrastructure.Repository.SkillServeAgg;
using App.Domain.Core.CacheAgg.Contracts;
using App.Infrastructure.RedisCacheService.Redis;
using App.Domain.Core.FeedBackAgg.Contracts;
using App.Infrastructure.Repository.FeebackAgg;
using App.Domain.Service.FeebackAgg;
using App.Domain.AppService.FeebackAgg;
using App.Domain.Core.IdentityAgg.Entity;
using Microsoft.AspNetCore.Identity;
using App.Domain.Core.IdentityAgg.Contracts;
using App.Domain.AppService.IdentityAgg;
using App.Domain.Core.AddressAgg.Contracts.CityContract;
using App.Infrastructure.Repository.AddressAgg;
using App.Domain.Service.AddressAgg;
using App.Domain.AppService.AddressAgg;
using App.Domain.Core.AddressAgg.Contracts.AddressContract;
using App.Domain.Core.RequestAgg.Contracts.BidContracts;
using App.Domain.Core.RequestAgg.Contracts.RequestPictureContracts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


#region LoggConfigurations

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

#endregion
   
#region DatabaseConfiguration
builder.Services.AddDbContext<AppDbContext>();

#endregion

#region CacheConfigurations
builder.Services.AddStackExchangeRedisCache(option =>
{
    option.Configuration = "localhost:6379";
    option.InstanceName = "SPProjectCatalog_";

});

builder.Services.AddMemoryCache();

#endregion

#region IoC Containers

builder.Services.AddScoped<IExpertAppService, ExpertAppService>();
builder.Services.AddScoped<IExpertService, ExpertService>();
builder.Services.AddScoped<IExpertRepository, ExpertRepository>();

builder.Services.AddScoped<ICustomerAppService, CustomerAppService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();

builder.Services.AddScoped<IRequestAppService, RequestAppService>();
builder.Services.AddScoped<IRequestService,    RequestService>();
builder.Services.AddScoped<IRequestRepository, RequestRepository>();

builder.Services.AddScoped<ISkillServeAppService, SkillServeAppService>();
builder.Services.AddScoped<ISkillServeService,    SkillServeService>();
builder.Services.AddScoped<ISkillServeRepository, SkillServeRepository>();

builder.Services.AddScoped<ISkillServeCategoryAppService, SkillServeCategoryAppService>();
builder.Services.AddScoped<ISkillServeCategoryService,    SkillServeCategoryService>();
builder.Services.AddScoped<ISkillServeCategoryRepository, SkillServeCategoryRepository>();

builder.Services.AddScoped<ICustomerFeedbackRepository, CustomerFeedbackRepository>();
builder.Services.AddScoped<ICustomerFeedbackService, CustomerFeedbackService>();
builder.Services.AddScoped<ICustomerFeedbackAppService, CustomerFeedbackAppService>();

builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICityAppService, CityAppService>();

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IAddressAppService, AddressAppService>();

builder.Services.AddScoped<IBidService, BidService>();
builder.Services.AddScoped<IBidRepository, BidRepository>();

builder.Services.AddScoped<IRequestPictureService, RequestPictureService>();






builder.Services.AddScoped<IAccountAppServices, AccountAppServices>();

builder.Services.AddScoped<IEnumService, EnumService>();

builder.Services.AddScoped<IRedisCacheService, RedisCacheService>();

#endregion

#region IdentityConfigurations

builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>
    (options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddRoles<IdentityRole<int>>()
    .AddEntityFrameworkStores<AppDbContext>();
    //.AddErrorDescriber<PersianIdentityErrorDescriber>();

#endregion



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

