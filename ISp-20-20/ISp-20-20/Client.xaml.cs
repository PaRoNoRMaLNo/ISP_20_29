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

namespace ISp_20_20
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : UserControl
    {
        public string UserId = "";
        public Client()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            new SQL().InsDelUpd("Delete from [Trade].[dbo].[User] where UserId = " + UserId);
        }
    }
}
