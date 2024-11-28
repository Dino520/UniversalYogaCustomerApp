using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UniversalYogaCustomerApp.Models;

namespace UniversalYogaCustomerApp.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://mockapi.example.com/";

    public ApiService()
    {
        _httpClient = new HttpClient();
    }

    // Fetch list of yoga classes
    public async Task<List<YogaClass>> GetClassesAsync()
    {
        try
        {
            var response = await _httpClient.GetStringAsync($"{BaseUrl}classes");
            return JsonSerializer.Deserialize<List<YogaClass>>(response);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error fetching classes: {ex.Message}");
            return new List<YogaClass>();
        }
    }

    // Submit booking data
    public async Task<bool> SubmitBookingAsync(List<Booking> bookings)
    {
        try
        {
            var json = JsonSerializer.Serialize(bookings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{BaseUrl}bookings", content);
            return response.IsSuccessStatusCode;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error submitting bookings: {ex.Message}");
            return false;
        }
    }
}
