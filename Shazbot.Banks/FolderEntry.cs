using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Input;

namespace Shazbot.Banks
{
    public class FolderEntry : Entry
    {
        [JsonProperty("entries")]
        public IDictionary<Key, Entry> Entries;

        [JsonProperty("path")]
        public string Path;
    }
}
