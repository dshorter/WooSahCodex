using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooSahCodex.EF
{
    public static class WooSahLoader
    {
        public static void Load(List<WooSah> wList)
        {
            var ctx = new WooSahCodexEntities();
            ctx.WooSahs.AddRange(wList);
            ctx.SaveChanges();

        }
    }
}
