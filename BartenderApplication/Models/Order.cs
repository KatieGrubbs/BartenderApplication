using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BartenderApplication.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Cocktail Name")]
        public CocktailName CocktailName { get; set; }

        [Required]
        [Display(Name = "Ordered By")]
        public string OrderedBy { get; set; }
    }

    public enum CocktailName
    {
        [Display(Name = "Appletini")] Appletini = 1,
        [Display(Name = "Bloody Mary")] BloodyMary,
        [Display(Name = "Cosmopolitan")] Cosmopolitan,
        [Display(Name = "Gin and tonic")] GinAndTonic,
        [Display(Name = "Manhattan")] Manhattan,
        [Display(Name = "Margarita")] Margarita,
        [Display(Name = "Martini")] Martini,
        [Display(Name = "Mimosa")] Mimosa,
        [Display(Name = "Sangria")] Sangria,
        [Display(Name = "Tom Collins")] TomCollins
    }
}