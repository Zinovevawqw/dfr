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
    /// Логика взаимодействия для SpravPage.xaml
    /// </summary>
    public partial class SpravPage : Page
    {
        public SpravPage()
        {
            InitializeComponent();
            SpravLV.ItemsSource = Connect.contex.Sprav.ToList();
        }
        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var delSprav = SpravLV.SelectedItems.Cast<Sprav>().ToList();
            if (MessageBox.Show($"Удалить {delSprav.Count}записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.contex.Sprav.RemoveRange(delSprav);
            try
            {
                Connect.contex.SaveChanges();
                SpravLV.ItemsSource = Connect.contex.Sprav.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddSprav(null));
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SpravLV.ItemsSource= Connect.contex.Sprav.ToList();
        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddSprav((sender as Button).DataContext as Sprav));
        }

        private void PoiskTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            var sprav = Connect.contex.Sprav.ToList();

            sprav = sprav.Where(x => x.Price.ToString().ToLower().Contains(filtrTbx.Text.ToString().ToLower())).ToList();

            sprav = sprav.Where(x => x.VidRabot.ToString().ToLower().Contains(PoiskTxb.Text.ToString().ToLower())).ToList();
            SpravLV.ItemsSource = sprav;
        }
        private void RefrBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void filtrTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
    }
}
