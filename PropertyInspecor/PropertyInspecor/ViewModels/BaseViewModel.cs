using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Controls.UserDialogs.Maui;

namespace PropertyInspecor.ViewModels
{
	public class BaseViewModel
	{
        private IUserDialogs _userDialogs;

        public BaseViewModel()
        {
            _userDialogs = UserDialogs.Instance;
        }

        public void ShowLoadingPopUp(string loadingText = "Loading...")
        {
            _userDialogs.ShowLoading(loadingText);
        }

        public void HidePopUp()
        {
            _userDialogs.HideHud();
        }

        internal void OnNavigatedTo(NavigatedToEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}

