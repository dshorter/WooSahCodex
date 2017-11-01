using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WooSahCodex.Codex;

namespace WooSahCodex
{
    public static class Utils
    {
        public static List<Type> GetTypesForNamespace(string thisNamespace)
        {
            var ass = typeof(WooSah).GetTypeInfo().Assembly;
            var types = from t in ass.GetTypes()
                        where t.Namespace == thisNamespace
                        select t;

            return types.ToList();
        }

        public static HashSet<string> FillHashset(HashSet<string> hashSet)
        {

        }
    }
}

