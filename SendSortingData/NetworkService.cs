using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SendSortingData;
public class NetworkService
{
    private readonly HttpClient client;
    private readonly ConfigParser parser;

    private HttpContent content;
    
    public NetworkService(
        ConfigParser parser)
    {
        this.parser = parser;
        client = new HttpClient();
    }
    
    public async Task SendData(int[] ints)
    {
        var config = parser.GetConfig();

        var str = string.Empty;

        for (int i = 0; i < ints.Length; i++)
            str += $"{ints[i]}, ";

        content = new StringContent(str);

        await client.PostAsync(config.Uri, content);
    }
    
}
