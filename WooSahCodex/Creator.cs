using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using WooSahCodex.Codex.Properties;

namespace WooSahCodex.Codex
{
    public class Creator
    {
        public int Count { get; set; }

        public Creator()
        {
            Count = 0;
            WooSah wooSah;
            List<WooSah> wooSahList = new List<WooSah>();
        
            foreach (FieldInfo modelsFieldInfo in typeof(Model).GetFields())
            {
                foreach (FieldInfo materialsFieldInfo in typeof(Material).GetFields())
                {
                    foreach (FieldInfo FinishFieldInfo in typeof(Finish).GetFields())
                    {

                        Count++;

                        wooSah = new WooSah()
                        {
                            Material = materialsFieldInfo.Name,
                            Model = modelsFieldInfo.Name,
                            Finish = FinishFieldInfo.Name

                        };


                        try
                        {
                            wooSah.isValid = wooSah.Validate3();
                        }
                        catch (Exception ex  )
                        {

                            throw new Exception();
                        }

                        wooSahList.Add(wooSah);    

                    }
                }

            }

            foreach (WooSah wooSahItem in wooSahList)
            {
                Console.WriteLine($"Model -- {wooSahItem.Model}  ");
                Console.WriteLine($"Material -- {wooSahItem.Material}  ");
                Console.WriteLine($"Fihish -- {wooSahItem.Finish}  ");
                Console.WriteLine($"isValid -- {wooSahItem.isValid}  ");
            }

        }
    }
}
