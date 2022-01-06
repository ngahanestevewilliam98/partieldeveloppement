using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using partieldev.Models;
using partieldev.Views;

namespace partieldev.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private Video _selectedItem;

        public ObservableCollection<Video> Videos { get; }
        public Command LoadVideosCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Video> ItemTapped { get; }

        public HomeViewModel()
        {
            Title = "Liste des films";
            Videos = new ObservableCollection<Video>();
            LoadVideosCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ItemTapped = new Command<Video>(OnVideoSelected);
        }

        public double ScreenWith
        {
            get => Application.Current.MainPage.Width;
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Videos.Clear();
                var items = await DataStore.GetVideosAsync(true);
                foreach (var item in items)
                {
                    Videos.Add(item);
                }
                Console.WriteLine(Videos);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Video SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnVideoSelected(value);
            }
        }

        async void OnVideoSelected(Video item)
        {
            if (item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(VideoDetailPage)}?{nameof(VideoDetailViewModel.ItemId)}={item.Id}");
        }
    }
}
