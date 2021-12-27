using System;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using Roster.Client.Models;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(() => Title = "Roster App (v2.0)");

            People = new ObservableCollection<Person>
            {
                new Person(){ Name = "Delores Feil", Company = "Legros Group" },
                new Person(){ Name = "Ann Zboncak", Company = "Ledner - Ferry" },
                new Person(){ Name = "Jaime Lesch", Company = "Herzog and Sons"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command UpdateApplicationCommand { get; }

        private string _title = "Roster App";
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Person> People { get; }

        private void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
