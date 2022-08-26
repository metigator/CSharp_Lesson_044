using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Metigator44.L02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding chinese = Encoding.GetEncoding("GB18030");
            Console.WriteLine("大");

            Task.Run(() => GetDataUTF8Format());
            Console.ReadKey();
        } 

        static async Task GetDataAssciFormat()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            var filePath = $"{path}\\asciiNewsContent.txt";

            using (var client = new HttpClient())
            {
                Uri uri = new Uri("https://aljazeera.net/search/feed");
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    var byteArray = await response.Content.ReadAsByteArrayAsync();
                    string result = Encoding.ASCII.GetString(byteArray);
                    File.WriteAllText(filePath, result);
                }
            }
        }

        static async Task GetDataUTF8Format()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            var filePath = $"{path}\\utf8NewsContent.txt";

            using (var client = new HttpClient())
            {
                Uri uri = new Uri("https://aljazeera.net/search/feed");
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    var byteArray = await response.Content.ReadAsByteArrayAsync();
                    string result = Encoding.UTF8.GetString(byteArray);
                    File.WriteAllText(filePath, result);
                }
            }
        }
    }
}
