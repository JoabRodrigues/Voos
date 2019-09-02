using Aviacao;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AviacaoWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public String TextExemplo { get; set; } = "Exemplo";
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowPessoa wp = new WindowPessoa();
            wp.Show();
        }

        private void Cidades_Click(object sender, RoutedEventArgs e)
        {
            WindowCidade Wc = new WindowCidade();
            Wc.Show();
        }
    }
}
