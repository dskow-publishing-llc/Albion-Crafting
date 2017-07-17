using System;

using CraftingApp.Models;
using CraftingApp.ViewModels;

using Xamarin.Forms;

namespace CraftingApp.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public ItemsPage(string category)
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel(category);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
