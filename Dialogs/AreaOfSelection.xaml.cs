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
    /// Логика взаимодействия для AreaOfSelection.xaml
    /// </summary>
    public partial class AreaOfSelection : Window
    {
        public AreaOfSelection()
        {
            InitializeComponent();
        }
        private void toggleAreaOfSelection(object sender, RoutedEventArgs e)
        {
            if (areaOfSelection.Visibility == Visibility.Collapsed)
            {
                areaOfSelection.Visibility = Visibility.Visible;
            }
            else if (areaOfSelection.Visibility == Visibility.Visible)
            {
                areaOfSelection.Visibility = Visibility.Collapsed;
            }
        }
    }
}
