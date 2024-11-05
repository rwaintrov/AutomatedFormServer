using AutomatedForm.Api;
using AutomatedForm.Core;
using AutomatedForm.Core.Repositories;
using AutomatedForm.Core.Services;
using AutomatedForm.Data;
using AutomatedForm.Data.Repositories;
using AutomatedForm.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//builder.Services.AddScoped<IAuthorityRepository, AuthorityRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddAutoMapper(typeof(ApiMappingProfile));
builder.Services.AddScoped<ITblBranchRepository, TblBranchRepository>();
builder.Services.AddScoped<ITblBranchService, BranchService>();
builder.Services.AddScoped<ITblMuniRepository, TblMuniRepository>();
builder.Services.AddScoped<ITblMuniService, MuniService>();
builder.Services.AddScoped<ITblFactoryRepository, TblFactoryRepository>();
builder.Services.AddScoped<ITblFactoryService, FactoryService>();
builder.Services.AddScoped<ITransMuniFactoryRepository, TransMuniFactoryRepository>();
builder.Services.AddScoped<ITransMuniFactoryService, MuniFactoryService>();
builder.Services.AddDbContext<DataContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();