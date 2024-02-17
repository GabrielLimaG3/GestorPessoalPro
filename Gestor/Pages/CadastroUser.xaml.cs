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
            string nome_user = Nome_User.Text;
            string cpf_user = CPF_User.Text;
            string rg_user = RG_User.Text;
            MySqlConnection connection;
            string connectionString = "server=localhost;user=root;password=root;port=3306;database=gestorpessoalpro";
           

            if ((nome_user == string.Empty)||(cpf_user == string.Empty))
            {
                if (nome_user == string.Empty)
                {
                    MessageBox.Show("Nome Vazio");
                }
                else
                {
                    MessageBox.Show("CPF Vazio");
                }
                
            }
            else
            {
                try
                {
                    using (connection = new MySqlConnection(connectionString))
                    {
                        string sql = "INSERT INTO cadastro_user(nome, cpf, rg) VALUES (@nome, @cpf, @rg)";
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@nome", nome_user);
                        command.Parameters.AddWithValue("@cpf", cpf_user);
                        command.Parameters.AddWithValue("@rg", rg_user);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Usuario Cadastrado");
                }
            }



        }
    }
}
