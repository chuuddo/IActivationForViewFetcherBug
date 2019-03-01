using System.Diagnostics;
using System.Reactive.Disposables;
using ReactiveUI;

namespace IActivationForViewFetcherBug
{
    public partial class TabA
    {
        public TabA()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                Debug.WriteLine($"{GetType()} activated!");
                Disposable.Create(() => Debug.WriteLine($"{GetType()} disposed!")).DisposeWith(d);
            });
        }
    }
}