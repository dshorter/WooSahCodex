using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using WooSahCodex.Codex.Properties;
using WooSahCodex;

namespace WooSahCodex.Codex
{
    public class Creator
    {
        public int Count { get; set; }


        private HashSet<string> modelHashSet;
        private HashSet<string> materialHashSet;
        private HashSet<string> finishHashSet;
        private HashSet<string> colorHashSet;
        private HashSet<string> etchingHashSet;

        public Creator()
        {
            Count = 0;
            WooSah wooSah;
            List<WooSah> wooSahList = new List<WooSah>();

            // Load the types from WooSah.json                
            try
            {
                Utils.FillHashset(modelHashSet);
                Utils.FillHashset(materialHashSet);
                Utils.FillHashset(finishHashSet);
                Utils.FillHashset(colorHashSet);
                Utils.FillHashset(etchingHashSet);

                foreach (string modelName in modelHashSet)
                {
                    foreach (string materialName in materialHashSet)
                    {
                        foreach (string finishName in finishHashSet)
                        {
                            foreach (string colorName in colorHashSet)
                            {
                                foreach (string etchingName in etchingHashSet)
                                {

                                    wooSah = new WooSah()
                                    {

                                    };


                                }

                            }

                        }

                    }

                }
            }
            catch (Exception ex)
            {


            }


            foreach (WooSah wooSahItem in wooSahList)
            {
                Console.WriteLine($"Model -- {wooSahItem.Model}  ");
                Console.WriteLine($"Material -- {wooSahItem.Material}  ");
                Console.WriteLine($"Fihish -- {wooSahItem.Finish}  ");
                Console.WriteLine($"isValid -- {wooSahItem.isValid}  ");
            }

        }
    }
}
