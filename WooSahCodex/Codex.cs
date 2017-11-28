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

        public static bool CheckSchema()
        {
            if (WooSahCodexTypesUnique() == false)
                return false;

            if (JsonTypesUnique() == false)
                return false;

            if (JsonTypesMatchCodeTypes() == false)
                return false;


            // 1. Check that all json values are unique      
            // 2. Check that there are classes for all properties in json 
            //    and reverse    

            string path = @"..\WooSahCodex\WooSah.json";

            var jObject = Utils.GetJOhject(path);
            HashSet<Type> codeTypescheckSet = new HashSet<Type>();
            foreach (JProperty jProperty in jObject.Properties())
            {

                string wNamespace = "WooSahCodex." + jProperty.Name;
                HashSet<Type> typesForNamespace = Utils.GetTypesForNamespace(wNamespace);
                codeTypescheckSet.UnionWith(typesForNamespace);

            }

            var simpleCodeList = codeTypescheckSet.Select(type => type.Name).ToList();

            var unique = new HashSet<string>(simpleCodeList);

            return true;

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
                    (x => {
                            jsonTypeCheckSet.Add(x.ToString());
                            jsonTypeCheckList.Add(x.ToString());
                          }
                    );                
            }

            return jsonTypeCheckSet.Count == jsonTypeCheckList.Count;
        }

        private static bool JsonTypesMatchCodeTypes()
        {
            throw new NotImplementedException();
        }

        public static List<HashSet<string>> GetExcepts(WooSahCategory wooSahCategory, Type wooSahProp)
        {

            string path = @"..\WooSahCodex\" + wooSahCategory + @"\" + wooSahProp.Name + ".json";

            var jObject = Utils.GetJOhject(path);

            return new List<HashSet<string>>();

        }


    }
}




