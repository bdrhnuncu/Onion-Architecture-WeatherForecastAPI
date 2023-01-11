using Autofac.Extensions.DependencyInjection;
using Autofac;
using WeatherForecastApp.Application.Services;
using WeatherForecastApp.Persistence.DependencyResolvers.Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("LogFile")
    .WriteTo.PostgreSQL("Host=localhost;Username=postgres;Password=1234;Database=WeatherForecastApplication",
    "Logs", needAutoCreateTable: true)
    .CreateLogger();
builder.Host.UseSerilog();

builder.Services.AddCors(x => x.AddPolicy("Policy", x =>
{
    x.WithOrigins("http://localhost:26226", "https://localhost:7062", "http://localhost:5029");
    x.AllowAnyHeader();
    x.AllowAnyMethod();
}));

builder.Services.AddAllServices(new IService[]
{
    new ApplicationServices(), new ApplicationService2()
});//On Application services are here

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterMediatR(typeof(Program).Assembly);
    containerBuilder.RegisterModule<BusinessModule>();
});

var app = builder.Build();

app.UseCors("Policy");

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
