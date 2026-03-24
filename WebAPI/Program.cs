using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.Utilites.Security.Encryption;
using Core.Utilites.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>(); 

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)   
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });
//builder.Services.AddScoped<IBrandService, BrandManager>();
//builder.Services.AddScoped<ICarService, CarManager>();
//builder.Services.AddScoped<ICategoryService, CategoryManager>();
//builder.Services.AddScoped<IColorService, ColorManager>();
//builder.Services.AddScoped<ICustomerService, CustomerManager>();
//builder.Services.AddScoped<IRentalService, RentalManager>();

//builder.Services.AddScoped<IBrandDal, EfBrandDal>();
//builder.Services.AddScoped<ICarDal, EfCarDal>();
//builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
//builder.Services.AddScoped<IColorDal, EfColorDal>();
//builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
//builder.Services.AddScoped<IRentalDal, EfRentalDal>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
