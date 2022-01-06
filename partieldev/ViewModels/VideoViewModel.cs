using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace partieldev.ViewModels
{
    [QueryProperty(nameof(ItemId), "itemId")]
    public class VideoViewModel : BaseViewModel
    {
        private string text;
        private string videoUrl;
        public string id;

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public string VideoUrl
        {
            get => videoUrl;
            set => SetProperty(ref videoUrl, value);
        }


        public string ItemId
        {
            set
            {
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
                VideoUrl = item.VideoUrl;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
