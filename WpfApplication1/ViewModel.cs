using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class ViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _selectedA;
        private int _selectedB;
        public int SelectedA
        {
            get { return this._selectedA; }
            set
            {
                this._selectedA = value;
                this.SelectedB = 0;
                NotifyPropertyChanged();
            }
        }

        public int SelectedB
        {
            get { return this._selectedB; }
            set
            {
                this._selectedB = value;
                NotifyPropertyChanged();
            }

        }

        public ObservableCollection<string> Lista1 { get; set; }
        public ObservableCollection<string> Lista2 { get; set; }


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ViewModel()
        {
            Lista1 = new ObservableCollection<string>();
            Lista1.Add("11");
            Lista1.Add("12");
            Lista1.Add("13");
            Lista1.Add("14");

            Lista2 = new ObservableCollection<string>();
            Lista2.Add("21");
            Lista2.Add("22");
            Lista2.Add("23");
            Lista2.Add("24");
        }

    }
}
