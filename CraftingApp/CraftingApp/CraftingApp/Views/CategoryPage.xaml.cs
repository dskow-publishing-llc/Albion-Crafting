using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CraftingApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryPage : ContentPage
	{
		public CategoryPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            SizeChanged += (sender, args) => {
                MetalButton.WidthRequest = Width * 0.4;
                WoodButton.WidthRequest = Width * 0.4;
                ClothButton.WidthRequest = Width * 0.4;
                LeatherButton.WidthRequest = Width * 0.4;
                StoneButton.WidthRequest = Width * 0.4;
                MeatButton.WidthRequest = Width * 0.4;
                MountButton.WidthRequest = Width * 0.4;
                FoodButton.WidthRequest = Width * 0.4;
                BagButton.WidthRequest = Width * 0.4;
                PotionButton.WidthRequest = Width * 0.4;
                FarmButton.WidthRequest = Width * 0.4;
                AnimalButton.WidthRequest = Width * 0.4;
                HunterButton.WidthRequest = Width * 0.4;
                MageButton.WidthRequest = Width * 0.4;
                WarriorButton.WidthRequest = Width * 0.4;
            };
            MetalButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Bars"));
            };
            WoodButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Planks"));
            };
            ClothButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Cloth"));
            };
            LeatherButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Leathers"));
            };
            StoneButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Blocks"));
            };
            MeatButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Crops"));
            };
            MountButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Mounts"));
            };
            FoodButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Foods"));
            };
            BagButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Bags"));
            };
            PotionButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Potions"));
            };
            FarmButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Farm"));
            };
            AnimalButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Animals"));
            };
            MageButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Hunter"));
            };
            HunterButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Mage"));
            };
            WarriorButton.Clicked += delegate {
                Navigation.PushAsync(new ItemsPage("Warrior"));
            };
        }
    }
}