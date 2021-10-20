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
            string returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            /*returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + " г.";
            returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + " г.";
            returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            returnDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            returnDate = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            returnDate = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            returnDate = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "." + DateTime.Now.Year.ToString();
            returnDate = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            returnDate = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            returnDate = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();*/
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
    }
}
