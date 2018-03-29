using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WooSahCodex;
using WooSahCodex.Data;


namespace WooSahCodexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Go();
        }

        private static async Task Go()
        {
            //  Console.WriteLine("WooSah!");

            try
            {
                var path = Environment.CurrentDirectory + "\\The WooSah Codex.txt";
                string hello;
                FileStream fileStream = new FileStream(path, FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    hello = reader.ReadToEnd();
                }
                Console.WriteLine(hello);
                Console.WriteLine("Calculating....");

                Creator creator = new Creator();

                Console.WriteLine("WooSahs created.  Hit enter to export to CouchDB.... " + Environment.NewLine);
                Console.ReadLine();
                Loader loader = new Loader(creator.wooSahList);
                await loader.Load(creator.wooSahList);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " ==== " + ex.InnerException.Message);
            }

            var results = Codex.GetExcepts(WooSahCategory.Model, typeof(WooSahCodex.Model.Chakra));

            Console.ReadLine();

        }
    }
}