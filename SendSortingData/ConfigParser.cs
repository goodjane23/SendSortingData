using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace SendSortingData;
public class ConfigParser
{
    public Config GetConfig()
    {
        string stringConfig =string.Empty;

        StreamReader stream = new StreamReader("config.json");
        if (stream is not null)
        {
             stringConfig = stream.ReadToEnd();
        }
        return JsonSerializer.Deserialize<Config>(stringConfig);
    }
}
