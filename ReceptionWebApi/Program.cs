using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReceptionWebApi.DataContext;
using ReceptionWebApi.Repository;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddMemoryCache();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var appSettingsFileName = builder.Environment.IsDevelopment()
    ? FileNames.AppSettingsDevelopmentName
    : FileNames.AppSettingsName;

var configuration = builder
    .Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile(appSettingsFileName)
    .Build();


builder.Services.AddSingleton<ITblUser, InMemTblUserRep>();

builder.Services.AddDbContext<GeneralContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("GeneralContext")));
//builder.Services.InstallServicesAssembly(configuration);
//builder.Services.AddApplication(configuration);


//builder.LogApplicationEverything(configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//SSL
app.UseHttpsRedirection();
// Authentication
app.UseAuthentication();
app.MapControllers();
app.Run();
