using IMPAKT.Labs;
using IMPAKT.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json")
           .Build();

var serviceProvider = new ServiceCollection()
    .Configure<MainSettings>(configuration.GetSection(nameof(MainSettings)))
    .AddTransient<Lab1>()
    .BuildServiceProvider();

var lab1 = serviceProvider.GetRequiredService<Lab1>();

lab1.Execute();