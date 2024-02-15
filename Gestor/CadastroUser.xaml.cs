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
using MySql.Data.MySqlClient;



namespace Gestor
{
    /// <summary>
    /// Lógica interna para CadastroUser.xaml
    /// </summary>
    public partial class CadastroUser : Window
    {
        MySqlConnection connection;
        

        public CadastroUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                

                string stringConection = "server=localhost;uid=root;pwd=;database=gestorpessoalpro";
                connection = new MySqlConnection(stringConection);
                connection.Open();
                string sql = "INSERT INTO cadastro_user values(default, " + Nome_User + "," + CPF_User + ", " + RG_User + ")";
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.ExecuteReader();
            } 
            catch(Exception s) {

                MessageBox.Show(s.Message);            
            }
            finally
            {
                connection.Close();
            }
            

        }
    }
}
