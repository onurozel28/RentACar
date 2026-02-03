using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();
