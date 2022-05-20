using KovalevPR15.ViewModels;
using KovalevPR15.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace KovalevPR15
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
