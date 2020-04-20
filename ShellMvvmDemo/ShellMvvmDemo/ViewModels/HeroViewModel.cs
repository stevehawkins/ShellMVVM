using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ShellMvvmDemo.Base;
using GalaSoft.MvvmLight;
using ShellMvvmDemo.Interfaces;
using System.Collections.ObjectModel;
using ShellMvvmDemo.Models;

namespace ShellMvvmDemo.ViewModels
{
    public class HeroViewModel : MvvmBase
    {
        private IHeroRepoDemo repo;
        public HeroViewModel(IHeroRepoDemo _repo)
        {
            repo = _repo;

            HeroList = new ObservableCollection<HeroItem> ( repo.GetHeroList() );
        }

        private ObservableCollection<HeroItem> _HeroList;

        public ObservableCollection<HeroItem> HeroList
        {
            get { return _HeroList; }
            set { _HeroList = value;
                RaisePropertyChanged();
            }
        }

        private HeroItem _SelectedHero;

        public HeroItem SelectedHero
        {
            get { return _SelectedHero; }
            set {
                if (value == null)
                    return;

                // send via shell
                string parm = Helpers.JsonHelper.SerialiseObject<HeroItem>(value);
                Shell.Current.GoToAsync($"//HeroDetail?hero={parm}");

                _SelectedHero = null;
            }
        }


    }
}
