using System;
using System.Threading.Tasks;
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
            Console.WriteLine("WooSah!");

            try
            {
                Creator creator = new Creator();
                Console.WriteLine("WooSahs created.  Hit enter to load to Couch " + Environment.NewLine);
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