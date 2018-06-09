using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Core
{
    class ErrorHandeling : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        //INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        //...
        protected virtual void SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(property, value)) return;
            property = value;
            RaisePropertyChanged(propertyName);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //....
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        // INotifyDataErrorInfo
        Dictionary<string, List<string>> propErrors = new Dictionary<string, List<string>>();
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        //get error by property
        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (this.propErrors.ContainsKey(propertyName)) return this.propErrors[propertyName];
            return null;
        }
        //has errors
        public bool HasErrors
        {
            get { return (this.propErrors.Count > 0); }
        }
        // object is valid
        public bool IsValid
        {
            get { return !this.HasErrors; }
        }
        public void AddError(string propertyName, string err)
        {
            this.propErrors[propertyName] = new List<string>() { err };
            this.OnPropertyChanged(propertyName);
        }
        public void RemoveError(string propertyName)
        {
            if (this.propErrors.ContainsKey(propertyName)) this.propErrors.Remove(propertyName);
            this.OnPropertyChanged(propertyName);
        }
        public void NotifyErrorsChanged(string propertyName)
        {
            if (this.ErrorsChanged != null)
            {
                this.ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }
    }
}
