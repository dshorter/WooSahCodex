using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace WooSahCodex
{
    public enum PropertyTypes
    {
        Model,
        Material,
        Finish,
        Color,
        Etching
    }

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
            string jsonPath = @"..\WooSahCodex\WooSah.json";
            var jObject = Utils.GetJOhject(jsonPath);

            List<JProperty> jProps = jObject.Properties().ToList();

            var arrTypes = Enum.GetNames(typeof(PropertyTypes));
            var arrEnums = Enum.GetValues(typeof(PropertyTypes));

            foreach (PropertyTypes arrEnum in arrEnums)
            {
                if (checkProps(jProps, arrEnum) == false)
                {
                    //     return false;
                }
            }

            return true;

        }

        private static bool checkProps(List<JProperty> jProps, PropertyTypes propertyType)
        {

            HashSet<string> hsCodex = Utils.FillHashset("WooSahCodex." + propertyType.ToString());
            HashSet<string> hsJson = new HashSet<string>();
            JProperty jProp = jProps.Single(x => x.Name == propertyType.ToString());

            jProp.Children()
                .Values()
                .Where
                (child => child.ToString() != "None")
                .ToList()
                .ForEach(
                    item => hsJson.Add(item.ToString()));

            var jsonExcepts = hsJson.Except(hsCodex);
            var codexExcepts = hsCodex.Except(hsJson);

            if (jsonExcepts.Any() || codexExcepts.Any())
            {

                Debug.WriteLine("Not present for codex ");
                jsonExcepts.ToList().ForEach(j => Debug.WriteLine(j));
                Debug.WriteLine("Not present for Json ");
                codexExcepts.ToList().ForEach(j => Debug.WriteLine(j));

               //    return false;
            }

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




