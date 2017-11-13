using System;
using WooSahCodex;



namespace WooSahCodexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WooSah!");

            Creator creator = new Creator();
            Codex.GetExcepts(WooSahCategory.Model, typeof(WooSahCodex.Model.Chakra));

            Console.ReadLine();

        }
    }
}