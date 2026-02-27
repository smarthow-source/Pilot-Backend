using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.BusinessFlow;
using WebApplication1.Repositories;
using WebApplication1.Profiles;



var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


// Add services to the container.
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<FormMappingProfile>();
});
builder.Services.AddScoped<IFormRepository, FormRepository>();
builder.Services.AddScoped<IFormFlow, FormFlow>();
builder.Services.AddControllers();
builder.Services.AddDbContext<MainContext>(options =>
    options.UseNpgsql(connectionString));

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
