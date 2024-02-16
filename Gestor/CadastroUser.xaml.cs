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
        
      

        public CadastroUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome_user = Nome_User.ToString();
            string cpf_user = CPF_User.ToString();
            string rg_user = RG_User.ToString();
            
            try {

                
                string stringConection = "server=localhost;user=root;password=root;port=3306;database=gestorpessoalpro";
                MySqlConnection connection = new MySqlConnection(stringConection);

                string sql = $"INSERT INTO cadastro_user values( default, {nome_user}, {cpf_user}, {rg_user})";
                MySqlCommand command = new MySqlCommand(sql ,connection);
                connection.Open();
                command.ExecuteReader();
            } 
            catch(Exception s) {

                MessageBox.Show(s.Message);            
            }


        }
    }
}
