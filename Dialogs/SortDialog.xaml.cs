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
    /// Логика взаимодействия для SortDialog.xaml
    /// </summary>
    public partial class SortDialog : Window
    {
        public SortDialog()
        {
            InitializeComponent();
        }

        private void openParamsHandler(object sender, RoutedEventArgs e)
        {
            Dialogs.SortParametersDialog sortParametersDialog = new Dialogs.SortParametersDialog();
            sortParametersDialog.Show();
        }

        private void okHandler(object sender, RoutedEventArgs e)
        {
            //применяем сортировку
            this.Close();
        }

        private void cancelHandler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
