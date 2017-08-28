using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderApplication.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderedBy { get; set; }
        public DateTime OrderTime { get; set; }
        public ICollection<Cocktail> Cocktails { get; set; }
    }
}