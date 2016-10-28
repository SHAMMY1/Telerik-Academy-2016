using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TelerikVideos
{
    class Program
    {
        static void Main()
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            var web = new WebClient();

            byte[] buffer = web.DownloadData("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw");

            string videos = System.Text.UTF8Encoding.UTF8.GetString(buffer);

            var videosXML = XDocument.Load(new StringReader(videos));

            string videosJSONString = JsonConvert.SerializeXNode(videosXML,Formatting.Indented);

            var videosJSONObject = JObject.Parse(videosJSONString);

            var videosTitles = videosJSONObject.SelectToken("feed").Select(f => f["entry"]);
            videosTitles = videosTitles.Select(x => x["title"]);
            Console.WriteLine(string.Join(" ", videosTitles));
        }
    }
}
