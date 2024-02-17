using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroUser cadastroUser = new CadastroUser();
            cadastroUser.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProcurarUser procurarUser = new ProcurarUser();
            procurarUser.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RemoverUser removerUser = new RemoverUser();
            removerUser.Show();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}