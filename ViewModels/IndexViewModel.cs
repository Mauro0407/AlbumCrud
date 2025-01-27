using AlbumCrud.Models;
using AlbumCrud.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AlbumCrud.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        public ObservableCollection<Album> Albums { get; }
        public ICommand CreateCommand { get; }
        public ICommand ShowCommand { get; }

        public IndexViewModel()
        {
            Albums = new ObservableCollection<Album>();
            CreateCommand = new Command(OnCreate);
            ShowCommand = new Command<Album>(OnShow);
        }

        private void OnCreate() => Application.Current.MainPage.Navigation.PushAsync(new CreatePage());
        private void OnShow(Album album) => Application.Current.MainPage.Navigation.PushAsync(new ShowPage { BindingContext = new ShowViewModel(album) });
    }
}
