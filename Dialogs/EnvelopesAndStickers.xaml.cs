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
    /// Логика взаимодействия для EnvelopesAndStickers.xaml
    /// </summary>
    public partial class EnvelopesAndStickers : Window
    {

        public string activeTab = "envelopers";
        public EnvelopesAndStickers(string activeTab)
        {
            InitializeComponent();

            this.activeTab = activeTab;

            if (this.activeTab.Contains("employers"))
            {
                employersAndStickersTabs.SelectedIndex = 0;
            } else if (this.activeTab.Contains("stickers"))
            {
                employersAndStickersTabs.SelectedIndex = 1;
            }

        }

        private void openStickParameters(object sender, MouseButtonEventArgs e)
        {
            Dialogs.StickParameters stickParameters = new Dialogs.StickParameters();
            stickParameters.Show();
        }

        private void openEmployerParameters(object sender, MouseButtonEventArgs e)
        {
            StackPanel selectedPanel = (StackPanel)sender;
            Dialogs.EnvelopeParameters envelopesAndStickers = new Dialogs.EnvelopeParameters(selectedPanel.DataContext.ToString());
            envelopesAndStickers.Show();
        }
    }
}
