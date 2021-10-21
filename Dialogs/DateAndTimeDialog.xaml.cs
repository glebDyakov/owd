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

namespace documenter.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для DateAndTimeDialog.xaml
    /// </summary>
    public partial class DateAndTimeDialog : Window
    {

        public int selectedFormat = 0;
        public DateAndTimeDialog()
        {
            InitializeComponent();
        }

        private void cancelHandler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okHandler(object sender, RoutedEventArgs e)
        {
            //сперва вставляеме дату в текст
            Dictionary<String, String> dateMonthParser = new Dictionary<String, String>();
            dateMonthParser.Add("1", "января");
            dateMonthParser.Add("2", "февраля");
            dateMonthParser.Add("3", "марта");
            dateMonthParser.Add("4", "апреля");
            dateMonthParser.Add("5", "мая");
            dateMonthParser.Add("6", "июня");
            dateMonthParser.Add("7", "июля");
            dateMonthParser.Add("8", "августа");
            dateMonthParser.Add("9", "сентября");
            dateMonthParser.Add("01", "января");
            dateMonthParser.Add("02", "февраля");
            dateMonthParser.Add("03", "марта");
            dateMonthParser.Add("04", "апреля");
            dateMonthParser.Add("05", "мая");
            dateMonthParser.Add("06", "июня");
            dateMonthParser.Add("07", "июля");
            dateMonthParser.Add("08", "августа");
            dateMonthParser.Add("09", "сентября");
            dateMonthParser.Add("10", "октября");
            dateMonthParser.Add("11", "ноября");
            dateMonthParser.Add("12", "декабря");
            Dictionary<String, String> dateMonthShortParser = new Dictionary<String, String>();
            dateMonthShortParser.Add("1", "янв");
            dateMonthShortParser.Add("2", "фев");
            dateMonthShortParser.Add("3", "мар");
            dateMonthShortParser.Add("4", "апр");
            dateMonthShortParser.Add("5", "май");
            dateMonthShortParser.Add("6", "июн");
            dateMonthShortParser.Add("7", "июл");
            dateMonthShortParser.Add("8", "авг");
            dateMonthShortParser.Add("9", "сент");
            dateMonthShortParser.Add("01", "янв");
            dateMonthShortParser.Add("02", "фев");
            dateMonthShortParser.Add("03", "мар");
            dateMonthShortParser.Add("04", "апр");
            dateMonthShortParser.Add("05", "май");
            dateMonthShortParser.Add("06", "июн");
            dateMonthShortParser.Add("07", "июл");
            dateMonthShortParser.Add("08", "авг");
            dateMonthShortParser.Add("09", "сен");
            dateMonthShortParser.Add("10", "окт");
            dateMonthShortParser.Add("11", "ноя");
            dateMonthShortParser.Add("12", "дек");
            Dictionary<DayOfWeek, String> dateDayOfWeekParser = new Dictionary<DayOfWeek, String>();
            dateDayOfWeekParser.Add(DayOfWeek.Monday, "понедельник");
            dateDayOfWeekParser.Add(DayOfWeek.Tuesday, "вторник");
            dateDayOfWeekParser.Add(DayOfWeek.Wednesday, "среда");
            dateDayOfWeekParser.Add(DayOfWeek.Thursday, "четверг");
            dateDayOfWeekParser.Add(DayOfWeek.Friday, "пятница");
            dateDayOfWeekParser.Add(DayOfWeek.Saturday, "суббота");
            dateDayOfWeekParser.Add(DayOfWeek.Sunday, "воскресенье");
            string returnDate = "";
            if (selectedFormat == 0)
            {
                returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            }
            else if (selectedFormat == 1)
            {
                returnDate = dateDayOfWeekParser[DateTime.Now.DayOfWeek] + ", " + DateTime.Now.Day.ToString() + " " + dateMonthParser[DateTime.Now.Month.ToString()] + " " + DateTime.Now.Year.ToString() + " г.";
            }
            else if (selectedFormat == 2)
            {
                returnDate = DateTime.Now.Day.ToString() + " " + dateMonthParser[DateTime.Now.Month.ToString()] + " " + DateTime.Now.Year.ToString() + " г.";
            }
            else if (selectedFormat == 3)
            {
                returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString().Substring(2, 2);
            }
            else if (selectedFormat == 4)
            {
                returnDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString().Substring(2, 2);
            }
            else if (selectedFormat == 5)
            {
                returnDate = DateTime.Now.Year.ToString().Substring(2, 2) + "-" + dateMonthShortParser[DateTime.Now.Month.ToString()] + "-" + DateTime.Now.Day.ToString();
            }
            else if (selectedFormat == 6)
            {
                returnDate = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            }
            else if (selectedFormat == 7)
            {
                returnDate = DateTime.Now.Day.ToString() + " " + dateMonthShortParser[DateTime.Now.Month.ToString()] + " " + DateTime.Now.Year.ToString().Substring(2, 2) + "г.";
            }
            else if (selectedFormat == 8)
            {
                returnDate = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString().Substring(2, 2);
            }
            else if (selectedFormat == 9)
            {
                returnDate = dateMonthParser[DateTime.Now.Month.ToString()] + " " + DateTime.Now.Year.ToString().Substring(2, 2);
            }
            else if (selectedFormat == 10)
            {
                returnDate = dateMonthShortParser[DateTime.Now.Month.ToString()] + "-" + DateTime.Now.Year.ToString();
            }
            else if (selectedFormat == 11)
            {
                returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            }
            else if (selectedFormat == 12)
            {
                returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(); 
            }
            else if (selectedFormat == 13)
            {
                returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            }
            else if (selectedFormat == 14)
            {
                returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            }
            else if (selectedFormat == 15)
            {
                returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            } else if(selectedFormat == 16)
            {
                returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            }

            TextBox currentParagraph = Helpers.UIHelper.FindChild<TextBox>(Application.Current.MainWindow, "fontWeightBolder");
            currentParagraph.Text = returnDate;
            this.Close();
        }
        private void changeLanguageHandler(object sender, SelectionChangedEventArgs e)
        {
            if (languagesBox.SelectedIndex.ToString().Contains("0"))
            {
                languageLabel.Text = "английский (США)";
            }
            else if (languagesBox.SelectedIndex.ToString().Contains("1"))
            {
                languageLabel.Text = "русский";
            }
        }

        private void selectFormatHandler(object sender, MouseButtonEventArgs e)
        {
            TextBlock selectedControl = (TextBlock)sender;
            this.selectedFormat = Int32.Parse(selectedControl.DataContext.ToString());
            foreach (TextBlock format in formats.Children) {
                format.Background = System.Windows.Media.Brushes.Transparent;
            }
            ((TextBlock) formats.Children[selectedFormat]).Background = System.Windows.Media.Brushes.AliceBlue;
        }
    }
}
