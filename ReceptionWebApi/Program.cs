using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReceptionWebApi.DataContext;
using ReceptionWebApi.Repository;
using ReceptionWebApi.Repository.CRUD;

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

builder.Services.AddSingleton<IFood, FoodRepo>();

//builder.Services.AddDbContext<GeneralContext>(options =>
//    options.UseSqlServer("Data Source=.;Initial Catalog=DBReception;Integrated Security=True;Trusted_Connection=True;"));
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
