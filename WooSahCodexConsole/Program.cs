using System;
using WooSahCodex;



namespace WooSahCodexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WooSah!");

            try
            {
                Creator creator = new Creator();
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