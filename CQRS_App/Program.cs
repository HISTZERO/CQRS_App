using MediatR;
using Core.Interface;
using Infrastructure.Context;
using System.Reflection;
using Core.Domain.Products.Commands;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(s =>
{
    s.ImplicitlyValidateChildProperties = true;
    s.ImplicitlyValidateRootCollectionElements = true;

    // Automatic registration of validators in assembly
    s.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
}); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IUnitOfWork), typeof(DatabaseContext));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(ProductCommandHandler).Assembly);


builder.Services.AddDbContext<AuthenticationContext>(options =>
{
    options.UseNpgsql("Server=localhost;Port=5432;Database=demo1;User Id=postgres;Password=admin@123;");
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
