using Microsoft.AspNetCore.OData;
using Repository.Interface;
using Repository.Repository;
using Repository.UnitOfWork;
using Service.AutoMapper;
using Service.Interface;
using Service.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddOData(x => x.Select().Filter().OrderBy().Count().SetMaxTop(null).Expand());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IPressService, PressService>();

builder.Services.AddAutoMapper(typeof(AddressMapping));
builder.Services.AddAutoMapper(typeof(BookMapping));
builder.Services.AddAutoMapper(typeof(CategoryMapping));
builder.Services.AddAutoMapper(typeof(PressMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
