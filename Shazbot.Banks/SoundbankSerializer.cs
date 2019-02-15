using Newtonsoft.Json;
using System;
using System.Windows.Input;

namespace Shazbot.Banks
{
    public static class SoundbankSerializer
    {
        public const string FILTER = "Soundbank JSON (*.json)|*.json";

        public static string Serialize(FolderEntry soundbank)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            return JsonConvert.SerializeObject(soundbank, settings);
        }

        public static FolderEntry Deserialize(string json)
        {
            var bank = JsonConvert.DeserializeObject<FolderEntry>(json);
            VerifyBank(bank);
            return bank;
        }

        private static void VerifyBank(FolderEntry soundbank)
        {
            if (soundbank.SubCategories != null)
            {
                foreach (var kvp in soundbank.SubCategories)
                {
                    Key key = kvp.Key;
                    FolderEntry entry = kvp.Value;

                    if (string.IsNullOrEmpty(entry.Name) && string.IsNullOrEmpty(entry.Path))
                    {
                        throw new ArgumentException($"The sub-category entry under the {key} key for category '{soundbank.Name}' has no name AND path (at least needs a path).");
                    }

                    if (soundbank.Entries != null && soundbank.Entries.ContainsKey(key))
                    {
                        throw new ArgumentException($"The key {key} for sub-category '{kvp.Value.Name}' in category '{soundbank.Name}' already exists in that category's entries.");
                    }

                    VerifyBank(entry);
                }
            }

            if (soundbank.Entries != null)
            {
                foreach (var kvp in soundbank.Entries)
                {
                    Key key = kvp.Key;
                    FileEntry entry = kvp.Value;

                    if (string.IsNullOrEmpty(entry.Name) && string.IsNullOrEmpty(entry.File))
                    {
                        throw new ArgumentException($"The sound entry under the {key} key for category '{soundbank.Name}' has no name AND file (at least needs a filename).");
                    }

                    if (soundbank.SubCategories != null && soundbank.SubCategories.ContainsKey(key))
                    {
                        throw new ArgumentException($"The key {key} for entry '{kvp.Value.Name}' in category '{soundbank.Name}' already exists in that category's sub-categories.");
                    }
                }
            }
        }
    }
}
