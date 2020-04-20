using GalaSoft.MvvmLight;

namespace ShellMvvmDemo.Base
{
	public class MvvmBase : ViewModelBase
    {
		private bool _IsBusy;

		public bool IsBusy
		{
			get { return _IsBusy; }
			set { 
				_IsBusy = value;
				RaisePropertyChanged();
			}
		}

	}
}
