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

using Syncfusion.Windows.Tools.Controls;

namespace documenter.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для ColorDialog.xaml
    /// </summary>
    public partial class ColorDialog : Window
    {
        public ColorDialog()
        {
            InitializeComponent();
            
                //Creating an instance of ColorPickerPalette control
                ColorPickerPalette colorPickerPalette = new ColorPickerPalette();
                colorPickerPalette.Width = 60;
                colorPickerPalette.Height = 40;

                //Adding ColorPickerPalette as window content
                this.Content = colorPickerPalette;
        }
    }
}
