using System;
using System.Collections.Generic;
using System.Text;

namespace ShellMvvmDemo.Models
{
    public class HeroItem
    {
        public int Id { get; set; } // would be an id in a data store
        public string HeroName { get; set; }
        public string AboutHero { get; set; }
        public Xamarin.Forms.Color Colour { get; set; }
        public string ImageName { get; set; }
    }
}
