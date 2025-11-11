using System.Windows.Input;
using MauiApp1.Models;
using MauiApp1.ViewModels;
using Microsoft.Maui.Graphics;

namespace MauiApp1.ViewModels.Pages
{
    public class MainPageViewModel : BaseViewModel
    {
        private PetModel petDetails;
        public PetModel PetDetails
        {
            get => petDetails;
            set => SetProperty(ref petDetails, value);
        }

        private string adoptButtonText = "Adopt Me";
        public string AdoptButtonText
        {
            get => adoptButtonText;
            set => SetProperty(ref adoptButtonText, value);
        }

        private Color favouriteButtonColor = Colors.White;
        public Color FavouriteButtonColor
        {
            get => favouriteButtonColor;
            set => SetProperty(ref favouriteButtonColor, value);
        }

        public ICommand AdoptCommand { get; }
        public ICommand ToggleFavouriteCommand { get; }

        public MainPageViewModel()
        {
            PetDetails = new PetModel();

            AdoptCommand = new Command(OnAdopt);
            ToggleFavouriteCommand = new Command(OnToggleFavourite);
        }

        private void OnAdopt()
        {
            PetDetails.IsAdopted = !PetDetails.IsAdopted;
            AdoptButtonText = PetDetails.IsAdopted ? "Adopted" : "Adopt Me";
        }

        private void OnToggleFavourite()
        {
            FavouriteButtonColor = FavouriteButtonColor == Colors.White ? Colors.Red : Colors.White;
        }
    }
}
