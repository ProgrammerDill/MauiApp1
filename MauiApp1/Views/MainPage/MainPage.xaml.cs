using MauiApp1.ViewModels.Pages;

namespace MauiApp1.Views.MainPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }

    }
}