using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACS.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string _callToken;

        private string _acsCalleeId;
        public string AcsCalleeId
        {
            get => _acsCalleeId;
            set => SetProperty(ref _acsCalleeId, value);
        }

        private string _acsCallerId;
        public string AcsCallerId
        {
            get => _acsCallerId;
            set => SetProperty(ref _acsCallerId, value);
        }

        private string _acsConnectionString;
        public string AcsConnectionString
        {
            get => _acsConnectionString;
            set => SetProperty(ref _acsConnectionString, value);
        }

        public AboutViewModel()
        {
            Title = "About";
            StartCallCommand = new Command(async () =>
            {
                App.Acs.Initialize(AcsConnectionString);

                _callToken = await App.Acs.CreateAccessTokenForUserAsync(AcsCallerId, TimeSpan.FromHours(2));

                App.Acs.StartCallAsync(_callToken, AcsCalleeId);

                await Task.Delay(TimeSpan.FromSeconds(1));
            });
        }

        public ICommand StartCallCommand { get; }
    }
}