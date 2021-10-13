
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        public TextBox textBox = null;
        public int lineCursor = 1;
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

        private void createOWDHandler(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Новый документ";
            sfd.DefaultExt = ".owd";
            sfd.Filter = "Office ware documents (.owd)|*.owd";
            bool? res = sfd.ShowDialog();
            if (res != false)
            {

                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write("office ware documents");
                    }
                }
            }
        }

        private void openOWDHandler(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Новый документ";
            ofd.DefaultExt = ".owd";
            ofd.Filter = "Office ware documents (.owd)|*.owd";
            bool? res = ofd.ShowDialog();
            if (res != false)
            {
                Stream myStream;
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string file_name = ofd.FileName;
                    string file_text = File.ReadAllText(file_name);
                    fontWeightBolder.Text = file_text;
                }
            }
        }

        private void insertSpecialCharEuro(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "€";
        }

        private void insertSpecialCharPoud(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "£";
        }

        private void insertSpecialCharYen(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "¥";
        }

        private void insertSpecialCharCopyright(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "©";
        }

        private void insertSpecialCharRegistered(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "®";
        }
        private void insertSpecialCharTM(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "™";
        }
        private void insertSpecialCharPlusOrMinus(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "±";
        }
        private void insertSpecialCharNotEqual(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "≠";
        }
        private void insertSpecialCharAll(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "∑";
        }
        private void insertSpecialCharBeta(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "β";
        }
        private void insertSpecialCharPi(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "π";
        }
        private void insertSpecialCharInfinity(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "∞";
        }
        private void insertSpecialCharLessAndEqual(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "≤";
        }
        private void insertSpecialCharGratherAndEqual(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "≥";
        }
        private void insertSpecialCharAlpha(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "α";
        }
        private void insertSpecialCharU(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "µ";
        }
        private void insertSpecialCharFrequency(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "Ω";
        }
        private void insertSpecialCharMultiply(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "×";
        }
        private void insertSpecialCharDivide(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "÷";
        }
        private void insertSpecialCharArrow(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Text += "↑";
        }

        private void openSettings(object sender, RoutedEventArgs e)
        {
            Dialogs.Settings settingsDialog = new Dialogs.Settings();
            settingsDialog.Show();
        }

        private void alignLeftHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Center;
        }
        private void alignRightHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Right;
        }
        private void alignJustifyHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Stretch;
        }

        private void intervalHandler(object sender, RoutedEventArgs e)
        {
            TextBlock.SetLineHeight(fontWeightBolder, 25);
        }

        private void allBordersHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.BorderThickness = new Thickness(5.0);
        }

        private void noneBordersHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.BorderThickness = new Thickness(0);
        }

        private void upBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Top = 5;
            fontWeightBolder.BorderThickness = border;
        }

        private void downBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Bottom = 5;
            fontWeightBolder.BorderThickness = border;
        }

        private void leftBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Left = 5;
            fontWeightBolder.BorderThickness = border;
        }

        private void rightBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Right = 5;
            fontWeightBolder.BorderThickness = border;
        }

        private void markersHandler(object sender, RoutedEventArgs e)
        {

        }

        private void numberHandler(object sender, RoutedEventArgs e)
        {

        }

        private void multiLevelListHandler(object sender, RoutedEventArgs e)
        {

        }

        private void decreaseIndentHandler(object sender, RoutedEventArgs e)
        {

        }

        private void increaseIndentHandler(object sender, RoutedEventArgs e)
        {

        }

        private void sortHandler(object sender, RoutedEventArgs e)
        {

        }

        private void showAllCharsHandler(object sender, RoutedEventArgs e)
        {

        }

        private void fillHandler(object sender, RoutedEventArgs e)
        {

        }

        private void findHandler(object sender, RoutedEventArgs e)
        {

        }

        private void replaceHandler(object sender, RoutedEventArgs e)
        {

        }

        private void selectHandler(object sender, RoutedEventArgs e)
        {

        }

        /*delegate void CursorChangedDelegate(RoutedEvent re, Delegate handler);
        void CursorChangedHandler(RoutedEvent re, Delegate handler)
        {
            if (fontWeightBolder.Text.Length >= 75)
            {
                textBox = new TextBox();
                textBox.BorderThickness = new Thickness(0);
                textBox.MaxLines = 1;
                textBox.BorderBrush = Brushes.Transparent;
                page.Children.Add(textBox);
                Canvas.SetTop(textBox, page.Children.Count * 35);
                Canvas.SetLeft(textBox, 50);
                textBox.Focus();
                fontWeightBolder = textBox;
            }
            else if (fontWeightBolder.Text.Length <= 0)
            {
                page.Children[page.Children.Count - 2].Focus();
                fontWeightBolder = (TextBox)page.Children[page.Children.Count - 2];
                page.Children.Remove(textBox);
            }
        }*/

        public String TextInputHandle(TextCompositionEventArgs e) {

            if (fontWeightBolder.Text.Length >= 60)
            {
                textBox = new TextBox();
                textBox.Width = 450;
                textBox.BorderThickness = new Thickness(0);
                textBox.MaxLines = 1;
                textBox.BorderBrush = Brushes.Transparent;
                page.Children.Add(textBox);
                page.Children[lineCursor].Focus();
                lineCursor++;
                Canvas.SetTop(textBox, page.Children.Count * 35);
                Canvas.SetLeft(textBox, 50);
                textBox.Focus();
                fontWeightBolder = textBox;
                textBox.AddHandler(TextBox.TextChangedEvent,
                    new RoutedEventHandler(
                        delegate {
                            String response = TextInputHandle(e);
                            if (response.Contains("newline"))
                            {
                                //fontWeightBolder.Text = e.Text;
                                e.Handled = true;
                            }
                        }
                    )
                );
                return "newline";
            } else if (fontWeightBolder.Text.Length <= 0 && lineCursor >= 2) {
                lineCursor--;
                //page.Children[page.Children.Count - 2].Focus();
                page.Children[lineCursor - 1].Focus();
                //fontWeightBolder = (TextBox)page.Children[page.Children.Count - 2];
                fontWeightBolder = (TextBox)page.Children[lineCursor - 1];
                //page.Children.Remove(textBox);
                page.Children.Remove((TextBox)page.Children[lineCursor]);
            }
            return "no-break string";

        }

        public void CursorChangeHandle()
        {

        }

            private void inputHandler(object sender, TextCompositionEventArgs e)
        {
            if (fontWeightBolder.Text.Length >= 60)
            {
                TextBox textBox = new TextBox();
                textBox.Width = 450;
                textBox.BorderThickness = new Thickness(0);
                textBox.MaxLines = 1;
                textBox.BorderBrush = Brushes.Transparent;
                page.Children.Add(textBox);
                page.Children[lineCursor].Focus();
                lineCursor++;
                Canvas.SetTop(textBox, page.Children.Count * 35);
                Canvas.SetLeft(textBox, 50);
                fontWeightBolder = textBox;
                textBox.AddHandler(TextBox.TextChangedEvent,
                    new RoutedEventHandler(
                        delegate
                        {
                            String response = TextInputHandle(e);
                            if (response.Contains("newline"))
                            {
                                //fontWeightBolder.Text = e.Text;
                                e.Handled = true;
                            }
                        }
                    )
                );
            } else if (fontWeightBolder.Text.Length <= 0 && lineCursor >= 2) {
                lineCursor--;
                //page.Children[page.Children.Count - 2].Focus();
                page.Children[lineCursor - 1].Focus();
                //fontWeightBolder = (TextBox)page.Children[page.Children.Count - 2];
                fontWeightBolder = (TextBox)page.Children[lineCursor - 1];
                //page.Children.Remove(textBox);
                page.Children.Remove((TextBox)page.Children[lineCursor]);
            }
        }

        private void changeLineFromCursor(object sender, MouseButtonEventArgs e)
        {
            fontWeightBolder = (TextBox)sender;
            lineCursor = page.Children.IndexOf(fontWeightBolder) + 1;
            fontWeightBolder.Text = lineCursor.ToString();
        }
    }
}