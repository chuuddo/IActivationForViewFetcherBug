using System.Diagnostics;
using System.Reactive.Disposables;
using ReactiveUI;

namespace IActivationForViewFetcherBug
{
    public class TabDBase : ReactiveUserControl<TabDViewModel>
    {
    }

    public partial class TabD
    {
        public TabD()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                Debug.WriteLine($"{GetType()} activated!");
                Disposable.Create(() => Debug.WriteLine($"{GetType()} disposed!")).DisposeWith(d);
            });
        }
    }

    public class TabDViewModel : ReactiveObject
    {
    }
}