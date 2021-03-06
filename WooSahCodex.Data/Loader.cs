﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MyCouch;
using MyCouch.Responses;
using WooSahCodex;
using WooSahCodex.EF;

namespace WooSahCodex.Data
{
    public class Loader
    {

        public Loader(List<WooSah> wooSahs)
        {

        }

        public void LoadSql(List<WooSah> wooSahs)
        {
            var pocoEFList = new List<EF.WooSah>();    

            wooSahs.ForEach(w => pocoEFList.Add(w.wooSahEF));    

            WooSahLoader.Load(pocoEFList);

        }

        public async Task LoadCouch(List<WooSah> wooSahs)
        {
            using (var db = new MyCouchClient("http://localhost:5984/", "learn7"))
            {
                var pocoList = new List<WooSahPOCO>();
                wooSahs.ForEach(w => pocoList.Add(w.wooSahPoco));

                foreach (var poco in pocoList)
                {
                    try
                    {
                        var response = db.Entities.PostAsync(poco);
                    }
                    catch (Exception ex)
                    {


                    }

                }

            }

        }

        //private Action<Task<EntityResponse<WooSahPOCO>>> check(Task<EntityResponse<WooSahPOCO>> response)
        ////  private Action<Task<EntityResponse<WooSahPOCO>>> check(EntityResponse<WooSahPOCO> response)
        //{
        //    if (response.Result.StatusCode != HttpStatusCode.Created)
        //    {
        //        var xx = 77;
        //    }

        //    return new Action<Task<EntityResponse<WooSahPOCO>>>(Target);
        //}

    }
}


