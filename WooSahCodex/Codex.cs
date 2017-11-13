using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WooSahCodex
{
    public static class Codex
    {

        public static bool CheckSchema()
        {

            // 1. Check that all json values are unique      
            // 2. Check that there are classes for all properties in json 
            //    and reverse    

            return true;

        }

        public static List<HashSet<string>> GetExcepts(WooSahCategory wooSahCategory, Type wooSahProp)
        {

            string path =        @"..\WooSahCodex\" + wooSahCategory + @"\" + wooSahProp.Name + ".json";

            FileStream fileStream = new FileStream(path, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {


                string jsonText = reader.ReadToEnd();
                JObject jObject = JObject.Parse(jsonText);



            }


            return new List<HashSet<string>>();

        }

    }
}




