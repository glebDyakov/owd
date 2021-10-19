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
    /// Логика взаимодействия для StatisticsDialog.xaml
    /// </summary>
    public partial class StatisticsDialog : Window
    {


        public int pages = 0;
        public int words = 0;
        public int charsWithoutSpaces = 0;
        public int charsWithSpaces = 0;
        public int paragraphs = 0;
        public int lines = 0;

        public StatisticsDialog(int pages, int words, int charsWithoutSpaces, int charsWithSpaces, int paragraphs, int lines)
        {
            InitializeComponent();

            this.pages = pages;
            this.words = words;
            this.charsWithoutSpaces = charsWithoutSpaces;
            this.charsWithSpaces = charsWithSpaces;
            this.paragraphs = paragraphs;
            this.lines = lines;

        }

        private void refreshStatistics(object sender, RoutedEventArgs e)
        {

        }
    }
}
