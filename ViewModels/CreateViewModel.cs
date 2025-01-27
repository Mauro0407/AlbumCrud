using AlbumCrud.Models;
using System.Windows.Input;

namespace AlbumCrud.ViewModels
{
    public class CreateViewModel : BaseViewModel
    {
        public Album Album { get; set; }
        public ICommand SaveCommand { get; }

        public CreateViewModel()
        {
            Album = new Album();
            SaveCommand = new Command(OnSave);
        }

        private void OnSave()
        {
            // Guardar lógica del álbum
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
