using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ShellMvvmDemo.Base;
using GalaSoft.MvvmLight;
using ShellMvvmDemo.Models;

namespace ShellMvvmDemo.ViewModels
{
    public class HeroDetailViewModel : MvvmBase
    {
        public ICommand CloseCommand { get; set; }
        public HeroDetailViewModel()
        {
            CloseCommand = new Command(CloseCommandHandler);
        }

        private async void CloseCommandHandler(object obj)
        {
            await Shell.Current.GoToAsync("//Heros");
        }

        private HeroItem _CurrentHero;

        public HeroItem CurrentHero
        {
            get { return _CurrentHero; }
            set { 
                _CurrentHero = value;
                RaisePropertyChanged();
            }
        }


    }
}
