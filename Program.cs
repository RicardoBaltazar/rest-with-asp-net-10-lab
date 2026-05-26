using Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.AddSerilog();
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabaseConfig(builder.Configuration);
builder.Services.AddScoped<Repositories.IPersonRepository, Repositories.Impl.PersonRepository>();
builder.Services.AddScoped<Services.IPersonService, Services.PersonService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();

app.Run();
