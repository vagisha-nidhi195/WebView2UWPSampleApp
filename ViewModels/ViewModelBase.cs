using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WebView2_UWP.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        /// <summary>
        /// Fires an event when called. Used to update the UI in the MVVM world.
        /// [CallerMemberName] Ensures only the peoperty that calls it gets the event
        /// and not every property
        /// </summary>
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
