using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WooSahCodex
{
    public static class Codex
    {

        public static bool CheckSchema()
        {


            return false;

        }

        public static List<HashSet<string>> GetExcepts(WooSahCategory wooSahCategory, Type wooSahProp)
        {

            string path = @"~\" + wooSahCategory + @"\" + wooSahProp.ToString() + ".json";

            FileStream fileStream = new FileStream(path, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {


                string jsonText = reader.ReadToEnd();

            }

            
            return new List<HashSet<string>>();

        }

    }
}




