using System;
using System.Collections.Generic;
using partieldev.ViewModels;
using partieldev.Views;
using Xamarin.Forms;

namespace partieldev
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(VideoPage), typeof(VideoPage));
            Routing.RegisterRoute(nameof(VideoDetailPage), typeof(VideoDetailPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

    }
}
