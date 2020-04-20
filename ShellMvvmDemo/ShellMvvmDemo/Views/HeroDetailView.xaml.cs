using ShellMvvmDemo.Models;
using ShellMvvmDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellMvvmDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("Hero", "hero")]
    public partial class HeroDetailView : ContentPage
    {
        public string Hero
        {
            set
            {
                var converted = Uri.UnescapeDataString(value);
                var hero = Helpers.JsonHelper.DeserialiseObject<HeroItem>(converted);
                var vm = (HeroDetailViewModel)GalaSoft.MvvmLight.Ioc.SimpleIoc.Default.GetInstance(typeof(HeroDetailViewModel));
                vm.CurrentHero = hero;
                this.BindingContext = vm;
            }
        }

        public HeroDetailView()
        {
            InitializeComponent();
        }
    }
}