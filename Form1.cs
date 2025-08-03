using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Management;
using System.IO;
using System.Windows.Forms;

namespace MiniDownloadManager
{
    public partial class Form1 : Form
    {
        private List<File> AvailableFiles;
        private int SelectedFileIndex;
        private int NumOfFiles;
        public Form1()
        {
            InitializeComponent();
        }



        private async void FetchData(string RemoteUrl)
        {
            PBspinner.Visible = true;
            HttpClient client = new HttpClient();

            try
            {
                string jsonData = await client.GetStringAsync(RemoteUrl);
                AvailableFiles = JsonSerializer.Deserialize<List<File>>(jsonData);
                foreach (var file in AvailableFiles)
                {
                    // Download image and file
                    try
                    {
                        var imageStream = await client.GetStreamAsync(file.ImageURL);
                        file.ImageContent = Image.FromStream(imageStream);
                        file.FileContent = await client.GetByteArrayAsync(file.FileURL);
                        file.IsDownloaded = false;
                    }

                    // Remove object if there is no image or file
                    catch
                    {
                        File FileToRemove = AvailableFiles.FirstOrDefault(a => a.Title == file.Title);
                        AvailableFiles.Remove(FileToRemove);
                    }
                }

                OrderByScore();
                NumOfFiles = AvailableFiles.Count();
                SelectedFileIndex = 0;
                ShowSelctedFile();
                PBspinner.Visible = false;
                Lloading.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot fetch files data");
                Application.Exit();
            }
        }

        private void OrderByScore()
        {
            AvailableFiles = new List<File>(AvailableFiles.OrderByDescending(s => s.Score).ToList());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string RemoteUrl = "https://4qgz7zu7l5um367pzultcpbhmm0thhhg.lambda-url.us-west-2.on.aws/";
            FetchData(RemoteUrl);
        }

        private void ShowSelctedFile()
        {
            TfileName.Text = AvailableFiles[SelectedFileIndex].Title;
            Lscore.Text = "File Score: " + AvailableFiles[SelectedFileIndex].Score;
            PBpicture.Image = AvailableFiles[SelectedFileIndex].ImageContent;
        }

        private void Bdownload_Click(object sender, EventArgs e)
        {
            if (AvailableFiles[SelectedFileIndex].FileContent == null || AvailableFiles[SelectedFileIndex].FileContent.Length == 0)
            {
                MessageBox.Show("File content is empty or not loaded.");
                return;
            }

            if (AvailableFiles[SelectedFileIndex].IsDownloaded)
            {
                MessageBox.Show("File has already been downloaded");
                return;
            }    
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = AvailableFiles[SelectedFileIndex].Title + System.IO.Path.GetExtension(AvailableFiles[SelectedFileIndex].FileURL);
                saveFileDialog.Filter = "All files (*.*)|*.*";
                string downloadsPath = Path.Combine(
                                        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                                        "Downloads"
);
                saveFileDialog.InitialDirectory = downloadsPath;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, AvailableFiles[SelectedFileIndex].FileContent);
                        AvailableFiles[SelectedFileIndex].IsDownloaded = true;
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });

                        string folderPath = System.IO.Path.GetDirectoryName(saveFileDialog.FileName);
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = folderPath,
                            UseShellExecute = true
                        });



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save file: " + ex.Message);
                    }
                }
            }
        }

        private void BnextFile_Click(object sender, EventArgs e)
        {
            if (SelectedFileIndex == NumOfFiles - 1)
            {
                SelectedFileIndex = 0;
            }
            else
            {
                SelectedFileIndex += 1;

            }

            ShowSelctedFile();
        }

    }

    public class File
    {
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string FileURL { get; set; }
        public int Score { get; set; }
        public int? ram { get; set; }
        public double? os { get; set; }
        public int? disk { get; set; }
        public Image ImageContent { get; set; }
        public byte[] FileContent { get; set; }
        public bool IsDownloaded { get; set; }
    }
}
