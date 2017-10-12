using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModels
{
    class VMotrotest: INotifyPropertyChanged
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

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<B> ListaB
        { get; set; }

        public VMotrotest()
        {
            ListaB = new ObservableCollection<B>();
            B objB = new B();
            objB.BA = 11;
            objB.BB = 12;
            C objC = new C();
            objC.CA = 111;
            objC.CB = 112;
            objB.ListaC.Add(objC);
            objC = new C();
            objC.CA = 211;
            objC.CB = 212;
            objB.ListaC.Add(objC);
            ListaB.Add(objB);

            objB = new B();
            objB.BA = 21;
            objB.BB = 22;
            objC = new C();
            objC.CA = 121;
            objC.CB = 122;
            objB.ListaC.Add(objC);
            objC = new C();
            objC.CA = 221;
            objC.CB = 222;
            objB.ListaC.Add(objC);
            ListaB.Add(objB);

            objB = new B();
            objB.BA = 31;
            objB.BB = 32;

            ListaB.Add(objB);
            SelectedA = 0;
        }
    }

    public class A
    {
        public ObservableCollection<B> ListaB
        { get; set; }
    }

    public class B
    {
        public int BA
        { get; set; }
        public int BB
        { get; set; }

        public ObservableCollection<C> ListaC
        { get; set; }

        public B()
        {
            ListaC = new ObservableCollection<C>();
        }
    }

    public class C
    {
        public int CA
        { get; set; }

        public int CB
        { get; set; }
    }

}
