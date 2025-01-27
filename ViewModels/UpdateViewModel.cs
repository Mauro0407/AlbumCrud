using AlbumCrud.Models;
using System.Windows.Input;

namespace AlbumCrud.ViewModels
{
    public class UpdateViewModel : BaseViewModel
    {
        public Album Album { get; set; }
        public ICommand UpdateCommand { get; }

        public UpdateViewModel()
        {
            Album = new Album();
            UpdateCommand = new Command(OnUpdate);
        }

        private void OnUpdate()
        {
            // Lógica de actualización
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
