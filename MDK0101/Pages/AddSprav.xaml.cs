using MDK0101.AppData;
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
using MDK0101.Pages;


namespace MDK0101.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddSprav.xaml
    /// </summary>
    public partial class AddSprav : Page
    {
        Sprav spr;
        bool checkNew;
        public AddSprav(Sprav c)
        {
            InitializeComponent();
            if (c == null)
            { 
                c = new Sprav();
                checkNew = true;
            }
            else 
                checkNew = false;
            DataContext = spr = c;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                Connect.contex.Sprav.Add(spr);
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

        public static bool CheckInformation(Sprav spr)
        {
            if (string.IsNullOrEmpty(spr.NazvanRabot) || !spr.NazvanRabot.Replace(" ", "").All(char.IsLetter))
                return false;
            if (spr.Price < 0)
                return false;
            if (string.IsNullOrEmpty(spr.VidRabot) || !spr.VidRabot.Replace(" ", "").All(char.IsLetter))
                return false;
            return true;
        }
    }
}
