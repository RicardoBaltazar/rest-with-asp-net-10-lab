using Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.AddSerilog();
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabaseConfig(builder.Configuration);
builder.Services.AddScoped<Services.IPersonService, Services.PersonService>();
builder.Services.AddScoped<Services.IBookService, Services.BookService>();

builder.Services.AddScoped(typeof(Repositories.IRepository<>), typeof(Repositories.Impl.GenericRepository<>));


builder.Services.AddEvolve(builder.Configuration, builder.Environment);


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
