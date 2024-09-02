using Findrepo.Application.Services;
using Findrepo.Domain.Helpers;
using Findrepo.Domain.Repositories;
using Findrepo.Infrastructure.Context;
using Findrepo.Infrastructure.Repositories;
using Findrepo.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<JwtTokenProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserRepository, UserEFRepository>();
builder.Services.AddScoped<UserHelper>();
builder.Services.AddScoped<UserService>();
builder.Services.AddDbContext<FindrepoContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
