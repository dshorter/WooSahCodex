using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using WooSahCodex.Codex.Properties;
using WooSahCodex.Color;
using WooSahCodex.Etching;
using WooSahCodex.Finish;
using WooSahCodex.Material;
using WooSahCodex.Model;

namespace WooSahCodex.Codex
{
    public class WooSah
    {
        public bool isValid;     

        public IModel Model { get; set; }
        public IMaterial Material { get; set; }
        public IFinish Finish { get; set; }
        public IColor Color { get; set; }
        public IEtching Etching { get; set; }

        public bool Validate()
        {
            var tModelTypes = getTuple(typeof(Model), this.Model);
            var tMaterialTypes = getTuple(typeof(Material), this.Material);
            var tFinishTypes = getTuple(typeof(Finish), this.Finish);
            var results = false;

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
                        var exceptTuple = getTuple(codexType, codexTypeFieldInfo.GetValue(xx).ToString());
                        var names = exceptTuple.Item1;
                        //Console.WriteLine(
                        //    $"value -- {codexType  }, {codexTypeFieldInfo.GetValue(xx).ToString()} -- names length {names.Length}");
                        string testPropertyValue = wooSahPropertyInfo.GetValue(this).ToString();

                        Console.WriteLine($"testPropertyValue {testPropertyValue}");

                        if (names[0] == "")
                        {
                            results = true;
                        }
                        else if (names.Contains(testPropertyValue))
                        {
                            if (exceptTuple.Item2)
                                results = true;
                            else
                                return false;
                        }
                    }
                }
            }

            return results;

        }


        public bool Validate3()
        {
            /** For each WooSah property --    
             * 1)  Get the list of excepts
             * 2)  For each item ih the excpets list 
             *     a) Check the calue of all the other WooSah properties     
             *     d) If any match return false    
             */

            var wooSahProperties = typeof(WooSahCodex.Codex.WooSah).GetProperties();

            foreach (var wooSahPropertyInfo in wooSahProperties)
            {
                var wooSahTypes = Utils.GetWooSahTypes();

                var codexTypes = (from codex in wooSahTypes
                                  where codex.Name == wooSahPropertyInfo.Name
                                  select codex).ToList();

                var codexType = codexTypes[0];

                var codexObj = Activator.CreateInstance(codexType);

                var exceptTuple = getTuple(codexType,
                    wooSahPropertyInfo.GetValue(this).ToString());
                var names = exceptTuple.Item1;

                foreach (string name in names)
                {
                    foreach (var wooSahCheckPropertyInfo in wooSahProperties)
                    {
                        if (wooSahCheckPropertyInfo.GetValue(this).ToString() == name)
                        {
                            if (exceptTuple.Item2 == false)
                                return false;

                        }
                    }
                }
            }

            return true;
        }

        public bool Validate2()
        {
            var tModelTypes = getTuple(typeof(Model), this.Model);
            var tMaterialTypes = getTuple(typeof(Material), this.Material);
            var tFinishTypes = getTuple(typeof(Finish), this.Finish);
            var results = false;

            foreach (var wooSahPropertyInfo in typeof(WooSahCodex.Codex.WooSah).GetProperties())
            {
                //  var codexType = Utils.GetWooSahTypes().Where(codex => codex.Name == wooSahPropertyInfo.Name);    
                var wooSahTypes = Utils.GetWooSahTypes();

                var codexTypes = (from codex in wooSahTypes
                                  where codex.Name == wooSahPropertyInfo.Name
                                  select codex).ToList();

                var codexType = codexTypes[0];

                var codexObj = Activator.CreateInstance(codexType);

                var codexFieldInfos = codexType.GetFields()
                    .Where(codexField => codexField.Name == wooSahPropertyInfo.GetValue(this).ToString())
                    .ToList();

                foreach (FieldInfo codexFieldInfo in codexFieldInfos)
                {
                    var exceptTuple = getTuple(codexType,
                        codexFieldInfo.GetValue(codexObj).ToString());
                    var names = exceptTuple.Item1;

                    string testPropertyValue = wooSahPropertyInfo.GetValue(this).ToString();

                    Console.WriteLine($"testPropertyValue {testPropertyValue}");

                    if (names[0] == "")
                    {
                        results = true;
                    }
                    else if (names.Contains(testPropertyValue))
                    {
                        if (exceptTuple.Item2)
                            results = true;
                        else
                            return false;
                    }
                    else
                    {
                        results = true;
                    }

                }
            }

            return results;

        }


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