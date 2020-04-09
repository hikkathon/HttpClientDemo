using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace wfHttpClientDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ObservableCollection<EntryModel> _entries = new ObservableCollection<EntryModel>();

        public ObservableCollection<EntryModel> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }

        private static async Task GetContent(HttpClient httpClient, string url, string nodes, string singleNode)
        {
            MainForm mf = new MainForm();
            ViewHtmlForm vhtmlf = new ViewHtmlForm();
            ViewDataGridForm vdgf = new ViewDataGridForm();


            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Высвобождает ресурсы если соеденение не удалось
                var html = await response.Content.ReadAsStringAsync();

                vhtmlf.TextBoxViewHtml = html;

                vhtmlf.Show();
                vdgf.Show();

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                int count = 0;
                try
                {
                    var posts = htmlDoc.DocumentNode.SelectNodes(nodes);

                    foreach (var post in posts)
                    {
                        count++;
                        var poster = post.SelectSingleNode(singleNode)?.GetAttributeValue("src", "").Trim();

                        mf._entries.Add(new EntryModel { Number = count, PosterUrl = "https://yummyanime.club" + poster });

                        vdgf.dataGridViewURL.Rows.Add(count, "https://yummyanime.club" + poster);
                    }
                }
                catch (NullReferenceException exc)
                {
                    MessageBox.Show($"{exc.Message}", "Exception Caught",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                }
                catch (System.Xml.XPath.XPathException exc)
                {
                    MessageBox.Show($"{exc.Message}", "Exception Caught",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (HttpRequestException exc)
            {
                MessageBox.Show($"{exc.Message}", "Exception Caught",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                //System.Threading.Thread.Sleep(10000);
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "https://yummyanime.club/users/id13222");

                await GetContent(httpClient, textBoxSiteUrl.Text, textBoxNodes.Text, textBoxSingleNode.Text);
            }            
        }

        private void buttonfillsa_Click(object sender, EventArgs e)
        {
            textBoxSiteUrl.Text = "https://yummyanime.club/catalog";
        }

        private void buttonfilln_Click(object sender, EventArgs e)
        {            
            textBoxNodes.Text = ".//div[@class='content-page categories-page']/div[@class='anime-column']";
        }

        private void buttonfillsn_Click(object sender, EventArgs e)
        {
            textBoxSingleNode.Text = "./a[@class='image-block']/img";
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {

        }
    }
}
