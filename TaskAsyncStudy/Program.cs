using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TaskAsyncStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, Task> WebRequestSize =
                async (url) =>
                {
                    WebRequest webRequest = WebRequest.Create(url);
                    WebResponse response = await webRequest.GetResponseAsync();

                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string str = await reader.ReadToEndAsync();
                        Console.WriteLine(str.Length);
                    }

                };

            Task task = WebRequestSize("https://www.google.com");

            while (!task.Wait(100))
            {
                Console.Write(".");
            }
        }
    }
}
