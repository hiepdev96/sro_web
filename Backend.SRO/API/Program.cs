using Common.Middleware;
using Microsoft.EntityFrameworkCore;
using VsroAccount.Repository;
using VsroLog.Log_Repository;
using VsroShard.Shard_Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<VsroAccountContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDefault"));
});

builder.Services.AddDbContext<VsroLogContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionLog"));
});
builder.Services.AddDbContext<VsroShardContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionShard"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin 
    .AllowCredentials());

app.UseAuthorization();

app.MapControllers();

app.Run();
