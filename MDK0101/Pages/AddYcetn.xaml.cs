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
using MDK0101.AppData;
using MDK0101.Pages;

namespace MDK0101.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddYcetn.xaml
    /// </summary>
    public partial class AddYcetn : Page
    {
        Ycetn yce;
        bool checkNew;
        public AddYcetn(Ycetn c)
        {
            InitializeComponent();
            yce = new Ycetn();
           
            if (c == null)
            {
                c = new Ycetn();
                checkNew = true;
            }
            else
                checkNew = false;
            DataContext = yce = c;

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                Connect.contex.Ycetn.Add(yce);
            }
            try
            {
                Connect.contex.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Nav.MainFrame.GoBack();
        }

        public static bool CheckAccounting(Ycetn ych)
        {
            if (ych.DlitelnostRabot > 0)
                return true;
            if (ych.DataNacala == null)
                return false;
            if (ych.Kol_voVipoln < 0)
                return false;
            return true;
        }
    }
}
