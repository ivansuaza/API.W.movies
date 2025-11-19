using API.W.movies.DATA;
using API.W.movies.MoviesMapper;
using API.W.movies.Repository;
using API.W.movies.Repository.IRRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApicationBdContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<Mappers>());

builder.Services.AddScoped<ICategoryRepositori, CategoryRepositori>();

builder.Services.AddScoped<ICategoryRepositori, CategoryRepositori>();  

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
