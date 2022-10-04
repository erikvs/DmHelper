using CommunityToolkit.Mvvm.DependencyInjection;
using DMHelper.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DMHelper.Views
{
    public sealed partial class MonstersPage : Page, INotifyPropertyChanged
    {
        public MonstersViewModel ViewModel { get; }

        static HttpClient client = new HttpClient();
        public ObservableCollection<MonstersViewModel> Monsters;

        // Object used as base for adding new content to DB.
        public MonstersViewModel newMonster = new();

        // Logic for displaying a selected monster in the View.
        private MonstersViewModel _selectedMonster;

        public event PropertyChangedEventHandler PropertyChanged;

        public MonstersViewModel SelectedMonster
        {
            get => _selectedMonster;
            set
            {
                if (_selectedMonster != value)
                {
                    _selectedMonster = value;
                    RaisePropertyChanged();
                }
            }
        }

        private void RaisePropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        // Property to tell the UI if a monster is to be shown or not.
        public bool IsMonsterSelected => SelectedMonster != null;


        public MonstersPage()
        {
            ViewModel = Ioc.Default.GetService<MonstersViewModel>();
            InitializeComponent();

            Task.Run(() => this.GetMonsters()).Wait();

            // Default selected monster when page is loaded.
            SelectedMonster = Monsters[0];
        }

        public async Task GetMonsters()
        {
            // Gets the data from the API in JSON format.
            var apiData = client.GetStreamAsync("https://localhost:44374/api/Monster");

            // Converts the JSON data to a list format.
            var list = await JsonSerializer.DeserializeAsync<List<MonstersViewModel>>(await apiData);

            // Converts list to ObservableCollection and binds it to variable Monsters for use in view.
            Monsters = new ObservableCollection<MonstersViewModel>(list);
        }

        void saveMonster(object sender, RoutedEventArgs e)
        {

            // Get monster id from button tag.
            var myValue = ((Button)sender).Tag;

            // Create a list of monsters.
            var list = new List<MonstersViewModel>(Monsters);

            // Find monster based in Id.
            var monster = list.Find(s => s.Id == (int)myValue);

            // Convert monster into JSON.
            var monsterJson = JsonSerializer.Serialize(monster);

            // Convert http put request.
            var httpPutRequest = new StringContent(monsterJson, Encoding.UTF8, "application/json");

            // Send http put reset to update monster.
            client.PutAsync("https://localhost:44374/api/Monster/" + myValue, httpPutRequest); 
        }

        void deleteMonster(object sender, RoutedEventArgs e)
        {
            // Get monster id form button tag.
            var myValue = ((Button)sender).Tag;

            // Remove the monster that is to be deleted from list of monsters visible in view.
            Monsters.Remove(SelectedMonster);

            // Set current selection to the first monster in the monster list.
            SelectedMonster = Monsters[0];

            // Send http delete to delete in DB.
            client.DeleteAsync("https://localhost:44374/api/Monster/" + myValue);
        }
    }
}
