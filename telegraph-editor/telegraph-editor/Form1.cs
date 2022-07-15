using Newtonsoft.Json;
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
        string contentPage;
        List<string> imgItems = new List<string>();



        private void uploadfilesBtn_click(object sender, EventArgs e)
        {
            listView1.Clear();

            Stream myStream;
            theDialog.Title = "Загрузка файлов в телеграф";
            theDialog.Filter = "JPG Files (*.jpg)| *.jpeg";
            theDialog.InitialDirectory = @"C:\Users\ratni\Desktop";
            theDialog.Multiselect = true;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        foreach (var item in theDialog.FileNames)
                        {
                            liv.Add(item);
                        }
                        filePaths = liv.ToArray();

                        foreach (var filePath in filePaths)
                        {
                            var multipartFormContent = new MultipartFormDataContent();
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
                            imgItems.Add(fileSrc);

                            fileStreamContent = null;
                            multipartFormContent = null;
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

            string authorUrl = textBox4.Text;
            string imageContent = "";

            foreach (var item in imgItems)
            {
                imageContent = imageContent + textBox5.Text.Replace("tech", item.ToString()) + ',';
            }
            int x1 = imageContent.Length - 1;
            imageContent = imageContent.Remove(x1);
            contentPage = "[" + authorUrl + "," + imageContent + "]";


            string url = "https://api.telegra.ph/createPage";
            var parameters = new Dictionary<string, string>
            {
                { "access_token", "d3b25feccb89e508a9114afb82aa421fe2a9712b963b387cc5ad71e58722" },
                { "title", $"{textBox1.Text}" },
                { "author_name", $"{textBox2.Text}" },
                { "content", $"{contentPage}" }
            };
            var encodedContent = new FormUrlEncodedContent(parameters);

            var response = client.PostAsync(url, encodedContent);
            var result = response.Result.Content.ReadAsStringAsync().Result;

            dynamic jsonResponse = JsonConvert.DeserializeObject(result);
            string urlString = jsonResponse.result.url;

            textBox3.Text = urlString;
        }
        //{"ok":true,"result":{"path":"MyChapter-07-14","url":"https:\/\/telegra.ph\/MyChapter-07-14","title":"MyChapter","description":"","author_name":"Ontary","views":0,"can_edit":true}}
    }
}