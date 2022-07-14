using System.Net.Http.Headers;

namespace telegraph_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Zone Resource
        private static readonly HttpClient client = new HttpClient();
        string[] filePaths;
        List<string> liv = new List<string>();
        string fileSrc;

        private void uploadfilesBtn_click(object sender, EventArgs e)
        {
            listView1.Clear();

            Stream myStream;
            theDialog.Title = "Загрузка файлов в телеграф";
            theDialog.Filter = "JPG Files (*.jpg)| *.jpg";
            theDialog.InitialDirectory = @"C:\Users\ratni\Desktop";
            theDialog.Multiselect = true;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (var item in theDialog.FileNames)
                            {
                                liv.Add(item);
                            }
                            filePaths = liv.ToArray();

                            using (var multipartFormContent = new MultipartFormDataContent())
                            {
                                foreach (var filePath in filePaths)
                                {
                                    var fileName = Path.GetFileName(filePath);

                                    //Load the file and set the file's Content-Type header
                                    var fileStreamContent = new StreamContent(File.OpenRead(filePath));
                                    fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");

                                    //Add the file
                                    multipartFormContent.Add(fileStreamContent, name: "files", fileName: fileName);
                                    //Send it
                                    var response = client.PostAsync("https://telegra.ph/upload/", multipartFormContent);
                                    var resk = response.Result.Content.ReadAsStringAsync().Result.ToString();

                                    char[] ipt = { '{', '}', '[', ']', '\\', ':', '"' };
                                    string imagePathTelegraph = resk.Trim(ipt);
                                    imagePathTelegraph = imagePathTelegraph.Remove(0, 14);
                                    fileSrc = "https://telegra.ph/file/" + imagePathTelegraph;
                                    listView1.Items.Add(fileSrc);
                                    liv.Add(fileSrc);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void createChapterBtn_click(object sender, EventArgs e)
        {
            var content = new StringContent("");
            var response = client.PostAsync("", content);
        }
    }
}