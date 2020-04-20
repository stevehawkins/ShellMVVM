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
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            var vm = (LoginViewModel)GalaSoft.MvvmLight.Ioc.SimpleIoc.Default.GetInstance(typeof(LoginViewModel));
            this.InitializeComponent();
            this.BindingContext = vm;
        }
    }
}