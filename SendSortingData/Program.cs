using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SendSortingData;
using System;

public class Program 
{
    private static async Task Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<SortingService>();
        services.AddSingleton<ArrayService>();
        services.AddSingleton<NetworkService>();
        services.AddSingleton<ConfigParser>();

        using var serviceProvider = services.BuildServiceProvider();
        
        var arrayService = serviceProvider.GetRequiredService<ArrayService>();
        var networkService = serviceProvider.GetRequiredService<NetworkService>();
        var sortingService = serviceProvider.GetRequiredService<SortingService>();

        var array = arrayService.CreateArray();
        sortingService.Sort(array);

        Console.WriteLine(Environment.NewLine +  "Sorting array:" + Environment.NewLine);

        for (int i = 0; i < array.Length-1; i++)
            Console.Write($"{array[i]} ");

       
        await networkService.SendData(array);
        
        Console.ReadLine();
    
    }
}