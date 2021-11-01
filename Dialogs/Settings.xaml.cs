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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public string activeTab = "Общие";

        public Settings()
        {
            InitializeComponent();

            foreach (TextBlock tab in tabs.Children)
            {
                if(tab.Text.Contains(activeTab))
                {
                    tab.Background = System.Windows.Media.Brushes.Gray;
                }
            }

        }

        private void applyEffect(object sender, MouseEventArgs e)
        {
            TextBlock raiser = ((TextBlock)sender);
            if (!activeTab.Contains(raiser.Text))
            {
                raiser.Background = System.Windows.Media.Brushes.LightGray;
            }
        }

        private void resetEffect(object sender, MouseEventArgs e)
        {
            TextBlock raiser = ((TextBlock)sender);
            if (!activeTab.Contains(raiser.Text)) {
                raiser.Background = System.Windows.Media.Brushes.Transparent;
            }
        }

        private void activateTab(object sender, MouseButtonEventArgs e)
        {
            foreach (TextBlock tab in tabs.Children) { 
                tab.Background = System.Windows.Media.Brushes.Transparent;
            }
            TextBlock raiser = ((TextBlock)sender);
            raiser.Background = System.Windows.Media.Brushes.Gray;
            activeTab = raiser.Text;
        }
    }
}
