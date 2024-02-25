using System;
using System.Collections.Generic;
using System.Data;
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

using MySql.Data.MySqlClient;

namespace Gestor
{
    /// <summary>
    /// Lógica interna para ProcurarUser.xaml
    /// </summary>
    public partial class ProcurarUser : Window
    {
        string connectionString = "server=localhost;user=root;password=root;port=3306;database=gestorpessoalpro";
        public ProcurarUser()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM cadastro_user";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    connection.Open();

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);

                    // Vincular o DataTable ao DataGrid
                    DG.ItemsSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar usuários: " + ex.Message);
            }
        }

    }
}
