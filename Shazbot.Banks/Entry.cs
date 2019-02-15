using Newtonsoft.Json;

namespace Shazbot.Banks
{
    public abstract class Entry
    {
        [JsonProperty("name")]
        public string Name;
    }
}
