using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace Shazbot.Banks
{
    public static class SoundbankGenerator
    {
        private static Dictionary<Key, FileEntry> _emptyEntries = new Dictionary<Key, FileEntry>();
        private static Dictionary<Key, FolderEntry> _emptySubCats = new Dictionary<Key, FolderEntry>();

        private const int MIN_CHAR = 44;
        private const int MAX_CHAR = 69;

        public static FolderEntry CreateSoundbank(string directory, string name)
        {
            DirectoryInfo info = new DirectoryInfo(directory);

            FolderEntry entry = new FolderEntry
            {
                Name = string.IsNullOrEmpty(name) ? info.Name : name,
            };

            // Add entries
            foreach (FileInfo file in info.EnumerateFiles("*.wav", SearchOption.TopDirectoryOnly))
            {
                FileEntry subFileEntry  = new FileEntry
                {
                    Name = Path.GetFileNameWithoutExtension(file.FullName),
                    File = file.Name
                };
                TryAddEntry(subFileEntry, entry, true);
            }

            // Add sub-categories
            foreach (DirectoryInfo subDir in info.EnumerateDirectories("*", SearchOption.TopDirectoryOnly))
           {
                FolderEntry subFolderEntry = CreateSoundbank(subDir.FullName, subDir.Name);

                // Only add folders with actual entries in them
                if (subFolderEntry.Entries?.Count != 0)
                {
                    subFolderEntry.Path = subDir.Name;
                    TryAddEntry(subFolderEntry, entry, false);
                }
            }

            return entry;
        }

        private static void TryAddEntry(Entry entry, FolderEntry folder, bool isFile)
        {
            var entries = folder.Entries ?? _emptyEntries;
            var subCats = folder.SubCategories ?? _emptySubCats;
            if (entries.Count + subCats.Count == 26)
            {
                throw new InvalidOperationException($"Cannot add {(isFile ? "entry" : "sub-category")} '{entry.Name}' to folder '{folder.Name}' as it already has 26 items.");
            }

            // Use entry name and find key
            for (int i = 0; i < entry.Name.Length; i++)
            {
                string letter = entry.Name[i].ToString();
                // Convert the letter to a key enum
                if (!Enum.TryParse(letter, out Key key)) continue; // Can't parse
                if ((int)key < MIN_CHAR || (int)key > MAX_CHAR) continue; // Outside A-Z range
                if (entries.ContainsKey(key) || subCats.ContainsKey(key)) continue;

                AddEntry(key, entry, folder, isFile);
                return;
            }

            // Try using A-Z
            for (Key key = Key.A; (int)key < MAX_CHAR; key++)
            {
                if (entries.ContainsKey(key) || subCats.ContainsKey(key)) continue;

                AddEntry(key, entry, folder, isFile);
                return;
            }
        }

        private static void AddEntry(Key key, Entry entry, FolderEntry folder, bool isFile)
        {
            if (isFile)
            {
                if (folder.Entries == null)
                {
                    folder.Entries = new Dictionary<Key, FileEntry>();
                }
                folder.Entries.Add(key, entry as FileEntry);
            }
            else
            {
                if (folder.SubCategories == null)
                {
                    folder.SubCategories = new Dictionary<Key, FolderEntry>();
                }
                folder.SubCategories.Add(key, entry as FolderEntry);
            }
        }
    }
}
