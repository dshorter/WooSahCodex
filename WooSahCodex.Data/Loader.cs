using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MyCouch;
using MyCouch.Responses;
using WooSahCodex;

namespace WooSahCodex.Data
{
    public class Loader
    {

        public Loader(List<WooSah> wooSahs)
        {

        }

        public async Task Load(List<WooSah> wooSahs)
        {
            using (var db = new MyCouchClient("http://localhost:5984/", "learn4"))
            {
                var pocoList = new List<WooSahPOCO>();
                wooSahs.ForEach(w => pocoList.Add(w.wooSahPoco));

                //  var response = " ";
                foreach (var poco in pocoList)
                //  for (var x = 0; x < 6000; x++)
                {
                    try
                    {
                        var response = db.Entities.PostAsync(poco);
                        check(response);
                    }
                    catch (Exception ex)
                    {


                    }

                    //  response.Wait();

                }


            }

        }

        private Action<Task<EntityResponse<WooSahPOCO>>> check(Task<EntityResponse<WooSahPOCO>> response)
        //  private Action<Task<EntityResponse<WooSahPOCO>>> check(EntityResponse<WooSahPOCO> response)
        {
            if (response.Result.StatusCode != HttpStatusCode.Created)
            {
                var xx = 77;
            }

            return new Action<Task<EntityResponse<WooSahPOCO>>>(Target);
        }

        private void Target(Task<EntityResponse<WooSahPOCO>> task)
        {







        }

        //private void check(EntityResponse<WooSahPOCO> result)
        //{
        //    if (result.StatusCode != HttpStatusCode.Created)
        //    {
        //        var xx = 77;
        //    }
        //}
    }
}


