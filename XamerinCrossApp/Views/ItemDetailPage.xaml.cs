using System.ComponentModel;
using Xamarin.Forms;
using XamerinCrossApp.ViewModels;

namespace XamerinCrossApp.Views
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