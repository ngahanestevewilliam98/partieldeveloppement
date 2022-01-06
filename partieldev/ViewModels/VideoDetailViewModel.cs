using System;
using System.Diagnostics;
using Xamarin.Forms;


namespace partieldev.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class VideoDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string category;
        private string imageUrl;
        private string videoUrl;
        private string likes;
        private string dislikes;
        private string language;
        private string duration;
        private string note;
        private string price;
        private string playingDate;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public double ScreenHeight
        {
            get => Application.Current.MainPage.Height / 3;
        }

        public double ScreenWith
        {
            get => Application.Current.MainPage.Width;
        }

        public double ScreenWithtree
        {
            get => (Application.Current.MainPage.Width * 2)/5;
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string Category
        {
            get => category;
            set => SetProperty(ref category, value);
        }

        public string ImageUrl
        {
            get => imageUrl;
            set => SetProperty(ref imageUrl, value);
        }

        public string VideoUrl
        {
            get => videoUrl;
            set => SetProperty(ref videoUrl, value);
        }

        public string Likes
        {
            get => likes;
            set => SetProperty(ref likes, value);
        }

        public string Dislikes
        {
            get => dislikes;
            set => SetProperty(ref dislikes, value);
        }

        public string Language
        {
            get => language;
            set => SetProperty(ref language, value);
        }

        public string Duration
        {
            get => duration;
            set => SetProperty(ref duration, value);
        }

        public string Note
        {
            get => note;
            set => SetProperty(ref note, value);
        }

        public string Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        public string PlayingDate
        {
            get => playingDate;
            set => SetProperty(ref playingDate, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetVideoAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                Category = item.Category;
                ImageUrl = item.ImageUrl;
                VideoUrl = item.VideoUrl;
                Likes = item.Likes;
                Dislikes = item.Dislikes;
                Language = item.Language;
                Duration = item.Duration;
                Note = item.Note;
                Price = item.Price;
                PlayingDate = item.PlayingDate;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
