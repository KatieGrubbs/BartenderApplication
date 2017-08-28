using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderApplication.Models
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string CocktailName { get; set; }

        // Each Cocktail has an optional association with an Order
        public int? OrderId { get; set; }
        public Order Order { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}