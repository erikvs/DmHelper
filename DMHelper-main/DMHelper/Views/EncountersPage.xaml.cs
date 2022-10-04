using CommunityToolkit.Mvvm.DependencyInjection;

using DMHelper.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DMHelper.Views
{
    public sealed partial class EncountersPage : Page, INotifyPropertyChanged
    {

        public EncountersViewModel ViewModel { get; }

        static HttpClient client = new HttpClient();
        public ObservableCollection<EncountersViewModel> Encounters;

        // Logic for displaying a selected encounter in the View.
        private EncountersViewModel _selectedEncounter;

        public event PropertyChangedEventHandler PropertyChanged;

        public EncountersViewModel SelectedEncounter
        {
            get => _selectedEncounter;
            set
            {

                if (_selectedEncounter != value)
                {
                    _selectedEncounter = value;
                    RaisePropertyChanged();

                }
            }

        }

        private void RaisePropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        // Property to tell the UI if an encounter is to be shown or not.
        public bool IsEncounterSelected => SelectedEncounter != null;

        public EncountersPage()
        {
            ViewModel = Ioc.Default.GetService<EncountersViewModel>();
            InitializeComponent();

            Task.Run(() => this.GetEncounters()).Wait();

            // Default selected encounter when page is loaded.
            SelectedEncounter = Encounters[0];
        }


        public async Task GetEncounters()
        {
            // Gets the data from the API in JSON format.
            var apiData = client.GetStreamAsync("https://localhost:44374/api/Encounter");

            // Converts the JSON data to a list format.
            var list = await JsonSerializer.DeserializeAsync<List<EncountersViewModel>>(await apiData);

            // Converts list to ObservableCollection and binds it to variable Encounters for use in view.
            Encounters = new ObservableCollection<EncountersViewModel>(list);
        }


        void saveEncounter(object sender, RoutedEventArgs e)
        {
            // Get encounter id from button tag.
            var myValue = ((Button)sender).Tag;

            // Create a list of encounters.
            var list = new List<EncountersViewModel>(Encounters);

            // Find encounter based in Id.
            var encounter = list.Find(s => s.Id == (int)myValue);

            // Convert encounter into JSON.
            var encounterJson = JsonSerializer.Serialize(encounter);

            // Convert http put request.
            var httpPutRequest = new StringContent(encounterJson, Encoding.UTF8, "application/json");

            // Send http put reset to update encounter.
            client.PutAsync("https://localhost:44374/api/Encounter/" + myValue, httpPutRequest);

        }

        void deleteEncounter(object sender, RoutedEventArgs e)
        {
            // Get encounter id form button tag.
            var myValue = ((Button)sender).Tag;

            // Remove the envounter that is to be deleted from list of encounters visible in view.
            Encounters.Remove(SelectedEncounter);

            // Set current selection to the first encounter in the monster list.
            SelectedEncounter = Encounters[0];

            // Send http delete to delete in DB.
            client.DeleteAsync("https://localhost:44374/api/Encounter/" + myValue);

        }

    }
}
