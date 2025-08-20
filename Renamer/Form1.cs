using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime;
using System.Security.Principal;

namespace Renamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picBoxInfo.Image = Properties.Resources.Info;
            picBoxAvatar.ImageLocation = "https://avatars.githubusercontent.com/u/147670061?v=4";
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

            if (path.Length <= 0)
            {
                MessageBox.Show("Path was empty; please navigate to correct path.");
                return;
            }

            if (existingText.Length <= 0)
            {
                MessageBox.Show("Please enter text in the 'Text to replace' box.");
                return;
            }

            if (replacementText.Length <= 0)
            {
                MessageBox.Show("Please enter text in the 'New text' box.");
                return;
            }

            try
            {
                var attemptFileFetch = Directory.GetFiles(path);
                totalCount = attemptFileFetch.Length;

                foreach (string file in attemptFileFetch)
                {
                    string thisFileName = Path.GetFileName(file);
                    string thisDirectory = Path.GetDirectoryName(file);

                    if (thisFileName.Contains(existingText))
                    {
                        string newFileName = thisFileName.Replace(existingText, replacementText);
                        string newPath = Path.Combine(thisDirectory, newFileName);

                        if (!File.Exists(newPath))
                            File.Move(file, newPath);

                        currentCount++;

                        custProgBar.Value = (currentCount / totalCount) * 100;

                        lblProgressInfo.Text = $"Renaming Files: {currentCount} / {totalCount}";
                        lblProgressInfo.Visible = true;
                    }
                }

                if (currentCount == totalCount)
                {
                    lblProgressInfo.Visible= false;
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
    }
}
