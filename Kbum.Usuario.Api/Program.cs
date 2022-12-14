using AutoMapper;
using Kbum.Usuarios.Api.Data.ConfigMapping;
using Kbum.Usuarios.Api.Data.Context;
using Kbum.Usuarios.Api.Services.Interface;
using Kbum.Usuarios.Api.Services.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration["ConnectionStrings:KbumConnection"];

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));
IMapper mapper = ConfigMapping.MapperConfiguration().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IUsuarioionarioRepository, UsuarioRepository>();
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
