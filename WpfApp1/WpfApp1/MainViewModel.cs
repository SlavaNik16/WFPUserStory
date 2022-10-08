using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            items = new ObservableCollection<string>();
            items.Add("1");
            items.Add("2");
            items.Add("3");
            items.Add("4");
            items.Add("5");
        }

        #region Counter
        private int counter;
        public int Counter
        {
            get => counter; 
            set
            {
                counter = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region Items
        private ObservableCollection<string> items;
        public ObservableCollection<string> Items 
        { 
            get => items; 
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region SelectedItem
        private string selectedItem;
        public string SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region AppendText
        private string appendText;
        public string AppendText
        {
            get => appendText;
            set
            {
                appendText = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Commands

        #region DecrementCommand

        private RelayCommand decrementCommand;
        public RelayCommand DecrementCommand
        {
            get => decrementCommand ?? (decrementCommand =
                new RelayCommand(param =>
                {
                    int.TryParse(param.ToString(), out var decrVal);
                    Counter -= decrVal;
                },
                    param =>
                    {
                        int.TryParse(param.ToString(), out var decrVal);
                        return Counter - decrVal >= 0;
                    }));
        }

        #endregion
        #region IncrementCommand
        private RelayCommand incrementCommand;

        public RelayCommand IncrementCommand
        {
            get => incrementCommand ?? (incrementCommand =
                new RelayCommand(IncrementCommandExecute, IncrementCommandCanExecute));
        }
        private void IncrementCommandExecute(object x)
        {
            int.TryParse(x.ToString(), out var incVal);
            Counter += incVal;
        }

        private bool IncrementCommandCanExecute(object obj)
        {
            int.TryParse(obj.ToString(), out var incVal);
            return Counter + incVal <= 10;
        }

        #endregion
        #region AddCommand
        private RelayCommand addCommand;
        public RelayCommand AddCommand 
        {
            get => addCommand ?? (addCommand =
                new RelayCommand(
                    _ =>
                    {
                        Items.Add(AppendText);
                        AppendText = string.Empty;
                    },
                    _ => !string.IsNullOrWhiteSpace(AppendText))
                );
        }
        #endregion

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
