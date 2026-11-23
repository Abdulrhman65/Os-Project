using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Threading;

namespace OsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel8.Paint += panel8_Paint;
            dataGridView1.CellClick += (s, e) => panel8.Invalidate();
            PathBox.TextChanged += (s, e) => panel8.Invalidate();
        }
        #region Abdulrhman Nofal's
        #region Public Vars
        string CurrentFolderPath = "";
        string SelectedItemPath = "";
        private static Mutex mutex = new();
        int OpCount;
        int NumOfCreated;
        int NumOfDeleted;
        int NumOfOpened;
        int threadCounter = 0;
        #endregion

        #region App Mithods
        private void Form1_Load(object sender, EventArgs e)
        {
            CursorChange(sender, e);
            CurrentFolderPath = ViewThisPC();
            PathBox.Text = CurrentFolderPath;
            dataGridView1.CellClick += (s, args) =>
            {
                if (args.RowIndex >= 0 && args.RowIndex < dataGridView1.Rows.Count)
                {
                    var selectedRow = dataGridView1.Rows[args.RowIndex];
                    string selectedPath = selectedRow.Tag?.ToString();
                    if (!string.IsNullOrEmpty(selectedPath))
                    {
                        SelectedItemPath = selectedPath;
                        PathBox.Text = CurrentFolderPath;
                        if (File.Exists(selectedPath))
                        {
                            FileInfo fileInfo = new(selectedPath);
                            ItemInfo(fileInfo);
                        }
                        else if (Directory.Exists(selectedPath))
                        {
                            DirectoryInfo directoryInfo = new(selectedPath);
                            ItemInfo(directoryInfo);
                        }
                    }
                }
            };
        }
        private void ThisPCLabel_Click(object sender, EventArgs e)
        {
            CurrentFolderPath = ViewThisPC();
            PathBox.Text = CurrentFolderPath;
            SelectedItemPath = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(SelectedItemPath))
            {
                string folderPath = SelectedItemPath;
                LoadDirectory(SelectedItemPath);
                UpdateStats("Open");
                AddLog($"({new DirectoryInfo(folderPath).Name}) Opened", Color.Green);
            }
            else
            {
                MessageBox.Show("Please select a folder to open.");
            }
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderbrowser = new();
            if (folderbrowser.ShowDialog() == DialogResult.OK)
            {
                CurrentFolderPath = folderbrowser.SelectedPath;
                PathBox.Text = CurrentFolderPath;
                LoadDirectory(CurrentFolderPath);
            }
        }
        private void DocumentsLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
        private void PicturesLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }
        private void MusicLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }
        private void VideosLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }
        private void LocalDiscCLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(@"C:\");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedItemPath) || !File.Exists(SelectedItemPath))
            {
                MessageBox.Show("Please select a file first.");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Click 'Yes' to Copy, 'No' to Move, or 'Cancel' to abort.",
                "Select Operation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Cancel) return;
            bool isMove = (result == DialogResult.No);
            using FolderBrowserDialog folder = new();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = SelectedItemPath;
                string destPath = Path.Combine(folder.SelectedPath, Path.GetFileName(sourcePath));

                if (sourcePath.Equals(destPath, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Source and destination paths are the same.");
                    return;
                }
                RunInThread(() => CopyOrMoveFile(sourcePath, destPath, isMove));
            }

        }
        #endregion

        #region  Abdulrhman Nofal's Mithods
        private void ItemInfo<T>(T item) where T : FileSystemInfo
        {
            FileNameLable.Text = item.Name;
            FilePathLable.Text = item.FullName;
            ExtensionLable.Text = item is FileInfo ? item.Extension : "Folder";
            SizeLable.Text = item is FileInfo file ? $"{Math.Round(file.Length / (1024.0), 3)} kB" : "-";
            CreatedLable.Text = item.CreationTime.ToString();
            ModifiedLable.Text = item.LastWriteTime.ToString();
        }
        private string ViewThisPC()
        {
            dataGridView1.Rows.Clear();

            DriveInfo.GetDrives().Where(d => d.IsReady).ToList().ForEach(drive =>
            {
                dataGridView1.Rows.Add($"Local Disk ({drive.Name.Split(':')[0]})", drive.DriveType, Math.Round(drive.TotalSize / (1024.0 * 1024 * 1024), 2) + " GB", '-');
                dataGridView1.Rows[^1].Tag = drive.Name;
            });
            AddLog("(This Pc) Opened", Color.Green);
            return "This PC";
        }
        private void CursorChange(object sender, EventArgs e)
        {
            ThisPCLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            ThisPCLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            DocumentsLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            DocumentsLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            PicturesLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            PicturesLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            MusicLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            MusicLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            VideosLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            VideosLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            LocalDiscCLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            LocalDiscCLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };

        }
        public void LoadDirectory(string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new(path);
                List<FileInfo> items = [.. directoryInfo.GetFiles()];
                List<DirectoryInfo> directories = [.. directoryInfo.GetDirectories()];
                dataGridView1.Rows.Clear();
                foreach (var dir in directories)
                {
                    dataGridView1.Rows.Add(dir.Name, "Folder", "-", "-");
                    dataGridView1.Rows[^1].Tag = dir.FullName;
                }
                foreach (var file in items)
                {
                    dataGridView1.Rows.Add(file.Name, "File", Math.Round(file.Length / (1024.0), 3) + " kB", file.LastWriteTime);
                    dataGridView1.Rows[^1].Tag = file.FullName;
                }
                CurrentFolderPath = path;
                SelectedItemPath = "";
                PathBox.Text = CurrentFolderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading directory: {ex.Message}");
            }
        }
        public void UpdateStats(string OperationType)
        {
            mutex.WaitOne();
            int totalop = 0;
            int opend = 0;
            int created = 0;
            int deleted = 0;
            try
            {
                OpCount++;
                switch (OperationType)
                {
                    case "Create":
                        NumOfCreated++;
                        break;
                    case "Open":
                        NumOfOpened++;
                        break;
                    case "Delete":
                        NumOfDeleted++;
                        break;
                }
                totalop = OpCount;
                opend = NumOfOpened;
                created = NumOfCreated;
                deleted = NumOfDeleted;
            }
            catch (Exception ex)
            {
                AddLog($"Error updating stats: {ex.Message}", Color.Red);
            }
            finally
            {
                mutex.ReleaseMutex();
            }
            this.BeginInvoke(new Action(() =>
            {
                OperationsCountLabel.Text = totalop.ToString();
                OpenedLabel.Text = opend.ToString();
                CreatedLabel.Text = created.ToString();
                DeletedLabel.Text = deleted.ToString();
            }));
        }
        public void AddLog(string Msg, Color color)
        {
            mutex.WaitOne();
            try
            {
                string LogLine = $"{Msg} - {Thread.CurrentThread.Name ?? "Main-Thread"} - {DateTime.Now:hh:mm:ss tt}\n";
                LogBox.BeginInvoke(new Action(() =>
                {
                    LogBox.SelectionStart = LogBox.TextLength;
                    LogBox.SelectionColor = color;
                    LogBox.AppendText(LogLine);
                    LogBox.ScrollToCaret();
                }));
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
        public void RunInThread(Action work)
        {
            int id = Interlocked.Increment(ref threadCounter);
            Thread thread = new(() =>
            {
                Thread.CurrentThread.Name = $"Thread-{id}";
                work();
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public void UpdateProgress(string status, int percent)
        {
            string ThreadName = Thread.CurrentThread.Name ?? "Main-Thread";
            this.BeginInvoke(new Action(() =>
            {
                CurrentOp.Text = status;
                progressBar.Value = Math.Clamp(percent, 0, 100);
                Per.Text = $"{percent}%";
                CurrentThread.Text = $"Running in: {ThreadName}";
            }));
        }
        private void CopyOrMoveFile(string sourcePath, string destPath, bool isMove)
        {
            string fileName = Path.GetFileName(sourcePath);
            string actionText = isMove ? "Moving" : "Copying";
            try
            {
                UpdateProgress($"{actionText} {fileName}...", 0);
                int lastPercent = 0;

                {
                    using FileStream SourceStream = new(sourcePath, FileMode.Open, FileAccess.Read);
                    using FileStream DestStream = new(destPath, FileMode.Create, FileAccess.Write);

                    long TotalBytes = SourceStream.Length;
                    long CopiedBytes = 0;
                    byte[] Buffer = new byte[81920];
                    int BytesRead;

                    if (TotalBytes == 0)
                    {
                        UpdateProgress($"{actionText} {fileName}...", 100);
                    }
                    else
                    {
                        while ((BytesRead = SourceStream.Read(Buffer, 0, Buffer.Length)) > 0)
                        {
                            DestStream.Write(Buffer, 0, BytesRead);
                            CopiedBytes += BytesRead;

                            int percent = (int)((CopiedBytes * 100) / TotalBytes);
                            if (percent > lastPercent)
                            {
                                lastPercent = percent;
                                UpdateProgress($"{actionText} {fileName}...", percent);
                            }
                        }
                    }
                }
                if (isMove)
                {
                    File.Delete(sourcePath);
                }
                string OpType = isMove ? "Move" : "Copy";
                UpdateProgress($"{OpType} completed", 100);
                AddLog($"({fileName}) {(isMove ? "Moved" : "Copied")}", Color.Green);
                UpdateStats(OpType);

                if (CurrentFolderPath != "This PC" && Directory.Exists(CurrentFolderPath))
                {
                    this.BeginInvoke(new Action(() => LoadDirectory(CurrentFolderPath)));
                }
            }
            catch (Exception ex)
            {
                UpdateProgress("Operation failed", 0);
                AddLog($"Error {(isMove ? "moving" : "copying")} ({fileName}): {ex.Message}", Color.Red);
            }
        }
        #endregion
        #endregion

        #region Elnaggar
        private void button6_Click(object sender, EventArgs e)
        {
            StartSearch();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents adding a new line
                StartSearch();
            }
        }
        private void StartSearch()
        {
            string searchText = textBox1.Text.Trim();

            // If the search box is empty
            if (string.IsNullOrEmpty(searchText))
            {
                if (CurrentFolderPath == "This PC")
                {
                    CurrentFolderPath = ViewThisPC();
                    SelectedItemPath = "";
                }
                else if (Directory.Exists(CurrentFolderPath))
                {
                    LoadDirectory(CurrentFolderPath);
                }
                return;
            }

            // Decide what paths to search: all ready drives if on "This PC", otherwise just the current folder
            string[] pathsToSearch;

            if (CurrentFolderPath == "This PC")
            {
                pathsToSearch = DriveInfo.GetDrives()
                    .Where(d => d.IsReady)
                    .Select(d => d.Name)
                    .ToArray();
            }
            else if (Directory.Exists(CurrentFolderPath))
            {
                pathsToSearch = [CurrentFolderPath];
            }
            else
            {
                MessageBox.Show("Invalid folder path.");
                return;
            }

            // Run the search on a background thread
            RunInThread(() => SearchFiles(pathsToSearch, searchText));
        }
        private void SearchFiles(string[] pathsToSearch, string searchText)
        {
            try
            {
                UpdateProgress($"Searching for {searchText}...", 0);

                // Search all subfolders automatically and skip protected Windows/system folders
                EnumerationOptions options = new()
                {
                    RecurseSubdirectories = true,
                    IgnoreInaccessible = true,
                    MatchCasing = MatchCasing.CaseInsensitive
                };

                List<FileSystemInfo> foundItems = [];

                // Loop through each drive 
                for (int i = 0; i < pathsToSearch.Length; i++)
                {
                    string path = pathsToSearch[i];
                    UpdateProgress($"Searching in {path} for {searchText}...", (i * 90) / pathsToSearch.Length);

                    try
                    {
                        DirectoryInfo dir = new(path);
                        foundItems.AddRange(dir.GetFileSystemInfos($"*{searchText}*", options));
                    }
                    catch (Exception)
                    {
                        // Skip a drive/folder if it becomes unavailable mid-search
                    }

                    int percent = ((i + 1) * 90) / pathsToSearch.Length;
                    UpdateProgress($"Searching for {searchText}...", percent);
                }

                // No matching files found anywhere
                if (foundItems.Count == 0)
                {
                    UpdateProgress("File or folder not found", 0);
                    AddLog($"({searchText}) Not found", Color.Red);

                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show("File or folder not found.");
                    }));
                    return;
                }

                // Display the matching files in the table on the UI thread
                this.BeginInvoke(new Action(() =>
                {
                    dataGridView1.Rows.Clear();
                    SelectedItemPath = "";

                    foreach (FileSystemInfo item in foundItems)
                    {
                        if (item is DirectoryInfo folder)
                        {
                            dataGridView1.Rows.Add(folder.Name, "Folder", "-", "-");
                            dataGridView1.Rows[^1].Tag = folder.FullName;
                        }
                        else if (item is FileInfo file)
                        {
                            dataGridView1.Rows.Add(
                                file.Name,
                                "File",
                                Math.Round(file.Length / 1024.0, 3) + " kB",
                                file.LastWriteTime
                            );
                            dataGridView1.Rows[^1].Tag = file.FullName;
                        }
                    }
                }));

                UpdateProgress($"Search completed ({foundItems.Count} found)", 100);
                AddLog($"Search ({searchText}): {foundItems.Count} item(s) found", Color.Green);
                UpdateStats("Search");
            }
            catch (Exception ex)
            {
                UpdateProgress("Search failed", 0);
                AddLog($"Error searching ({searchText}): {ex.Message}", Color.Red);
            }
        }
        // opens .txt files in Notepad, and any other file extension in its Windows default app
        private System.Diagnostics.Process? OpenWithApp(string filePath)
        {
            bool isTxt = Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase);

            if (isTxt)
            {
                return System.Diagnostics.Process.Start("notepad.exe", $"\"{filePath}\"");
            }

            return System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }
        // read file
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedItemPath) || !File.Exists(SelectedItemPath))
            {
                MessageBox.Show("Please select a file to read first.");
                return;
            }

            string filePath = SelectedItemPath;
            string fileName = Path.GetFileName(filePath);
            bool isTxt = Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase);

            RunInThread(() =>
            {
                try
                {
                    if (isTxt)
                    {
                        // for txt files read lines on the background thread log steps then open in Notepad
                        bool readSuccess = ReadTextFile(filePath);
                        if (!readSuccess) return;

                        AddLog($"Opening ({fileName}) in Notepad...", Color.Blue);
                        using var proc = OpenWithApp(filePath);
                    }
                    else
                    {
                        // For non txt files: skip StreamReader and launch the default app directly
                        string ext = Path.GetExtension(filePath);
                        UpdateProgress($"Opening {fileName}...", 50);
                        AddLog($"Step 1: Launching default app for ({fileName}) [{ext}]", Color.Blue);

                        using var proc = OpenWithApp(filePath);

                        UpdateProgress($"Opened ({fileName})", 100);
                        AddLog($"Step 2: ({fileName}) opened with default application", Color.Green);
                    }

                    UpdateStats("Read");
                }
                catch (Exception ex)
                {
                    UpdateProgress("Read failed", 0);
                    AddLog($"Error opening ({fileName}): {ex.Message}", Color.Red);
                }
            });
        }
        private bool ReadTextFile(string filePath)
        {
            string fileName = Path.GetFileName(filePath);

            try
            {
                UpdateProgress($"Opening {fileName}...", 0);
                AddLog($"Step 1: Starting to read ({fileName})", Color.Blue);

                int lineCount = 0;

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader reader = new(fs))
                {
                    long totalBytes = fs.Length;
                    int lastPercent = 0;

                    AddLog($"Step 2: Reading content from ({fileName})...", Color.DarkSlateGray);

                    while (reader.ReadLine() != null)
                    {
                        lineCount++;

                        if (totalBytes > 0)
                        {
                            int percent = (int)((fs.Position * 100) / totalBytes);
                            if (percent > lastPercent)
                            {
                                lastPercent = percent;
                                UpdateProgress($"Reading {fileName}...", percent);
                            }
                        }
                    }
                }

                UpdateProgress($"Read completed ({fileName})", 100);
                AddLog($"Step 3: Finished reading ({fileName}) - {lineCount} line(s)", Color.Green);
                return true;
            }
            catch (Exception ex)
            {
                UpdateProgress("Read failed", 0);
                AddLog($"Error reading ({fileName}): {ex.Message}", Color.Red);
                return false;
            }
        }
        // write file
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedItemPath) || !File.Exists(SelectedItemPath))
            {
                MessageBox.Show("Please select a file to write to first.");
                return;
            }

            string filePath = SelectedItemPath;
            string fileName = Path.GetFileName(filePath);

            RunInThread(() => WriteFileWithApp(filePath, fileName));
        }
        private void WriteFileWithApp(string filePath, string fileName)
        {
            bool isTxt = Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase);
            string appLabel = isTxt ? "Notepad" : "default app";

            try
            {
                // launch Notepad or the OS default app (other extensions)
                UpdateProgress($"Opening {fileName} in {appLabel}...", 30);
                AddLog($"Step 1: Launching {appLabel} to edit ({fileName})", Color.Blue);

                using var proc = OpenWithApp(filePath);

                // wait for the launched process to close 
                UpdateProgress($"Editing {fileName} in {appLabel}...", 60);
                AddLog($"Step 2: Waiting for edits to ({fileName}) to finish...", Color.DarkSlateGray);

                proc?.WaitForExit();

                //  log completion and update operation stats
                UpdateProgress($"Finished editing ({fileName})", 100);
                AddLog($"Step 3: Finished editing ({fileName})", Color.Green);
                UpdateStats("Write");

                // Refresh the table and File Details panel on the UI thread to reflect any size/date changes
                this.BeginInvoke(new Action(() =>
                {
                    if (CurrentFolderPath != "This PC" && Directory.Exists(CurrentFolderPath))
                    {
                        LoadDirectory(CurrentFolderPath);
                    }
                    if (File.Exists(filePath))
                    {
                        SelectedItemPath = filePath;
                        ItemInfo(new FileInfo(filePath));
                    }
                }));
            }
            catch (Exception ex)
            {
                UpdateProgress("Write failed", 0);
                AddLog($"Error editing ({fileName}): {ex.Message}", Color.Red);
            }
        }
        #endregion

        #region Abdulrahman Nossier
        private void getInfobtn_Click(object sender, EventArgs e)
        {
            string targetPath = !string.IsNullOrEmpty(SelectedItemPath) ? SelectedItemPath : CurrentFolderPath;

            if (string.IsNullOrEmpty(targetPath) || targetPath == "This PC")
            {
                MessageBox.Show("Please select a drive first.");
                return;
            }

            string? root = Path.GetPathRoot(targetPath);
            if (string.IsNullOrEmpty(root))
            {
                MessageBox.Show("Please select a valid drive.");
                return;
            }

            DriveInfo drive = new(root);
            string info = "";

            if (drive.IsReady)
            {
                info = $"Drive Name: {drive.Name}\n" +
                       $"File System: {drive.DriveFormat}\n" +
                       $"Drive Type: {drive.DriveType}\n" +
                       $"Total size of drive: {(drive.TotalSize / Math.Pow(1024, 3)):F2} GB\n" +
                       $"Total available space: {(drive.TotalFreeSpace / Math.Pow(1024, 3)):F2} GB\n" +
                       $"Total Used space: {((drive.TotalSize - drive.TotalFreeSpace) / Math.Pow(1024, 3)):F2} GB\n" +
                       $"==================";
            }
            else
            {
                info = $"Drive {drive.Name} is not ready.\n" +
                       $"==================";
            }

            AddLog($"Drive ({drive.Name}) info displayed", Color.Green);
            UpdateStats("DriveInfo");
            MessageBox.Show(info, "Drive Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedItemPath) ||
                CurrentFolderPath == "This PC" ||
                string.Equals(Path.GetPathRoot(SelectedItemPath), SelectedItemPath, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please select a file or folder to delete.");
                return;
            }
            string targetPath = SelectedItemPath;
            string itemName = Path.GetFileName(targetPath);
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{itemName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                RunInThread(() => DeleteItem(targetPath));
            }
        }
        private void DeleteItem(string targetPath)
        {
            string itemName = Path.GetFileName(targetPath);
            try
            {
                UpdateProgress($"Deleting {itemName}...", 30);
                if (File.Exists(targetPath))
                {
                    AddLog($"Deleting file: ({itemName})...", Color.Blue);
                    File.Delete(targetPath);
                    AddLog($"({itemName}) File deleted", Color.Green);
                }
                else if (Directory.Exists(targetPath))
                {
                    AddLog($"Deleting folder: ({itemName})...", Color.Blue);
                    Directory.Delete(targetPath, true);
                    AddLog($"({itemName}) Folder deleted", Color.Green);
                }
                else
                {
                    UpdateProgress("Delete failed", 0);
                    AddLog($"Path does not exist: ({itemName})", Color.Red);
                    return;
                }
                UpdateProgress($"Deleted ({itemName})", 100);
                UpdateStats("Delete");
                this.BeginInvoke(new Action(() =>
                {
                    if (CurrentFolderPath != "This PC" && Directory.Exists(CurrentFolderPath))
                    {
                        LoadDirectory(CurrentFolderPath);
                    }
                    FileNameLable.Text = "-";
                    FilePathLable.Text = "-";
                    ExtensionLable.Text = "-";
                    SizeLable.Text = "-";
                    CreatedLable.Text = "-";
                    ModifiedLable.Text = "-";
                }));
            }
            catch (Exception ex)
            {
                UpdateProgress("Delete failed", 0);
                AddLog($"Delete failed ({itemName}): {ex.Message}", Color.Red);
            }
        }






        #endregion

        #region Abdelrahman Hassan

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            string path = CurrentFolderPath;
            if (SelectedItemPath != "")
                path = SelectedItemPath;

            string root = "C:\\";
            if (path != "" && path != "This PC")
                root = Path.GetPathRoot(path);

            DriveInfo drive = new DriveInfo(root);
            if (!drive.IsReady)
                return;

            double total = drive.TotalSize / (1024.0 * 1024 * 1024);
            double free = drive.TotalFreeSpace / (1024.0 * 1024 * 1024);
            double used = total - free;
            double ratio = used / total;

            int percent = (int)(ratio * 100);
            label14.Text = "Disk (" + drive.Name[0] + ":):";

            int x = label14.Right + 5;
            int y = label14.Top;
            int h = label14.Height;
            int w = panel8.Width - x - DiskSpaceLabel.Width - 20;

            if (w <= 10)
                return;

            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, x, y, w, h);

            if (ratio > 0.8)
                g.FillRectangle(Brushes.Red, x, y, (int)(w * ratio), h);
            else
                g.FillRectangle(Brushes.Green, x, y, (int)(w * ratio), h);

            g.DrawRectangle(Pens.Gray, x, y, w, h);

            DiskSpaceLabel.Left = x + w + 5;
            DiskSpaceLabel.Text = percent + "%";
        }






        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Delete all logs?",
            "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                mutex.WaitOne();
                try { LogBox.Clear(); }
                finally { mutex.ReleaseMutex(); }
            }





        }

    
    }
    #endregion
}
