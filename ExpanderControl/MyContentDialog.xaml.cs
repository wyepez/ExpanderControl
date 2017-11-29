using Windows.UI.Xaml.Controls;

namespace ExpanderControl
{
    public sealed partial class MyContentDialog : ContentDialog
    {
        public MyContentDialog()
        {
            InitializeComponent();
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
