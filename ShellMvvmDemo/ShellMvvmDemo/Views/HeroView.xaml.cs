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
    public partial class HeroView : ContentPage
    {
        public HeroView()
        {
            var vm = (HeroViewModel)GalaSoft.MvvmLight.Ioc.SimpleIoc.Default.GetInstance(typeof(HeroViewModel));
            this.InitializeComponent();
            this.BindingContext = vm;
        }

        private void ItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}