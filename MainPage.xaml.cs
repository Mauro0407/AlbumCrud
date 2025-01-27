using AlbumCrud.Views;

namespace AlbumCrud
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGoToIndexClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IndexPage());
        }


        private async void OnGoToCreateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage());
        }

        private async void OnGoToShowClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowPage());
        }

        private async void OnGoToUpdateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdatePage());
        }
    }
}
