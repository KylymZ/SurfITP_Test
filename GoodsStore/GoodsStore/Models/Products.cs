using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsStore.Models
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }=string.Empty;
        public double price { get; set; }
        public string image_url { get; set; } = string.Empty;
    }
}
