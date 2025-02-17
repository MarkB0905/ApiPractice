using JET2.Entities.User.Data;
using JET2.Entities.User.IUser;
using JET2.Connection.IConnection;
using JET2.Connection;
using static JET2.Connection.IConnection.IConnection;

var builder = WebApplication.CreateBuilder(args);

// 🔥 Register services with Dependency Injection
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserProcedures, UserProcedures>();
builder.Services.AddScoped<IConnection, Connection>();

// Add services to the container.
builder.Services.AddControllers();

// Add database configuration and Swagger for API documentation
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

// Authorization middleware
app.UseAuthorization();

// Map controllers (this enables the routing to work)
app.MapControllers();

app.Run();
