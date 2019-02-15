using Newtonsoft.Json;
using System.Windows.Input;

namespace Shazbot.Banks
{
    public abstract class Entry
    {
        [JsonProperty("name")]
        public string Name;
    }
}
