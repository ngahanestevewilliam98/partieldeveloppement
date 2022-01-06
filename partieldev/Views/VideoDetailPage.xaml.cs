using System.ComponentModel;
using Xamarin.Forms;
using partieldev.ViewModels;

namespace partieldev.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
