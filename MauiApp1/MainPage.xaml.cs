namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            if (count == 1)
                AdoptBtn.Text = $"Adopted";
            else
                AdoptBtn.Text = $"Adopted";

            SemanticScreenReader.Announce(AdoptBtn.Text);
        }

        private bool isFavourited = false;

        private void OnFavouriteClicked(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (isFavourited)
                {
                    // Button does not have a BackColor property.
                    // Use BackgroundColor instead.
                    button.BackgroundColor = Colors.Transparent;
                }
                else
                {
                    button.BackgroundColor = Colors.Red;
                }
                isFavourited = !isFavourited;
            }
        }
    }
}
