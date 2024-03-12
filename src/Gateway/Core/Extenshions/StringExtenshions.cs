using Newtonsoft.Json;

namespace Gateway.API.Logic.Extenshions;

public static class StringExtenshions
{
    public static T DeserializeJSON<T>(this string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}