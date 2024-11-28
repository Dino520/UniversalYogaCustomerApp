using UniversalYogaCustomerApp.Services;


namespace UniversalYogaCustomerApp
{
    public partial class BookingHistoryPage : ContentPage
    {
        private ApiService _apiService;

        public BookingHistoryPage()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            // Implementation here
        }
    }
}
