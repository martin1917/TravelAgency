using JwtHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Users.Data;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

var cfg = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddCustomJwtAuth();
builder.Services.AddAuthorization();
builder.Services.AddDbContext<Context>(opt =>
{
    opt.UseSqlServer($"Server={cfg["DB_HOST"]},{cfg["DB_PORT"]};Database=users;User ID={cfg["DB_USER"]};Password={cfg["DB_PASSWORD"]}");
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Users",
        Version = "v1"
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert JWT with Bearer into field",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
        },
        Array.Empty<string>()
    }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
