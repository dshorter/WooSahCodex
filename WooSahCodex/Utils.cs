using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;
using WooSahCodex;

namespace WooSahCodex
{
    public static class Utils
    {
        public static HashSet<Type> GetTypesForNamespace(string thisNamespace)
        {
            try
            {
                //var props = t.GetProperties().Where(
                //     prop => Attribute.IsDefined(prop, typeof(MyAttribute)));
                var ass = typeof(WooSah).GetTypeInfo().Assembly;
                var types = from t in ass.GetTypes()
                            where t.Namespace == thisNamespace &&
                            t.GetTypeInfo().IsInterface == false
                            select t;

                HashSet<Type> hashSet = new HashSet<Type>(types.ToList());

                return hashSet;

            }
            catch (Exception ex)
            {

                throw new Exception();
            }

        }

        public static HashSet<string> FillHashset(string thisNamespace)
        {

            try
            {
                var ass = typeof(WooSah).GetTypeInfo().Assembly;
                var types = from t in ass.GetTypes()
                            where t.Namespace == thisNamespace &&
                            t.GetTypeInfo().IsInterface == false
                            select t;

                var typeNames = from t in types.ToList()
                                select t.Name;

                HashSet<string> thisHashSet = new HashSet<string>(typeNames.ToList());

                return thisHashSet;

            }
            catch (Exception ex)
            {

                throw new Exception();
            }
        }

        public static JObject GetJOhject(string path)
        {
            JObject jObject;
            FileStream fileStream = new FileStream(path, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string jsonText = reader.ReadToEnd();
                jObject = JObject.Parse(jsonText);
            }
            return jObject;
        }
    }
}

