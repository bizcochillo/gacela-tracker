using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GacelaTracker.Front
{
    public partial class MainPage : ContentPage
    {
        private void LoadCompetitions()
        {

        }

        public MainPage()
        {
            InitializeComponent();

            LoadCompetitions();
        }

        private async void AddCompetition_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CompetitionPage());
        }

        private async void AddPlayer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayerPage());
        }
    }
}
