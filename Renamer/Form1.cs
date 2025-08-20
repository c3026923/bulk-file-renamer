using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime;
using System.Security.Principal;

namespace Renamer
{
    public partial class Form1 : Form
    {
        char[] invalidChars = { '*', '?' };

        public Form1()
        {
            Application.EnableVisualStyles();

            InitializeComponent();
            picBoxInfo.Image = Properties.Resources.Info;
            picBoxAvatar.ImageLocation = "https://avatars.githubusercontent.com/u/147670061?v=4";                
            custProgBar.Style = ProgressBarStyle.Blocks;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                txtFolderLocation.Text = dialog.SelectedPath;
            else
                txtFolderLocation.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var path = txtFolderLocation.Text.Trim();
            var existingText = txtToReplace.Text.Trim();
            var replacementText = txtReplacement.Text.Trim();
            var totalCount = 0;
            var currentCount = 0;

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Folder does not exist!");
                return;
            }
            else if(string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Path was empty; please navigate to correct path.");
                return;
            }
            else if(path.StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.Windows), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot alter Windows directory content(s)");
                return;
            }

            if (string.IsNullOrWhiteSpace(existingText))
            {
                MessageBox.Show("Please enter text in the 'Text to replace' box.");
                return;
            }
            else if (existingText.IndexOfAny(invalidChars) >= 0)
            {
                MessageBox.Show("You cannot search for * or ?");
                return;
            }

            if (string.IsNullOrWhiteSpace(replacementText))
            {
                MessageBox.Show("Please enter text in the 'New text' box.");
                return;
            }
            else if(replacementText.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("New text cannot contain invalid characters.");
                return;
            }
            else if(replacementText.Length + 5 > 255)
            {
                MessageBox.Show("New text cannot be this long.");
                return;
            }

            try
            {
                var attemptFileFetch = Directory.GetFiles(path);
                totalCount = attemptFileFetch.Length;

                foreach (string file in attemptFileFetch)
                {
                    string thisFileName = Path.GetFileName(file);
                    var directoryName = Path.GetDirectoryName(file);
                    string thisDirectory = string.Empty;

                    if (directoryName != null)
                        thisDirectory = directoryName;

                    if (thisFileName.Contains(existingText))
                    {
                        lblProgressInfo.Visible = true;

                        string newFileName = thisFileName.Replace(existingText, replacementText);
                        string newPath = Path.Combine(thisDirectory, newFileName);

                        if (!File.Exists(newPath))
                            File.Move(file, newPath);

                        currentCount++;
                        custProgBar.Value = (currentCount / totalCount) * 100;
                        lblProgressInfo.Text = $"Renaming Files: {currentCount} / {totalCount}";
                    }
                }
                if (currentCount == 0)
                    MessageBox.Show($"Could not locate any files with text '{existingText}'");
                else if (currentCount == totalCount && totalCount >= 1)
                {
                    lblProgressInfo.Visible = false;
                    lblSummary.Visible = true;
                    lblSummary.Text = $"Renamed {totalCount} files from '{existingText}' to '{replacementText}'";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Length != 0)
                    MessageBox.Show(ex.Message);
            }
        }

        private void linkLblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("cmd", "/c start https://github.com/c3026923");
        }

        private void linkLblInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("cmd", "/c start https://github.com/c3026923/bulk-file-renamer/");
        }
    }
}
