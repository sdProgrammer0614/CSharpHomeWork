using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Spider
{
    class Crawler
    {
        public event Action<string> PageDownloaded;
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string startUrl = "";
        private string startDomainName = "";            // 起始域名
        private string currentUrl = null;               // 当前URL
        public string StartUrl
        {
            get => startUrl;
            set
            {
                startUrl = value;
                urls = new Hashtable
                {
                    { value, false }
                };

                string pattern = @"[ ]*(https|http)?://(www.)?(\w+(\.)?)+";
                startDomainName = new Regex(pattern)
                    .Match(value).Value.Trim();
            }
        }

        public void Start()
        {
            while (true)
            {
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])
                        continue;
                    currentUrl = url;
                }

                if (currentUrl == null || count > 10)
                    break;
                string html = DownLoad(currentUrl);         // 下载
                urls[currentUrl] = true;
                count++;
                Parse(html);                                // 解析，并加入新的链接
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient
                {
                    Encoding = Encoding.UTF8
                };
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                PageDownloaded(url);
                return html;
            }
            catch (Exception ex)
            {
                PageDownloaded(url + "      Error: " + ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');

                if (Regex.IsMatch(strRef, @".(\.html|\.htm)$") ||
                    strRef.Contains(".html?") || strRef.Contains(".htm?"))
                {
                    strRef = Convert(strRef);

                    if (strRef.Contains(startDomainName) && urls[strRef] == null)
                        urls[strRef] = false;
                }
                else
                    continue;
            }
        }

        private string Convert(string relativePath)
        {
            string absolutePath = "";

            if (relativePath.Contains("http"))
                absolutePath = relativePath;
            else
            {
                switch(relativePath[0])
                {
                    case '/':
                        absolutePath = startDomainName + relativePath.Substring(1);
                        break;
                    case '.':
                        string temp = currentUrl.Substring(0, currentUrl.Length - 1);
                        temp = temp.Substring(0, temp.LastIndexOf('/'));
                        absolutePath = temp + relativePath.Substring(2);
                        break;
                    default:
                        absolutePath = currentUrl + relativePath;
                        break;
                }
            }

            return absolutePath;
        }
    }
}
