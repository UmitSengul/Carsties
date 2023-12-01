using MongoDB.Driver;
using MongoDB.Entities;
using SearchService;
using SearchService.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddHttpClient<AuctionSvcHttpClient>();

var app = builder.Build();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();


try
{
    await DbInitializer.Initdb(app);
}
catch (Exception e)
{

    Console.WriteLine(e);
}

app.Run();
