using System;
using System.Threading;
using System.Windows.Forms;

namespace Spider
{
    public partial class Form1 : Form
    {
        Crawler crawler = new Crawler();

        public Form1()
        {
            InitializeComponent();
            crawler.PageDownloaded += Crawler_PageDownloaded;
            txtURL.DataBindings.Add("Text", crawler, "StartUrl");
        }

        private void btnStartSpider_Click(object sender, EventArgs e)
        {
            this.listInfo.Items.Clear();
            new Thread(crawler.Start).Start();
        }

        private void Crawler_PageDownloaded(string url)
        {
            if (this.listInfo.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }

        private void AddUrl(string url)
        {
            listInfo.Items.Add(url);
        }
    }
}