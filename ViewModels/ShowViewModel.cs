using AlbumCrud.Models;
using System.Windows.Input;

namespace AlbumCrud.ViewModels
{
    public class ShowViewModel : BaseViewModel
    {
        public Album Album { get; set; }
        public ICommand DeleteCommand { get; }

        public ShowViewModel(Album album)
        {
            Album = album;
            DeleteCommand = new Command(OnDelete);
        }

        private void OnDelete()
        {
            // Lógica de eliminación
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
