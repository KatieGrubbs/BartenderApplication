using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderApplication.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }

        // Each Ingredient has an optional association with a Cocktail
        public int? CocktailId { get; set; }
        public Cocktail Cocktail { get; set; }
    }
}