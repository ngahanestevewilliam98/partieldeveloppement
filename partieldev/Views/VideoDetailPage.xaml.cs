using System.ComponentModel;
using Xamarin.Forms;
using partieldev.ViewModels;
using Xamarin.Essentials;
using System;
using System.Windows.Input;

namespace partieldev.Views
{
    public partial class VideoDetailPage : ContentPage
    {
        public VideoDetailPage()
        {
            InitializeComponent();
            BindingContext = new VideoDetailViewModel();
        }

        public async void playVideo(object sender, EventArgs e)
        {
            Button menuItem = sender as Button;
            string itemID = menuItem.CommandParameter as string;
            await Shell.Current.GoToAsync($"{nameof(VideoPage)}?itemId={itemID}");
        }
    }
}
