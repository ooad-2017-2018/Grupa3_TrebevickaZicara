using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Gbook.Core
{
 
        public abstract class BindableBase : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
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
        }
  }

