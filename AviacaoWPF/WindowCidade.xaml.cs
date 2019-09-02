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

namespace AviacaoWPF
{
    /// <summary>
    /// Lógica interna para WindowCidade.xaml
    /// </summary>
    public partial class WindowCidade : Window
    {

        public ViewModel.CidadesViewModel CidadesViewModel { get; set; }
        public WindowCidade()
        {
            InitializeComponent();
            this.CidadesViewModel = new ViewModel.CidadesViewModel();
            this.DataContext = this;
        }

        private void AdicionarButton_Click(object sender, RoutedEventArgs e)
        {
            this.CidadesViewModel.Adicionar();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.CidadesViewModel.Salvar();
            this.Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
