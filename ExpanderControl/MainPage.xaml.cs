using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ExpanderControl
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MyContentDialog();
            await dialog.ShowAsync();
        }
    }
}
