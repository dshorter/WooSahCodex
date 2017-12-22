using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WooSahCodex
{
    public static class Codex
    {

        public static bool CheckSchema()
        {

            // Check that all WooSah types are unique      
            if (WooSahCodexTypesUnique() == false)
                return false;

            // Check that all json values are unique        
            if (JsonTypesUnique() == false)
                return false;

            // Check that there are classes for all properties in json and vice versa    
            if (JsonTypesMatchCodeTypes() == false)
                return false;

            return true;

        }

        private static bool JsonTypesMatchCodeTypes()
        {


            string path = @"..\WooSahCodex\WooSah.json";
            var thisJObject = Utils.GetJOhject(path);

            var codex_modelHashSet = Utils.FillHashset("WooSahCodex.Model");
            var codex_materialHashSet = Utils.FillHashset("WooSahCodex.Material");
            var codex_finishHashSet = Utils.FillHashset("WooSahCodex.Finish");
            var codex_colorHashSet = Utils.FillHashset("WooSahCodex.Color");
            var codex_etchingHashSet = Utils.FillHashset("WooSahCodex.Etching");

            var jsonModelHashSet = thisJObject.Properties().Where(x => x.Name == "Model").ToList();

            return true;

        }

        public static bool WooSahCodexTypesUnique()
        {
            HashSet<Type> codeTypescheckSet = new HashSet<Type>();

            // Collect all types      
            codeTypescheckSet.UnionWith(Utils.GetTypesForNamespace("WooSahCodex.Model"));
            codeTypescheckSet.UnionWith(Utils.GetTypesForNamespace("WooSahCodex.Color"));
            codeTypescheckSet.UnionWith(Utils.GetTypesForNamespace("WooSahCodex.Etching"));
            codeTypescheckSet.UnionWith(Utils.GetTypesForNamespace("WooSahCodex.Finish"));
            codeTypescheckSet.UnionWith(Utils.GetTypesForNamespace("WooSahCodex.Material"));

            // Strip out type names to a list       
            var simpleCodeList = codeTypescheckSet.Select(type => type.Name).ToList();

            // Use the list to create a HashSet.  If the HashSet strips 
            // out duplicates the Counts will he different      
            var unique = new HashSet<string>(simpleCodeList);

            return simpleCodeList.Count == unique.Count;

        }

        private static bool JsonTypesUnique()
        {

            string path = @"..\WooSahCodex\WooSah.json";
            var jObject = Utils.GetJOhject(path);
            HashSet<string> jsonTypeCheckSet = new HashSet<string>();
            List<string> jsonTypeCheckList = new List<string>();

            foreach (JProperty jProperty in jObject.Properties())
            {
                var jArray = JArray.Parse(jProperty.Value.ToString());

                jArray.Where
                    (d => d.ToString() != "None").ToList().ForEach
                    (x =>
                    {
                        jsonTypeCheckSet.Add(x.ToString());
                        jsonTypeCheckList.Add(x.ToString());
                    }
                    );
            }

            return jsonTypeCheckSet.Count == jsonTypeCheckList.Count;
        }

        public static List<HashSet<string>> GetExcepts(WooSahCategory wooSahCategory, Type wooSahProp)
        {

            string path = @"..\WooSahCodex\" + wooSahCategory + @"\" + wooSahProp.Name + ".json";

            var jObject = Utils.GetJOhject(path);

            return new List<HashSet<string>>();

        }


    }
}




