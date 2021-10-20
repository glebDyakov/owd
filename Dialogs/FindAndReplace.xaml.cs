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
    /// Логика взаимодействия для FindAndReplace.xaml
    /// </summary>
    public partial class FindAndReplace : Window
    {

        public string activeTab;

        public FindAndReplace(string activeTab)
        {
            InitializeComponent();

            this.activeTab = activeTab;

            if (this.activeTab.Contains("find")) {
                findAndReplaceTabs.SelectedIndex = 0;
            } else if (this.activeTab.Contains("replace"))
            {
                findAndReplaceTabs.SelectedIndex = 1;
            } else if (this.activeTab.Contains("goto"))
            {
                findAndReplaceTabs.SelectedIndex = 2;
            }
        }

        private void areaOfSearchHandler(object sender, RoutedEventArgs e)
        {

        }

        private void selectDrivenReadingHandler(object sender, RoutedEventArgs e)
        {

        }

        private void findNextHandler(object sender, RoutedEventArgs e)
        {

        }

        private void closeFindAndReplaceHandler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void greatherHandler(object sender, RoutedEventArgs e)
        {

        }

        private void replaceAllHandler(object sender, RoutedEventArgs e)
        {

        }

        private void replaceHandler(object sender, RoutedEventArgs e)
        {

        }
    }
}
