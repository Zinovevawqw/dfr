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
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MDK0101.Pages
{
    /// <summary>
    /// Логика взаимодействия для YcetnPage.xaml
    /// </summary>
    public partial class YcetnPage : Page
    {
        public YcetnPage()
        {
            InitializeComponent();
            YcetnLV.ItemsSource = Connect.contex.Ycetn.ToList();
            sort.ItemsSource = new[] { "По умолчанию", "По возврастанию", "По убыванию" };
            sort.SelectedIndex = 0;
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddYcetn(null));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var delYcetn = YcetnLV.SelectedItems.Cast<Ycetn>().ToList();
            foreach (var del in delYcetn)
                if (Connect.contex.Sprav.Any(x => x.NomerRemontRabot == del.NomerRemontRabor))
                {
                    MessageBox.Show("Данные используются в Справочной таблице","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delYcetn.Count}записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) 
            Connect.contex.Ycetn.RemoveRange(delYcetn);
            try
            {
                Connect.contex.SaveChanges();
                YcetnLV.ItemsSource = Connect.contex.Ycetn.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RefrBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            YcetnLV.ItemsSource=Connect.contex.Ycetn.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddYcetn((sender as Button).DataContext as Ycetn));
        }
        private void PoiskTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
        private void Update()
        {
            var acc = Connect.contex.Ycetn.ToList();

            switch (sort.SelectedIndex)
            {
                case 1:
                    acc = acc.OrderBy(x => x.DlitelnostRabot).ToList();
                    break;
                case 2:
                    acc = acc.OrderByDescending(x => x.DlitelnostRabot).ToList();
                    break;
            }


            acc = acc.Where(x => x.NomerRemontRabor.ToString().ToLower().Trim().Contains(filtTxb.Text.ToString().ToLower().Trim())).ToList();

            acc = acc.Where(x => x.DataNacala.ToString().ToLower().Trim().Contains(PoiskTxb.Text.ToString().ToLower().Trim())
            || x.Kol_voVipoln.ToString().ToLower().Trim().Contains(PoiskTxb.Text.ToString().ToLower().Trim())).ToList();

            YcetnLV.ItemsSource = acc;
        }
        private void filtTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void ExcelBtn_Click(object sender, RoutedEventArgs e)
        {
            var ycet = Connect.contex.Ycetn.ToList();
            var sprav = Connect.contex.Sprav.ToList();
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet ws = (Excel.Worksheet)app.Worksheets.get_Item(1);
            ws.Name = "Учётная  таблица";
            Excel.Range r = ws.Range["A1", "E2"];
            r.Merge();
            r.Value = "Ведомость проделанных работ";
            r.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            r.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            ws.Cells.Font.Name = "Times New Roman";
            ws.Cells[3, 1].Value = "Наименование работы";
            ws.Cells[3, 2].Value = "Вид работы";
            ws.Cells[3, 3].Value = "Цена";
            ws.Cells[3, 4].Value = "Кол-во выполнений";
            ws.Cells[3, 5].Value = "Стоимость";
            var curRow = 4;
            int sum = 0;
            foreach (var item in ycet)
            {
                ws.Cells[curRow, 1].Value = item.Sprav.NazvanRabot;
                ws.Cells[curRow, 2].Value = item.Sprav.VidRabot;
                ws.Cells[curRow, 3].Value = item.Sprav.Price;
                ws.Cells[curRow, 4].Value = item.Kol_voVipoln;
                ws.Cells[curRow, 5].Value = item.Kol_voVipoln * item.Sprav.Price;
                sum += item.Kol_voVipoln * item.Sprav.Price;

                curRow++;
            }
            ws.Cells[curRow, 1].Value = "Итого: ";
            ws.Cells[curRow, 5].Value = sum;
            Excel.Range range = ws.Range[ws.Cells[curRow, 1], ws.Cells[curRow, 4]];
            range.Merge();
            Excel.Range ran = ws.Range[ws.Cells[3, 1], ws.Cells[curRow, 5]];
            ran.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            ws.Columns.AutoFit();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "Ведомость проделанных работ");
            wb.SaveAs(filePath);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }

        private void PdfBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("Ведомость.pdf", FileMode.Create));
                doc.Open();
                BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                PdfPTable table = new PdfPTable(5);
                PdfPCell cell = new PdfPCell(new Phrase("Ведомость проделанных работ", font));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1;
                cell.Border = 0;
                table.AddCell(cell);
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Наименование работы", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Вид работы", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Цена", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Кол-во выполнений", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Стоимость", font))));
                int sum = 0;
                foreach (var item in Connect.contex.Ycetn.ToList())
                {
                    table.AddCell(new Phrase(item.Sprav.NazvanRabot.ToString(), font));
                    table.AddCell(new Phrase(item.Sprav.VidRabot.ToString(), font));
                    table.AddCell(new Phrase(item.Sprav.Price.ToString(), font));
                    table.AddCell(new Phrase(item.Kol_voVipoln.ToString(), font));
                    table.AddCell(new Phrase((item.Kol_voVipoln * item.Sprav.Price).ToString(), font));
                    sum += item.Kol_voVipoln * item.Sprav.Price;
                }
                table.AddCell(new PdfPCell(new Phrase("Итого: ", font)) { Colspan = 4 });
                table.AddCell(new Phrase(sum.ToString(), font));
                doc.Add(table);
                doc.Close();
                MessageBox.Show("PDF-документ сохранён");
            }
            catch
            {
                MessageBox.Show("PDF-документ не сохранён", "Ошибка");
            }
        }
    }
}
