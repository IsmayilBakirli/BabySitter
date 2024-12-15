using BabySitter.Presentatiton;
using BabySitter.Presentatiton.Controllers;
using BabySitter.Repositories;
using BabySitter.Repositories.Contracts;
using BabySitter.Repositories.Contracts.MSSQLDB;
using BabySitter.Repositories.MSSQLDB;
using BabySitter.Services;
using BabySitter.Services.Buisness;
using BabySitter.Services.Contracts;
using BabySitter.Services.Contracts.Business;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddApplicationPart(typeof(ProjectReferance).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBabySitterRepository, BabySitterRepository>();
builder.Services.AddScoped<IBabySitterService, BabySitterService>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
//builder.Services.AddSingleton<Lazy<IServiceProvider>>(sp => new Lazy<IServiceProvider>(() => sp));


builder.Services.AddDbContext<AppDbContext>((options) =>
{
    var dbContextOptionsBuilder = options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), d => d.MigrationsAssembly("BabySitter.Repositories"));

});

builder.Services.AddScoped<IBabySitterService, BabySitterService>();
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
