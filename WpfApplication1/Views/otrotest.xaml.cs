using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Lógica de interacción para otrotest.xaml
    /// </summary>
    public partial class otrotest : Window
    {
        public otrotest()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.VMotrotest();
        }

        private void dgListaC_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            dgListaC.SelectedIndex = 0;
        }
    }
}
