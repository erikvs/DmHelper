using CommunityToolkit.Mvvm.DependencyInjection;
using DMHelper.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace DMHelper.Views
{
    public sealed partial class CreateMonsterPage : Page
    {
        public CreateMonsterViewModel ViewModel { get; }

        static HttpClient client = new HttpClient();
        public ObservableCollection<MonstersViewModel> Monsters;

        // Objects used as base for adding new content to DB.
        public MonstersViewModel newMonster = new();


        public CreateMonsterPage()
        {
            ViewModel = Ioc.Default.GetService<CreateMonsterViewModel>();
            InitializeComponent();
            newMonster.EnvironmentTypeId = 0;
        }


        void createMonster(object sender, RoutedEventArgs e)
        {
            switch (newMonster.EnvironmentTypeId)
            {

                case 1:
                    newMonster.EnvironmentTypeId = 10;
                    break;

                case 2:
                    newMonster.EnvironmentTypeId = 17;
                    break;

                case 3:
                    newMonster.EnvironmentTypeId = 19;
                    break;

                default:
                    newMonster.EnvironmentTypeId = 10;
                    break;
            }

            // Convert monster into JSON.
            var monsterJson = JsonSerializer.Serialize(newMonster);

            // Convert http post request.
            var httpPostRequest = new StringContent(monsterJson, Encoding.UTF8, "application/json");

            // Send http post reset to add new monster.
            client.PostAsync("https://localhost:44374/api/Monster/", httpPostRequest);

            // Reset newMonster.
            newMonster.Name = null;
            newMonster.Environment = null;
        }
    }
}
