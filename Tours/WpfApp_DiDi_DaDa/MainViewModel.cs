using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace WpfApp_DiDi_DaDa
{
    public class MainViewModel: INotifyPropertyChanged
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
        #region SeletctedItem
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
        public RelayCommand DecrementComand
        {
            get => decrementCommand ?? (decrementCommand =
                new RelayCommand(DecrementCommandExecute, DecrementCommandCanExecute));
        }

        private void DecrementCommandExecute(object x)
        {
            int.TryParse(x.ToString(), out var decVal);
            Counter -= decVal;
        }

        private bool DecrementCommandCanExecute(object obj)
        {
            int.TryParse(obj.ToString(), out var decVal);
            return Counter - decVal >= 0;
        }
        #endregion

        #region IncrementCommand
        private RelayCommand incrementComand;

        

        public RelayCommand IncrementComand
        {
            get => incrementComand ?? (incrementComand =
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
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
