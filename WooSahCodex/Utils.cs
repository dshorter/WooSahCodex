using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WooSahCodex.Codex;

namespace WooSahCodex
{
    public static class Utils
    {
        public static HashSet<Type> GetTypesForNamespace(string thisNamespace)
        {
            try
            {
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
    }
}

