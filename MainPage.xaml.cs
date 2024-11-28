using UniversalYogaCustomerApp.Models;
using UniversalYogaCustomerApp.Services;

namespace UniversalYogaCustomerApp;

public partial class MainPage : ContentPage
{
    private readonly ApiService _apiService;
    private List<YogaClass> _classes = new List<YogaClass>();

    public MainPage()
    {
        InitializeComponent();
        _apiService = new ApiService();
        LoadClasses();
    }

    private async void LoadClasses()
    {
        _classes = await _apiService.GetClassesAsync();
        var listView = this.FindByName<ListView>("ClassesListView");
        listView.ItemsSource = _classes;
    }

    private async void OnClassSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is YogaClass selectedClass)
        {
#if WINDOWS
            App.Cart.Add(selectedClass);
            await DisplayAlert("Added to Cart", $"{selectedClass.Type} class added.", "OK");
#else
            Console.WriteLine($"{selectedClass.Type} class added to cart (cross-platform)");
            App.Cart.Add(selectedClass);
#endif
        }
    }
}
