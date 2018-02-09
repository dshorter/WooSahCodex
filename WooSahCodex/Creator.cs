using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using WooSahCodex.Color;
using WooSahCodex.Etching;
using WooSahCodex.Finish;
using WooSahCodex.Material;
using WooSahCodex.Model;

namespace WooSahCodex
{
    public class Creator
    {
        public int Count { get; set; }
        public List<WooSah> wooSahList;

        private HashSet<string> modelHashSet;
        private HashSet<string> materialHashSet;
        private HashSet<string> finishHashSet;
        private HashSet<string> colorHashSet;
        private HashSet<string> etchingHashSet;

        public Creator()
        {

            try
            {
                if (Codex.CheckSchema() == false)
                    return;
                
                Create();
                
                var wooSahStats = new WooSahStats(wooSahList);
                Console.WriteLine($"Total theoretical WooSah count (no rules ) = { wooSahList.Count * 2  }  ");
                Console.Write($"Total actual WooSah count (rules applied ) = {wooSahStats.PassCount() * 2 }" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " ==== " + ex.InnerException.Message);
            }


        }

        private void Create()
        {
            Count = 0;
            WooSah wooSah;
            wooSahList = new List<WooSah>();

            // Load the types from WooSah.json                
            try
            {
                modelHashSet = Utils.FillHashset("WooSahCodex.Model");
                materialHashSet = Utils.FillHashset("WooSahCodex.Material");
                finishHashSet = Utils.FillHashset("WooSahCodex.Finish");
                colorHashSet = Utils.FillHashset("WooSahCodex.Color");
                etchingHashSet = Utils.FillHashset("WooSahCodex.Etching");

                var colorTypes = Utils.GetTypesForNamespace("WooSahCodex.Color");
                var materialTypes = Utils.GetTypesForNamespace("WooSahCodex.Material");
                var finishTypes = Utils.GetTypesForNamespace("WooSahCodex.Finish");
                var modelTypes = Utils.GetTypesForNamespace("WooSahCodex.Model");
                var etchingTypes = Utils.GetTypesForNamespace("WooSahCodex.Etching");

                foreach (string modelName in modelHashSet)
                {
                    var modelType = modelTypes.Single(m => m.Name == modelName);
                    var oModel = Activator.CreateInstance(modelType) as IModel;

                    foreach (string materialName in materialHashSet)
                    {
                        var materialType = materialTypes.Single(m => m.Name == materialName);
                        var oMaterial = Activator.CreateInstance(materialType) as IMaterial;

                        foreach (string finishName in finishHashSet)
                        {
                            var finishType = finishTypes.Single(f => f.Name == finishName);
                            var oFinish = Activator.CreateInstance(finishType) as IFinish;

                            foreach (string colorName in colorHashSet)
                            {
                                var colorType = colorTypes.Single(c => c.Name == colorName);
                                var oColor = Activator.CreateInstance(colorType) as IColor;

                                foreach (string etchingName in etchingHashSet)
                                {
                                    var etchingType = etchingTypes.Single(e => e.Name == etchingName);
                                    var oEtching = Activator.CreateInstance(etchingType) as IEtching;

                                    wooSah = new WooSah();

                                    ((WooSahProperty)oModel).SetWooSah(wooSah);
                                    ((WooSahProperty)oMaterial).SetWooSah(wooSah);
                                    ((WooSahProperty)oEtching).SetWooSah(wooSah);
                                    ((WooSahProperty)oColor).SetWooSah(wooSah);
                                    ((WooSahProperty)oFinish).SetWooSah(wooSah);

                                    wooSah.Model = oModel;
                                    wooSah.Material = oMaterial;
                                    wooSah.Finish = oFinish;
                                    wooSah.Etching = oEtching;
                                    wooSah.Color = oColor;

                                    wooSah.CreatePoco();
                                    wooSah.ValidateMe();

                                    wooSahList.Add(wooSah);
                                }

                            }

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " ==== " + ex.InnerException.Message);
            }

        }
    }
}
