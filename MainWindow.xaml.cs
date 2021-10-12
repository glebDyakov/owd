
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace documenter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Style dropShadowScrollViewerStyle = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fontWeightBolderHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontWeight = FontWeights.Bold;
        }

        private void fontStyleItalicHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontStyle = FontStyles.Italic;
        }

        private void textDecorationUnderlineHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.TextDecorations = TextDecorations.Underline;
        }

        private void textDecorationStrikethroughHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.TextDecorations = TextDecorations.Strikethrough;
        }

        private void textDecorationBackgroundHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Background = Brushes.Red;
        }

        private void textDecorationForegroundHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Foreground = Brushes.Red;
        }

        private void fontSizeHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontSize = 34;
        }

        private void upperCaseHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text = fontWeightBolder.Text.ToUpper();
        }

        private void lowerCaseHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text = fontWeightBolder.Text.ToLower();
        }

        private void textShadowHandler(object sender, RoutedEventArgs e)
        {
            Setter effectSetter = new Setter();
            effectSetter.Property = ScrollViewer.EffectProperty;
            effectSetter.Value = new DropShadowEffect
            {
                ShadowDepth = 4,
                Direction = 330,
                Color = Colors.Black,
                Opacity = 0.5,
                BlurRadius = 4
            };
            Style dropShadowScrollViewerStyle = new Style(typeof(ScrollViewer));
            dropShadowScrollViewerStyle.Setters.Add(effectSetter);
            fontWeightBolder.Resources.Add(typeof(ScrollViewer), dropShadowScrollViewerStyle);
        }

        private void textSubscriptHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Typography.Variants = FontVariants.Subscript;
        }

        private void textSuperscriptHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Typography.Variants = FontVariants.Superscript;
        }

        private void clearStylesHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Typography.Variants = FontVariants.Normal;
            fontWeightBolder.FontSize = 14;
            fontWeightBolder.FontWeight = FontWeights.Normal;
            fontWeightBolder.FontStyle = FontStyles.Normal;
            fontWeightBolder.TextDecorations = null;
            fontWeightBolder.Background = Brushes.Transparent;
            fontWeightBolder.Foreground = Brushes.Black;
            fontWeightBolder.FontFamily = new FontFamily("Times New Roman");
            fontWeightBolder.Resources.Clear();

        }

        private void fontFamilyChangeToTimesNewRoman(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new FontFamily("Times New Roman");
        }

        private void fontFamilyChangeToArial(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new FontFamily("Arial");
        }

        private void fontFamilyChangeToCalibri(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new FontFamily("Calibri");
        }

        private void fontFamilyChangeToVerdana(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new FontFamily("Verdana");
        }

        private void drawFigureLine(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.X1 = 1;
            myLine.X2 = 50;
            myLine.Y1 = 1;
            myLine.Y2 = 50;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            page.Children.Add(myLine);
        }

        private void drawFigureCircle(object sender, RoutedEventArgs e)
        {
            System.Windows.Shapes.Ellipse myCircle = new System.Windows.Shapes.Ellipse();
            myCircle.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myCircle.Width = 25;
            myCircle.Height = 50;
            myCircle.HorizontalAlignment = HorizontalAlignment.Left;
            myCircle.VerticalAlignment = VerticalAlignment.Center;
            myCircle.StrokeThickness = 2;
            page.Children.Add(myCircle);
        }

        private void drawFigureRect(object sender, RoutedEventArgs e)
        {
            System.Windows.Shapes.Rectangle myRect = new System.Windows.Shapes.Rectangle();
            myRect.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myRect.Width = 25;
            myRect.Height = 50;
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            myRect.StrokeThickness = 2;
            page.Children.Add(myRect);
        }

        private void insertTable(object sender, RoutedEventArgs e)
        {
            Dialogs.TableDialog tableDialog = new Dialogs.TableDialog();
            tableDialog.Show();
        }
    }
}
