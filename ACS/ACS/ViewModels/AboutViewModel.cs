using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACS.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            StartCallCommand = new Command(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            });
        }

        public ICommand StartCallCommand { get; }
    }
}