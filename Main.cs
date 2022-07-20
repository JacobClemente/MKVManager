namespace RedoMKV
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Forms;
    using System.IO;
    using System.Linq;

    using Microsoft.WindowsAPICodePack.Dialogs;
    using System.Text.RegularExpressions;
    public partial class Main : Form
    {
        Thread thread = null;
        private delegate void SafeCallDelegate(string text);
        private delegate void SafeCallDelegate2();
        private delegate void SafeCallDelegate3(string original, string text);

        bool isPathed = false;
        string toolNix = "";
        string[] selectedFiles = null;

        public Main()
        {
            InitializeComponent();
            string initialPath;
            if (Directory.Exists("C:\\Program Files\\MKVToolNix"))
            {
                initialPath = "C:\\Program Files\\MKVToolNix";
                Regex rgx = new Regex("mkvmerge\\.exe");
                Match match;
                string[] files = Directory.GetFiles(initialPath);
                foreach (string file in files)
                {
                    match = rgx.Match(file);
                    if (match.Success)
                    {
                        isPathed = true;
                        toolNix = initialPath;
                        mkvTbox.Text = initialPath;
                    }
                }
            }
            list.ScrollAlwaysVisible = true;
            verifyRequirements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                setText(("Placeholder"));
            });
            thread.Start();
        }

        private void writeText(string text)
        {
            if (displayTbox.InvokeRequired)
            {
                var d = new SafeCallDelegate(writeText);
                displayTbox.Invoke(d, new object[] { text });
            } else
            {
                displayTbox.AppendText(text + Environment.NewLine);
            }
        }

        private void denoteProgress(string text)
        {
            if (displayTbox.InvokeRequired)
            {
                var d = new SafeCallDelegate(denoteProgress);
                displayTbox.Invoke(d, new object[] { text });
            }
            else
            {
                if (displayTbox.Lines.Length > 0)
                {
                    Regex rgx = new Regex("Progress");
                    string test = displayTbox.Lines[displayTbox.Lines.Length - 2];
                    Match m = rgx.Match(test);
                    if (m.Success)
                    {
                        if (Environment.NewLine.CompareTo("\r\n") == 0)
                        {
                            displayTbox.Text = displayTbox.Text.Substring(0, displayTbox.Text.LastIndexOf('\r'));
                            displayTbox.Text = displayTbox.Text.Substring(0, displayTbox.Text.LastIndexOf('\r'));
                            displayTbox.AppendText(Environment.NewLine);
                            displayTbox.AppendText(text + Environment.NewLine);
                        }
                        else
                        {
                            displayTbox.Text = displayTbox.Text.Substring(0, displayTbox.Text.LastIndexOf('\n'));
                            displayTbox.Text = displayTbox.Text.Substring(0, displayTbox.Text.LastIndexOf('\n'));
                            displayTbox.AppendText(Environment.NewLine);
                            displayTbox.AppendText(text + Environment.NewLine);
                        }
                    } else
                    {
                        displayTbox.AppendText(text + Environment.NewLine);
                    }

                } else
                    displayTbox.AppendText(text + Environment.NewLine);
            }
        }

        private void setListValue(string original, string text)
        {
            if (list.InvokeRequired)
            {
                var d = new SafeCallDelegate3(setListValue);
                list.Invoke(d, new object[] { original, text });
            }
            else
            {
                int a = list.Items.IndexOf(original);
                list.Items.RemoveAt(a);
                list.Items.Insert(a, text);
                list.SetSelected(a, true);
            }
        }

        private void setText(string arguments)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "mkvinfo";
            p.StartInfo.Arguments = arguments;
            p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (e.Data != null)
                {
                    writeText(e.Data);
                }
            });
            p.Start();
            p.BeginOutputReadLine();

            p.WaitForExit();
            p.Close();
        }

        private void moveItem(int direction)
        {
            if (list.SelectedItems.Count == 0 || list.SelectedIndices[0] < 0)
                return;
            if (direction == -1)
                for (int i = 0; i < list.SelectedItems.Count; i++)
                {
                    int newIndex = list.SelectedIndices[i] - 1;
                    if (newIndex < 0)
                        return;
                    object selected = list.Items[newIndex + 1];
                    list.Items.Remove(selected);
                    list.Items.Insert(newIndex, selected);
                    list.SetSelected(newIndex, true);
                } else
                for (int i = list.SelectedItems.Count - 1; i >= 0; i--)
                {
                    int newIndex = list.SelectedIndices[i] + 1;
                    if (newIndex >= list.Items.Count)
                        return;
                    object selected = list.Items[newIndex - 1];
                    list.Items.Remove(selected);
                    list.Items.Insert(newIndex, selected);
                    list.SetSelected(newIndex, true);
                }
        }

        private void toggleButtons(bool enable)
        {
            mergeBtn.Enabled = enable;
            extractBtn.Enabled = enable;
            readBtn.Enabled = enable;
            addAttachBtn.Enabled = enable;
            renameTitleBtn.Enabled = enable;
            changeNameBtn.Enabled = enable;
            changeDefaultBtn.Enabled = enable;
        }

        private void readTracks()
        {
            getSelectedFiles();
            for (int i = 0; i < selectedFiles.Length; i++)
            {
                string output = "";
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = '\"' + toolNix + "\\mkvinfo.exe\"";
                p.StartInfo.Arguments = '\"' + list.SelectedItems[i].ToString() + '\"';
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        output += e.Data;
                        output += "\n";
                    }
                });
                p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();

                Regex trackPattern = new Regex("(?:\\| \\+ Track\\n)(?:(?!\\| \\+ Track\\n|\\|\\+ Tags|\\|\\+ Chapters).*\\n)*");
                MatchCollection trackMatches = trackPattern.Matches(output);

                Match keywordMatch;
                Regex trackNumber = new Regex("(?:Track number: +)\\d+.*(\\d+)");
                Regex trackName = new Regex("(?:Name: )(.*)");
                Regex trackLanguage = new Regex("(?:Language: )(.*)");
                Regex trackDefault = new Regex("(?:Default track.*)(\\d)");
                Regex trackType = new Regex("(?:Track type: )(.*)");


                Regex rgx = new Regex(".*\\\\((?!\\\\).*)");
                Match matchName = rgx.Match(selectedFiles[i]);
                writeText(new String('=', 50));
                writeText("");
                writeText(matchName.Groups[1].ToString());
                foreach (Match match in trackMatches)
                {
                    writeText("");
                    keywordMatch = trackNumber.Match(match.ToString());
                    if (keywordMatch.Success)
                        writeText("Track Number: " + keywordMatch.Groups[1]);
                    keywordMatch = trackName.Match(match.ToString());
                    if (keywordMatch.Success)
                        writeText("Track Name: " + keywordMatch.Groups[1]);
                    keywordMatch = trackLanguage.Match(match.ToString());
                    if (keywordMatch.Success)
                        writeText("Track Language: " + keywordMatch.Groups[1]);
                    keywordMatch = trackDefault.Match(match.ToString());
                    if (keywordMatch.Success)
                        writeText("Track Default: " + keywordMatch.Groups[1]);
                    keywordMatch = trackType.Match(match.ToString());
                    if (keywordMatch.Success)
                        writeText("Track Type: " + keywordMatch.Groups[1]);
                }
            }
        }

        private void extractTrack(int trackID, string extension)
        {
            getSelectedFiles();
            for (int i = 0; i < selectedFiles.Length; i++)
            {
                string output = "";
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = '\"' + toolNix + "\\mkvextract.exe\"";

                String arguments = String.Format("\"{0}\" tracks \"{1}:{2}.{3}\"", selectedFiles[i], trackID, selectedFiles[i].Substring(0, selectedFiles[i].Length - 4), extension);
                p.StartInfo.Arguments = arguments;
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        output += e.Data;
                        output += "\n";
                        denoteProgress(e.Data);
                    }
                });
                p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }
        }

        private void mergeTrack(int trackID, string extension, bool isDefault, bool isOverride, string countPrefix, string titleFile, string trackType, string name, string trackName, string language)
        {
            getSelectedFiles();
            string[] titles = null;
            if (titleFile.Length > 0)
            {
                titles = File.ReadLines(titleFile).ToArray();
            }

            for (int i = 0; i < selectedFiles.Length; i++)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = '\"' + toolNix + "\\mkvmerge.exe\"";
                String arguments = "";

                // Sets output title.
                arguments += String.Format("--title \"{0} - {1}{2}{3}\" ",
                    name,
                    countPrefix.Length > 0 ? countPrefix + ' ' : String.Empty,
                    (i + 1).ToString("00"),
                    titles != null && titles.Length > i ? " - " + titles[i] : String.Empty);

                // Sets out filename.
                arguments += String.Format("-o \"{0}{1} - {2}{3}{4}.mkv\" ",
                    String.Format("{0}\\Merged\\", Path.GetDirectoryName(selectedFiles[i])),
                    name,
                    countPrefix.Length > 0 ? countPrefix + ' ' : String.Empty,
                    (i + 1).ToString("00"),
                    titles != null && titles.Length > i ? " - " + titles[i] : String.Empty);

                // Reorder the tracks.
                arguments += "--track-order ";
                for (int j = 0; j < trackID; j++)
                    arguments += "0:" + j + ',';
                arguments += "1:0 ";

                // If track override is enabled, omit the trackID from FID0.
                arguments += isOverride ? String.Format("-{0} !{1} ", trackType, trackID) : String.Empty;

                // Input first file.
                arguments += String.Format("\"{0}\" ", selectedFiles[i]);

                // If default track is enabled, make the second file default.
                arguments += isDefault ? "--default-track 0:1 " : String.Empty;

                // Sets track name.
                arguments += !String.IsNullOrWhiteSpace(trackName) ? String.Format("--track-name 0:\"{0}\" ", trackName) : String.Empty;

                // Sets language.
                arguments += !String.IsNullOrWhiteSpace(language) ? String.Format("--language 0:\"{0}\" ", language) : String.Empty;

                // Input second file.
                arguments += String.Format("\"{0}.{1}\" ", selectedFiles[i].Substring(0, selectedFiles[i].Length - 4), extension);
                p.StartInfo.Arguments = arguments;
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }
            writeText(Environment.NewLine);
        }

        private void addAttach(string[] files)
        {
            getSelectedFiles();
            for (int i = 0; i < selectedFiles.Length; i++)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = '\"' + toolNix + "\\mkvpropedit.exe\"";
                String arguments = "";

                // Input first file.
                arguments += String.Format("\"{0}\" ", selectedFiles[i]);

                // Input second file.
                foreach (string att in files)
                {
                    arguments += String.Format("--add-attachment \"{0}\" ", att);
                }
                p.StartInfo.Arguments = arguments;
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }
            writeText(Environment.NewLine);
        }

        private void rename(string name, string prefix, string titleFile, bool isTitle, bool isFile)
        {
            getSelectedFiles();
            string[] titles = null;
            if (titleFile.Length > 0)
            {
                titles = File.ReadLines(titleFile).ToArray();
            }

            if (isTitle)
            for (int i = 0; i < selectedFiles.Length; i++)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = '\"' + toolNix + "\\mkvpropedit.exe\"";
                String arguments = "";

                // Input first file.
                arguments += String.Format("\"{0}\" ", selectedFiles[i]);

                    // Sets output title.
                    arguments += String.Format("-e info -s \"title={0} - {1}{2}{3}\" ",
                        name,
                        !String.IsNullOrWhiteSpace(prefix) ? prefix + ' ' : String.Empty,
                        (i + 1).ToString("00"),
                        titles != null && titles.Length > i ? " - " + titles[i] : String.Empty);

                p.StartInfo.Arguments = arguments;
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }
            writeText(Environment.NewLine);

            if (isFile)
            {
                for (int i = 0; i < selectedFiles.Length; i++)
                {
                    File.Move(selectedFiles[i], String.Format("{0}{1} - {2}{3}{4}.mkv",
                        String.Format("{0}\\", Path.GetDirectoryName(selectedFiles[i])), 
                        name,
                        !String.IsNullOrWhiteSpace(prefix) ? prefix + ' ' : String.Empty,
                        (i + 1).ToString("00"),
                        titles != null && titles.Length > i ? " - " + titles[i] : String.Empty));
                    setListValue(selectedFiles[i], String.Format("{0}{1} - {2}{3}{4}.mkv",
                        String.Format("{0}\\", Path.GetDirectoryName(selectedFiles[i])),
                        name,
                        !String.IsNullOrWhiteSpace(prefix) ? prefix + ' ' : String.Empty,
                        (i + 1).ToString("00"),
                        titles != null && titles.Length > i ? " - " + titles[i] : String.Empty));
                }
            }
        }

        private void changeName(int trackNo, string name)
        {
            getSelectedFiles();
            for (int i = 0; i < selectedFiles.Length; i++)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = '\"' + toolNix + "\\mkvpropedit.exe\"";
                String arguments = "";

                // Input first file.
                arguments += String.Format("\"{0}\" ", selectedFiles[i]);

                // Set name.
                arguments += String.Format("-e track:{0} -s \"name={1}\"", trackNo + 1, name);

                p.StartInfo.Arguments = arguments;
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }
            writeText(Environment.NewLine);
        }

        private void changeDefault(int[] promotes, int[] demotes)
        {
            getSelectedFiles();
            for (int i = 0; i < selectedFiles.Length; i++)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = '\"' + toolNix + "\\mkvpropedit.exe\"";
                String arguments = "";

                // Input first file.
                arguments += String.Format("\"{0}\" ", selectedFiles[i]);

                // Adds default flag.
                if (promotes != null)
                foreach (int trackID in promotes)
                    arguments += String.Format("-e track:{0} -s \"flag-default=1\" ", trackID + 1);

                // Removes default flag.
                if (demotes != null)
                    foreach (int trackID in demotes)
                    arguments += String.Format("-e track:{0} -s \"flag-default=0\" ", trackID + 1);

                p.StartInfo.Arguments = arguments;
                p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        writeText(e.Data);
                    }
                });
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }
            writeText(Environment.NewLine);
        }
        private void getSelectedFiles()
        {
            if (list.InvokeRequired)
            {
                var d = new SafeCallDelegate2(getSelectedFiles);
                list.Invoke(d, new object[] { });
            }
            else
            {
                selectedFiles = list.SelectedItems.OfType<string>().ToArray();
            }
        }

        private void verifyRequirements()
        {
            if (list.SelectedItems.Count > 0 && isPathed)
            {
                toggleButtons(true);
            }
            else
                toggleButtons(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.InitialDirectory = desktop;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] files = Directory.GetFiles(dialog.FileName);
                /*  Removes the absolute path pre-directories.
                Regex rgx = new Regex(".*\\\\((?!\\\\).*)");
                Match match;
                listBox1.Items.Clear();
                foreach (string file in files)
                {
                    match = rgx.Match(file);
                    if (match.Success)
                    {
                        listBox1.Items.Add(match.Groups[1]);
                    }
                }
                */
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).CompareTo(".mkv") == 0 && !list.Items.Contains(file))
                        list.Items.Add(file);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.InitialDirectory = desktop;
            dialog.Multiselect = true;
            dialog.Filters.Add(new CommonFileDialogFilter("Matroska (.mkv) files", "*.mkv"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] files = dialog.FileNames.ToArray();
                /*  Removes the absolute path pre-directories.
                Regex rgx = new Regex(".*\\\\((?!\\\\).*)");
                Match match;
                listBox1.Items.Clear();
                foreach (string file in files)
                {
                    match = rgx.Match(file);
                    if (match.Success)
                    {
                        listBox1.Items.Add(match.Groups[1]);
                    }
                }
                */
                list.Items.Clear();
                foreach (string file in files)
                {
                    if (!list.Items.Contains(file))
                    list.Items.Add(file);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveItem(-1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moveItem(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            string path = "C:\\";
            if (Directory.Exists("C:\\Program Files\\MKVToolNix"))
            {
                path = "C:\\Program Files\\MKVToolNix";
            }
            dialog.InitialDirectory = path;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Regex rgx = new Regex("mkvmerge\\.exe");
                Match match;
                string[] files = Directory.GetFiles(dialog.FileName);
                foreach (string file in files)
                {
                    match = rgx.Match(file);
                    if (match.Success)
                    {
                        isPathed = true;
                        toolNix = dialog.FileName;
                        mkvTbox.Text = dialog.FileName;
                        verifyRequirements();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = list.SelectedItems.Count - 1; i >= 0; i--)
            {
                object selected = list.Items[list.SelectedIndices[i]];
                list.Items.Remove(selected);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                readTracks();
            });
            thread.Start();
        }

        private void extractBtn_Click(object sender, EventArgs e)
        {
            Extract form = new Extract();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                thread = new Thread(() =>
                {
                    extractTrack(form.trackID, form.extension);
                });
                thread.Start();
            }
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            Merge form = new Merge();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                thread = new Thread(() =>
                {
                    mergeTrack(form.trackID, form.extension, form.isDefault, form.isOverride, form.countPrefix, form.titleFile, form.type, form.name, form.trackName, form.language);
                });
                thread.Start();
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifyRequirements();
        }

        private void list_KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                list.BeginUpdate();
                for (int i = 0; i < list.Items.Count; i++)
                    list.SetSelected(i, true);
                list.EndUpdate();
            }
        }

        private void addAttachBtn_Click(object sender, EventArgs e)
        {
            Attach form = new Attach();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                thread = new Thread(() =>
                {
                    addAttach(form.selectedFiles);
                });
                thread.Start();
            }
        }

        private void renameTitleBtn_Click(object sender, EventArgs e)
        {
            Titles form = new Titles();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                thread = new Thread(() =>
                {
                    rename(form.name, form.prefix, form.titleFile, form.isTitle, form.isFile);
                });
                thread.Start();
            }
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            Name form = new Name();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                thread = new Thread(() =>
                {
                    changeName(form.trackNo, form.name);
                });
                thread.Start();
            }
        }

        private void changeDefaultBtn_Click(object sender, EventArgs e)
        {
            Default form = new Default();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                thread = new Thread(() =>
                {
                    changeDefault(form.promotes, form.demotes);
                });
                thread.Start();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            displayTbox.Text = String.Empty;
        }
    }
}