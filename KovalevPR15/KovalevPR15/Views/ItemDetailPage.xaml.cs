using KovalevPR15.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KovalevPR15.Views
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