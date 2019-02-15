using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Input;

namespace Shazbot.Banks
{
    public class FolderEntry : Entry
    {
        [JsonProperty("entries")]
        public IDictionary<Key, FileEntry> Entries;

        [JsonProperty("subCategories")]
        public IDictionary<Key, FolderEntry> SubCategories;

        [JsonProperty("path")]
        public string Path;
    }
}
