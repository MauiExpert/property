using CommunityToolkit.Mvvm.ComponentModel;

namespace PropertyInspecor.Views.Pages
{

    public partial class DashboardPage : ContentPage
    {
        private object parameters;

        public DashboardItems dashboardItems { get; set; }

        public DashboardPage()
        {
            InitializeComponent();


        }

        private void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
        {
            picker.Unfocus();
            picker.Focus();
        }

    }


    public class DashboardItems
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Status { get; set; }
    }
}
