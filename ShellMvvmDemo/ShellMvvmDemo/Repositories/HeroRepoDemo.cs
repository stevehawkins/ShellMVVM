using ShellMvvmDemo.Interfaces;
using ShellMvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShellMvvmDemo.Repositories
{
    public class HeroRepoDemo : IHeroRepoDemo
    {
        private List<HeroItem> MockList; 
        public HeroRepoDemo()
        {
            MockList = new List<HeroItem>
            {
                new HeroItem { Id=1, HeroName="Hulk", AboutHero="Big Clever Green Dude",Colour=Xamarin.Forms.Color.LimeGreen, ImageName="hulk.png" },
                new HeroItem { Id=2, HeroName="Captain America", AboutHero="Catch Ma Shield Redskull",Colour=Xamarin.Forms.Color.SkyBlue, ImageName="captain.png"},
                new HeroItem { Id=3, HeroName="Spiderman", AboutHero="Web Slinger Supreme",Colour=Xamarin.Forms.Color.Red , ImageName="spiderman.png"},
                new HeroItem { Id=4, HeroName="Thor", AboutHero="Bring On The Thunder...",Colour=Xamarin.Forms.Color.SandyBrown, ImageName="thor.png"},
            };
        }
        public HeroItem getHeroById(int id)
        {
            return MockList.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<HeroItem> GetHeroList()
        {
            return MockList;
        }
    }
}
