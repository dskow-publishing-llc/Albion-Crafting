using CraftingApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CraftingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new CategoryPage())
                    {
                        Title = "Browse",
                        Icon = setIcon("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = setIcon("tab_about.png",null,null)
                    },
                }
            };
        }
        public static string setIcon(string ios, string android, string windows)
        {
            string result = "";
            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    result = ios;
                    break;
                case Device.Android:
                    result = android;
                    break;
                case Device.Windows:
                case Device.WinPhone:
                    result = windows;
                    break;
                default:
                    result = ios;
                    break;
            }
            return result;
        }
    }
}
