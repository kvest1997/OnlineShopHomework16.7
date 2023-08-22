using OnlineShopHomework16._7.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace OnlineShopHomework16._7.Models.Base
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        protected ICommand CreateCommand(Action<object> executeAction)
        {
            if (executeAction == null)
            {
                throw new ArgumentNullException("executeAction");
            }

            return new RelayCommand(executeAction);
        }

        public void InvokeOnUIThread(Action action)
        {
            if (Application.Current == null)
            {
                throw new NullReferenceException("Не удалось найти экземпляр текущего приложения");
            }

            if (Application.Current.Dispatcher == null)
            {
                throw new NullReferenceException("Текущее приложение имеет значение Null");
            }

            Application.Current.Dispatcher.Invoke(action);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void SetPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void Dispose()
        {

        }
    }
}
