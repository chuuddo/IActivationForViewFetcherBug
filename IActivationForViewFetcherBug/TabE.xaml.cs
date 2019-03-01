using System.Diagnostics;
using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;

namespace IActivationForViewFetcherBug
{
    public partial class TabE : IViewFor<TabEViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(TabEViewModel), typeof(TabE), new PropertyMetadata(default(TabEViewModel)));

        public TabE()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                Debug.WriteLine($"{GetType()} activated!");
                Disposable.Create(() => Debug.WriteLine($"{GetType()} disposed!")).DisposeWith(d);
            });
        }

        public TabEViewModel ViewModel
        {
            get => (TabEViewModel) GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TabEViewModel) value;
        }
    }

    public class TabEViewModel : ReactiveObject
    {
    }
}