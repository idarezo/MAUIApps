using AndroidX.Lifecycle;
using Java.Sql;
using MauiApp2_RMR.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace MauiApp2_RMR;

public partial class UporabnikiPage : ContentPage
{
    private readonly UporabnikiWrapperNovi _viewModel;
    public UporabnikiPage()
	{
        InitializeComponent();
        _viewModel = new UporabnikiWrapperNovi();
        this.BindingContext = _viewModel;
        FetchData();       
    }


    private async Task FetchData()
    {
        try
        {
            JsonSerializerOptions _serializerOptions;
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            using HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://dummyjson.com/users");
            List<UporabnikiWrapper> Items = new List<UporabnikiWrapper>();

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var wrapper = System.Text.Json.JsonSerializer.Deserialize<UporabnikiWrapperNovi>(content, _serializerOptions);
                    var ItemsDol = wrapper.Users;
                    _viewModel.Users = wrapper.Users;

                    yourStackLayout.Children.Clear();
                    foreach (var user in wrapper.Users)
                    {
                        
                        var stackLayout = new StackLayout { Padding = 10, Orientation = StackOrientation.Vertical };

                       
                        var firstNameLabel = new Label { Text = user.FirstName, FontSize = 18 };
                        var lastNameLabel = new Label { Text = user.LastName, FontSize = 16 };
                        var emailLabel = new Label { Text = user.Email, FontSize = 14 };
                        var genderLabel = new Label { Text = user.Gender, FontSize = 14 };

                      
                        stackLayout.Children.Add(firstNameLabel);
                        stackLayout.Children.Add(lastNameLabel);
                        stackLayout.Children.Add(emailLabel);
                        stackLayout.Children.Add(genderLabel);

                       
                        yourStackLayout.Children.Add(stackLayout);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Deserialization failed: {ex.Message}");
            }
            Console.WriteLine(Items.ToString());



            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching data: {ex.Message}");
        }
    }
}