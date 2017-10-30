using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using WooSahCodex.Codex.Properties;

namespace WooSahCodex.Codex
{
    public class WooSah
    {
        public bool isValid { get; set; }
        public string Model { get; set; }
        public string Material { get; set; }
        public string Finish { get; set; }

        public bool Validate()
        {
            var tModelTypes = getTuple(typeof(Models), this.Model);
            var tMaterialTypes = getTuple(typeof(Materials), this.Material);
            var tFinishTypes = getTuple(typeof(Finishes), this.Finish);

            // For all types ih the WooSahCodex.Codex.Properties namespace     
            foreach (var codexType in Utils.GetWooSahTypes())
            {
                FieldInfo[] codexTypeFieldInfos = codexType.GetFields();
                var xx = Activator.CreateInstance(codexType);

                foreach (FieldInfo codexTypeFieldInfo in codexTypeFieldInfos)
                {
                    // Check all atts agaihst the fields of this ihstane of WooSah    
                    // check that no other props are set to vals from exclList     
                    foreach (var wooSahPropertyInfo in typeof(WooSahCodex.Codex.WooSah).GetProperties())



                    {
                        //if (wFieldInfo.Name == propertyInfo2.Name)
                        //{
                        var exceptTuple = getTuple(codexType, codexTypeFieldInfo.GetValue(xx).ToString());
                        var names = exceptTuple.Item1;
                        //Console.WriteLine(
                        //    $"value -- {codexType  }, {codexTypeFieldInfo.GetValue(xx).ToString()} -- names length {names.Length}");
                        string testPropertyValue = wooSahPropertyInfo.GetValue(this).ToString();
                  
                        if (names.Contains(testPropertyValue))
                        {
                            if (exceptTuple.Item2)
                                return true;
                            else
                                return false;
                        }

                        //}
                    }

                }
            }

            return false;

        }
        //            foreach (string element in tModelTypes.Item1)
        //            {
        //                // if model is on list for this WooSah's material     
        //                // if model is on list for this  WooSah's Finish              

        //                if (element != "")
        //                {
        //                    if ((tMaterialTypes.Item1.Contains(element) == tMaterialTypes.Item2) == false ||
        //                        (tFinishTypes.Item1.Contains(element) == tFinishTypes.Item2) == false)
        //                    {
        //                        return false;
        //                    }
        //                }
        //}

        //            foreach (string element in tMaterialTypes.Item1)
        //            {
        //                // if material  is on list for this WooSah's model    
        //                // if material   is on list for this  WooSah's Finish 
        //                if (element != "")
        //                {
        //                    if ((tModelTypes.Item1.Contains(element) == tModelTypes.Item2) == false ||
        //                        (tFinishTypes.Item1.Contains(element) == tFinishTypes.Item2) == false)
        //                    {
        //                        return false;
        //                    }
        //                }
        //            }

        //            foreach (string element in tFinishTypes.Item1)
        //            {
        //                // if model is on list for this WooSah's model  
        //                // if model is on list for this  WooSah's   material                     
        //                if (element != "")
        //                {
        //                    if ((tModelTypes.Item1.Contains(element) == tModelTypes.Item2) == false ||
        //                        (tMaterialTypes.Item1.Contains(element) == tMaterialTypes.Item2) == false)
        //                    {
        //                        return false;
        //                    }
        //                }
        //            }

        //            return true;
        //         }

        public Tuple<string[], bool> getTuple(Type wType, string property)
        {
            FieldInfo modelFieldInfo = wType.GetField(property);

            string[] arrEmpty = { "" };

            if (modelFieldInfo == null)
            {
                return new Tuple<string[], bool>(arrEmpty, false);
            }

            var customAttributeList = modelFieldInfo.CustomAttributes.ToList();
            if (customAttributeList.Count == 0)
            {
                return new Tuple<string[], bool>(arrEmpty, false);
            }

            bool allow = Boolean.Parse(customAttributeList[0].ConstructorArguments[1].Value.ToString());
            ReadOnlyCollection<CustomAttributeTypedArgument> collection =
                customAttributeList[0]
                    .ConstructorArguments[0]
                    .Value as ReadOnlyCollection<CustomAttributeTypedArgument>;

            if (collection == null)
            {
                return new Tuple<string[], bool>(arrEmpty, false);
            }

            List<string> sColl = new List<string>();

            for (int i = 0; i < collection.Count; i++)
            {
                sColl.Add(collection[i].Value.ToString());
            }

            return new Tuple<string[], bool>(sColl.ToArray(), false);
        }
    }
}