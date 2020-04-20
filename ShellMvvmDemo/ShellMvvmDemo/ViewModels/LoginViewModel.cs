using ShellMvvmDemo.Base;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace ShellMvvmDemo.ViewModels
{
    public class LoginViewModel: MvvmBase
    {
        public ICommand LoginCommand { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(LoginCommandHandler);
        }

        private async void LoginCommandHandler(object obj)
        {
            // demo so just route here
            await Shell.Current.GoToAsync($"//Heros");
        }
    }
}
