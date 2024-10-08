using BL.IService;
using BL.Service;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<SettlementContext>(options => options.UseSqlServer("Server=.;Database=Settlement;TrustServerCertificate=True;Trusted_Connection=True;"));

builder.Services.AddScoped(typeof(IRepositorySettlement), typeof(RepositorySettlement));
builder.Services.AddScoped(typeof(IServiceSettlement), typeof(ServiceSettlement));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
