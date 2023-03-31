using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamerinCrossApp.ViewModels;
using XamerinCrossApp.Views;

namespace XamerinCrossApp
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
