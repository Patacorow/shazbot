using Shazbot.Banks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace Shazbot
{
    public partial class PlayerForm : Form
    {
        private const int MIN_HEIGHT = 38;
        private const double FOLDER_COLOR_MULT = 0.8;

        public event Action<string> FileSelected;

        private readonly KeyboardListener _kListener;
        private readonly Key _openKey;
        private readonly FolderEntry _rootEntry;

        private string _title;
        private bool _open;
        private FolderEntry _currentFolder;
        private string _currentPath;

        public PlayerForm(Key openKey, FolderEntry rootEntry)
        {
            InitializeComponent();
            _kListener = new KeyboardListener();
            _kListener.PreventDefault = true;
            _kListener.KeyDown += HookKeyDown;
            _title = "VGS";
            _open = false;

            _openKey = openKey;
            _rootEntry = rootEntry;

            HidePlayer();
        }

        public void ShowPlayer()
        {
            _currentFolder = _rootEntry;
            _currentPath = _rootEntry.Path;
            RefreshView();

            _kListener.PreventDefault = true;
            _open = true;
            Visible = true;
        }

        public void HidePlayer()
        {
            _open = false;
            AfterDelay(() =>
            {
                Visible = false;
                _kListener.PreventDefault = false;
            });
        }

        private void RefreshView()
        {
            labelTitle.Text = _currentFolder.Name;

            IEnumerable<Label> folders = _currentFolder.Entries
                .Where(kvp => kvp.Value is FolderEntry)
                .Select(kvp => new Label
                {
                    Text = $"+ {kvp.Key}: {kvp.Value.Name}",
                    Font = Font,
                    ForeColor = Color.FromArgb((int)(ForeColor.R * FOLDER_COLOR_MULT), (int)(ForeColor.G * FOLDER_COLOR_MULT), (int)(ForeColor.B * FOLDER_COLOR_MULT))
                });

            IEnumerable<Label> files = _currentFolder.Entries
                .Where(kvp => kvp.Value is FileEntry)
                .Select(kvp => new Label
                {
                    Text = $"► {kvp.Key}: {kvp.Value.Name}",
                    Font = Font,
                    ForeColor = ForeColor
                });

            int requiredHeight = folders.Sum(x => x.Height) + files.Sum(x => x.Height);
            Height = MIN_HEIGHT + requiredHeight;

            // Clear view
            entriesPanel.Controls.Clear();

            foreach (Label label in folders)
                entriesPanel.Controls.Add(label);
            foreach (Label label in files)
                entriesPanel.Controls.Add(label);

            entriesPanel.Height = requiredHeight;
        }

        private void HookKeyDown(object sender, RawKeyEventArgs args)
        {
            Key key = args.Key;
            if (!_open)
            {
                if (key == _openKey)
                {
                    ShowPlayer();
                }
                return;
            }
            if (key == Key.Escape)
            {
                HidePlayer();
                return;
            }

            if ((int)args.Key < 44 || (int)args.Key > 69)
            {
                // Not inside ABC range
                return;
            }

            if (!_currentFolder.Entries.ContainsKey(key))
            {
                return;
            }

            Entry entry = _currentFolder.Entries[key];
            if (entry is FolderEntry folder)
            {
                _currentFolder = folder;
                _currentPath = Path.Combine(_currentPath, _currentFolder.Path);
                RefreshView();
                return;
            }
            else if (entry is FileEntry file)
            {
                FileSelected?.Invoke(Path.Combine(_currentPath, file.File));
                HidePlayer();
            }
        }

        private void AfterDelay(Action action)
        {
            Timer t = new Timer();
            t.Interval = 10;
            t.Tick += delegate
            {
                t.Stop();
                action();
                t.Dispose();
            };
            t.Start();
        }
    }
}
