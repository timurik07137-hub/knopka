using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace knopka
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _email = string.Empty;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private string _phone = string.Empty;
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public ICommand ClearCommand { get; }

        public MainViewModel()
        {
            ClearCommand = new Command(ClearAll);
        }

        private void ClearAll()
        {
            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}