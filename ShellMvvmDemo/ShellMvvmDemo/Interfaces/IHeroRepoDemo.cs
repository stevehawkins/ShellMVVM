using ShellMvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellMvvmDemo.Interfaces
{
    public interface IHeroRepoDemo
    {
        List<HeroItem> GetHeroList();
        HeroItem getHeroById(int id);
    }
}
