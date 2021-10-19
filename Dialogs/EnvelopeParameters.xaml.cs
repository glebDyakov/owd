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
    /// Логика взаимодействия для EnvelopeParameters.xaml
    /// </summary>
    public partial class EnvelopeParameters : Window
    {

        public string activeTab = "envelope";

        public EnvelopeParameters(string activeTab)
        {
            InitializeComponent();

            this.activeTab = activeTab;
            if (this.activeTab.Contains("envelope"))
            {
                envelopeAndPrintTabs.SelectedIndex = 0;
            }
            else if (this.activeTab.Contains("print"))
            {
                envelopeAndPrintTabs.SelectedIndex = 1;
            }
        }
    }
}
