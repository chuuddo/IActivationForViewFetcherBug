using System.Diagnostics;

namespace IActivationForViewFetcherBug
{
    public partial class TabC
    {
        public TabC()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Debug.WriteLine($"{GetType()} activated!");
        }

        private void UserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Debug.WriteLine($"{GetType()} disposed!");
        }
    }
}