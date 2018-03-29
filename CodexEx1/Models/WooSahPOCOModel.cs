using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEx1.Models
{
  
    public class WooSahPOCOModel
    {

        public int ID { get; set; }

        public string DocumentId;
        public string _rev;

        public bool isValid;

        public string Model { get; set; }
        public string Material { get; set; }
        public string Finish { get; set; }
        public string Color { get; set; }
        public string Etching { get; set; }

    }

}

