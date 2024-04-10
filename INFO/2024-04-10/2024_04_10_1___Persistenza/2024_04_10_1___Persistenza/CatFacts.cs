using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_10_1___Persistenza {
    public class CatFacts {
        public string text { get; set; }
        public string _id { get; set; }
        public string user { get; set; }
        public string type { get; set; }
        public bool deleted { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int __v { get; set; }

    }
}
