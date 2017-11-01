using System;
using System.Collections.Generic;
using System.Linq;
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

                var colorTypes = Utils.GetTypesForNamespace("WooSahCodex.Color");
                var materialTypes = Utils.GetTypesForNamespace("WooSahCodex.Material");
                var finishTypes = Utils.GetTypesForNamespace("WooSahCodex.Finish");
                var modelTypes = Utils.GetTypesForNamespace("WooSahCodex.Model");
                var etchingTypes = Utils.GetTypesForNamespace("WooSahCodex.Etching");


                foreach (string modelName in modelHashSet)
                {
                    var modelType = modelTypes.Single(m => m.Name == modelName);
                    var oModel = Activator.CreateInstance(modelType);

                    foreach (string materialName in materialHashSet)
                    {
                        var materialType = materialTypes.Single(m => m.Name == materialName);
                        var oMaterial = Activator.CreateInstance(modelType);

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
