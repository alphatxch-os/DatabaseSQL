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
using MySql.Data.MySqlClient;
namespace DatabaseSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //go to "Manage NuGet Packages
        //install "MySql.Data"
        //add "using MySql.Data.MySqlClient to the top of the document
        //initialise this string, but use your own information
        //server is     "ND-COMPSCI"
        //user is       "TL_S#######"
        //database is   "TL_S#######"
        //port is       "3306"
        //password is   "NotreDDMMYY"
        string connStr = "server=ND-COMPSCI;" +
                         // "user=TL_S2201761;" +
                         //  "database=TL_S2201761;" +
                         "port=3306;";
                      //    "password=Notre021205;";

    
        //MySqlConnection conn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameButton.Text;
            string password = PasswordButton.Text;
            string database = DatabaseButton.Text;
            string connStr = $"server=ND-COMPSCI;user={username};database={database};port=3306;password={password}";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MessageBox.Show("Connection to MySQL server successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close(); 
            }
        }
        //conn = new MySqlConnection(connStr);
        // conn.Open();    
        //MessageBox.Show("Connection to MySQL server successful! ");
    }
    }

