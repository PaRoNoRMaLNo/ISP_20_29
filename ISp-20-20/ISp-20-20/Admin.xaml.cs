using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ISp_20_20
{
    /// <summary>
    /// 89871396219
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void LoadDataBtn_Click(object sender, RoutedEventArgs e)
        {
            Clients.Children.Clear();
            SqlDataReader reader = new SQL().Select(@"SELECT 
                                    [UserID]
                                  ,[UserSurname]
                                  ,[UserName]
                                  ,[UserPatronymic]
                              FROM [Trade].[dbo].[User]");
            while (reader.Read())
            {
                Client client = new Client();
                client.Fio.Text = reader[1].ToString();
                client.DateofBirth.Content = reader[2].ToString();
                client.City.Content = reader[3].ToString();
                client.UserId = reader[0].ToString();
                Clients.Children.Add(client);
            }

        }
    }
}
