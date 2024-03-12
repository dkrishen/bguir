using Newtonsoft.Json;

namespace Gateway.API.Logic.Extenshions;

public static class ObjectExtenshions
{
    public static string SerializeToJson(this object obj)
    {
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            
        };

        return JsonConvert.SerializeObject(obj, settings);
    }
}