using ListBoxMVVM.Models;
using ListBoxMVVM.Utility;
using System.Collections.ObjectModel;
using System.Windows;

namespace ListBoxMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<PersonModel> _personList = new ObservableCollection<PersonModel>();
        private PersonModel _currentPerson = new PersonModel();
               
        private PersonModel _editPerson = new PersonModel();
        public RelayCommand CmdInsert { get; set; }
        public RelayCommand CmdUpdate { get; set; }
        public RelayCommand CmdDelete { get; set; }

        public MainViewModel()
        {
            _personList = new ObservableCollection<PersonModel>(PersonMocking.GetPersons());

            CmdInsert = new RelayCommand(param => Execute_Insert(), param => CanExecute_Insert());
            CmdUpdate = new RelayCommand(param => Execute_Update(), param => CanExecute_Update());
            CmdDelete = new RelayCommand(param => Execute_Delete(), param => CanExecute_Delete());
        }

        public PersonModel CurrentPerson
        {
            get { return _currentPerson; }
            set
            {
                if (value != _currentPerson)
                {
                    SetProperty<PersonModel>(ref _currentPerson, value);
                    EditPerson = _currentPerson;
                }
            }
        }

        public PersonModel EditPerson 
        { 
            get { return _editPerson; }
            set
            {
                if (value != _editPerson)
                {
                    SetProperty<PersonModel>(ref _editPerson, value);
                }
            }
        }

        public ObservableCollection<PersonModel> PersonsList
        {
            get => _personList;
            set => _personList = value;
        }

        private void Execute_Insert()
        {
            if(EditPerson?.Name != "")
            {
                PersonsList.Add(EditPerson);
                EditPerson = null;
            }
        }

        private bool CanExecute_Insert()
        {
            return (EditPerson?.Name != "") ? true : false;
        }

        private void Execute_Update()
        {
            MessageBox.Show("Update", "Command");
        }

        private bool CanExecute_Update()
        {
            return true;
        }
        private void Execute_Delete()
        {
            if(CurrentPerson != null)
            {
                PersonsList.Remove(CurrentPerson);
            }
        }

        private bool CanExecute_Delete()
        {
            return CurrentPerson != null;
        }
    }
}
