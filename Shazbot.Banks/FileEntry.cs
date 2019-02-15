using Newtonsoft.Json;

namespace Shazbot.Banks
{
    public class FileEntry : Entry
    {
        [JsonProperty("file")]
        public string File;
    }
}
