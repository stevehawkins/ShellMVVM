using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellMvvmDemo.Views;
using GalaSoft.MvvmLight.Ioc;
using ShellMvvmDemo.Repositories;
using ShellMvvmDemo.Interfaces;
using ShellMvvmDemo.ViewModels;

namespace ShellMvvmDemo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            InitContainer();

            MainPage = new AppShell();
            Shell.Current.GoToAsync("//Login");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public void InitContainer()
        {
            // repos & services
            SimpleIoc.Default.Reset();

            // create repo here that we can inject into viewmodels
            var Herorep  = new HeroRepoDemo();
            SimpleIoc.Default.Register<IHeroRepoDemo>(() => Herorep);

            // reg common view models
            SimpleIoc.Default.Register<HeroDetailViewModel>();
            SimpleIoc.Default.Register<HeroViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();

        }
    }
}
