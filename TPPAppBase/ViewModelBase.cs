using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TPP.AppBase
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T oldvalue, T newvalue, [CallerMemberName] string propertyName = null)
        {
            if (oldvalue == null && newvalue == null)
            {
                return false;
            }

            if (oldvalue != null && oldvalue.Equals(newvalue))
            {
                return false;
            }
            oldvalue = newvalue;
            Notify(propertyName);
            return true;
        }
    }
}