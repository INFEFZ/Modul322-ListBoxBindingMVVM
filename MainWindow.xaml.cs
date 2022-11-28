using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace ListBoxMVVM
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBoxPerson.Focus();
        }
    }

    public class Person : INotifyPropertyChanged
    {
        // Ereignis
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        // Eigenschaften
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        private int? _Alter;
        public int? Alter
        {
            get { return _Alter; }
            set
            {
                _Alter = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Alter"));
            }
        }

        private string _Adresse;
        public string Adresse
        {
            get { return _Adresse; }
            set
            {
                _Adresse = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Adresse"));
            }
        }
    }
}
