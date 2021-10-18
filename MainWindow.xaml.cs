﻿
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

using System.Speech.Synthesis;
using System.Drawing;
using System.Windows.Interop;

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
        public bool numberOfStrokes = false;
        public double initialWidth = 0;
        public double initialHeight = 0;
        public MainWindow()
        {
            InitializeComponent();

            initialWidth = page.Width;
            initialHeight = page.Height;

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
            fontWeightBolder.Background = System.Windows.Media.Brushes.Red;
        }

        private void textDecorationForegroundHandler(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.Foreground = System.Windows.Media.Brushes.Red;
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
            fontWeightBolder.Background = System.Windows.Media.Brushes.Transparent;
            fontWeightBolder.Foreground = System.Windows.Media.Brushes.Black;
            fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            fontWeightBolder.Resources.Clear();

        }

        private void fontFamilyChangeToTimesNewRoman(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
        }

        private void fontFamilyChangeToArial(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Arial");
        }

        private void fontFamilyChangeToCalibri(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Calibri");
        }

        private void fontFamilyChangeToVerdana(object sender, RoutedEventArgs e)
        {
            fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Verdana");
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

        public void inputHandler(object sender, TextCompositionEventArgs e)
        {
            if (fontWeightBolder.Text.Length >= 60)
            {
                
                /*
                    незаконченная логика добавления новой строки с номером строки  
                    StackPanel paragraph = new StackPanel();
                    paragraph.Orientation = Orientation.Horizontal;
                    TextBox strokeNumber = new TextBox();
                    strokeNumber.Text = (lineCursor + 1).ToString();
                    paragraph.Children.Add(strokeNumber);
                    paragraph.Children.Add(textBox);
                    page.Children.Add(paragraph);
                    Canvas.SetTop(paragraph, 25);
                    Canvas.SetTop(paragraph, page.Children.Count * 35);
                */

                TextBox textBox = new TextBox();
                textBox.Background = System.Windows.Media.Brushes.Transparent;
                textBox.Width = 450;
                textBox.BorderThickness = new Thickness(0);
                textBox.MaxLines = 1;
                textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                page.Children.Add(textBox);

                page.Children[lineCursor].Focus();
                lineCursor++;
                Canvas.SetTop(textBox, page.Children.Count * 35);
                Canvas.SetLeft(textBox, 50);
                fontWeightBolder = textBox;
                textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);

            }
        }

        private void changeLineFromCursor(object sender, MouseButtonEventArgs e)
        {
            fontWeightBolder = (TextBox)sender;
            lineCursor = page.Children.IndexOf(fontWeightBolder) + 1;
            //page.Children[lineCursor - 1].Focus();
        }

        private void specialInputHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                if (fontWeightBolder.Text.Length <= 0 && lineCursor >= 2)
                {
                    lineCursor--;
                    page.Children[lineCursor - 1].Focus();
                    fontWeightBolder = (TextBox)page.Children[lineCursor - 1];
                    page.Children.Remove((TextBox)page.Children[lineCursor]);
                } else if (fontWeightBolder.Text.Length <= 0 && lineCursor == 1 && pages.Children.Count >= 2)
                {
                    pages.Children.Remove((Canvas)pages.Children[pages.Children.Count - 1]);
                    page = (Canvas)pages.Children[pages.Children.Count - 1];
                    fontWeightBolder = (TextBox)page.Children[page.Children.Count - 1];
                    page.Children[page.Children.Count - 1].Focus();
                    lineCursor = page.Children.Count;
                    backdrop.Height -= 650;
                }
            }
            else if (e.Key == Key.Enter)
            {
                if (lineCursor == page.Children.Count) {
                    if (lineCursor <= 16)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Background = System.Windows.Media.Brushes.Transparent;
                        textBox.Width = 450;
                        textBox.BorderThickness = new Thickness(0);
                        textBox.MaxLines = 1;
                        textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                        page.Children.Add(textBox);
                        page.Children[lineCursor].Focus();
                        lineCursor++;
                        Canvas.SetTop(textBox, page.Children.Count * 35);
                        Canvas.SetLeft(textBox, 50);
                        fontWeightBolder = textBox;
                        textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                        textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                        textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
                    } else
                    {
                        createNewPage();
                    }
                }
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.Background = System.Windows.Media.Brushes.Transparent;
                    textBox.Width = 450;
                    textBox.BorderThickness = new Thickness(0);
                    textBox.MaxLines = 1;
                    textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                    int caretIndex = fontWeightBolder.SelectionStart;
                    string caretText = fontWeightBolder.Text.Substring(caretIndex, fontWeightBolder.Text.Length - fontWeightBolder.Text.Substring(0, caretIndex).Length);
                    fontWeightBolder.Text = fontWeightBolder.Text.Substring(0, caretIndex);
                    textBox.Text = caretText;
                    lineCursor++;
                    page.Children.Insert(lineCursor - 1, textBox);
                    page.Children[lineCursor - 1].Focus();
                    foreach (UIElement child in page.Children)
                    {
                        if(page.Children.IndexOf(child) >= lineCursor - 1) { 
                             Canvas.SetTop(child, page.Children.IndexOf(child) * 35);
                        }
                    }
                    Canvas.SetLeft(textBox, 50);
                    fontWeightBolder = textBox;
                    textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                    textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                    textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
                }
            }
            else if (e.Key == Key.Up)
            {
                if (lineCursor >= 2) {
                    lineCursor--;
                    fontWeightBolder = (TextBox) page.Children[lineCursor - 1];
                    page.Children[lineCursor - 1].Focus();
                }
            }
            else if (e.Key == Key.Down)
            {
                if (lineCursor < page.Children.Count)
                {
                    lineCursor++;
                    fontWeightBolder = (TextBox)page.Children[lineCursor - 1];
                    page.Children[lineCursor - 1].Focus();
                }
            }
            else if (e.Key == Key.Left)
            {
                if (lineCursor >= 2 && fontWeightBolder.SelectionStart <= 0)
                {
                    lineCursor--;
                    fontWeightBolder = (TextBox)page.Children[lineCursor - 1];
                    page.Children[lineCursor - 1].Focus();
                }
            }
            else if (e.Key == Key.Right && fontWeightBolder.SelectionStart > fontWeightBolder.Text.Length - 1)
            {
                if (lineCursor < page.Children.Count)
                {
                    lineCursor++;
                    fontWeightBolder = (TextBox)page.Children[lineCursor - 1];
                    page.Children[lineCursor - 1].Focus();
                }
            }
        }

        private void openImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".png";
            ofd.Filter = "images (.png)|*.png";
            bool? res = ofd.ShowDialog();
            if (res != false)
            {
                Stream myStream;
                if ((myStream = ofd.OpenFile()) != null)
                {
                    System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    //bitmapImage.UriSource = new Uri(ofd.FileName, UriKind.Relative);
                    bitmapImage.UriSource = new Uri(ofd.FileName, UriKind.Absolute);
                    bitmapImage.EndInit();
                    img.Source = bitmapImage;
                    img.Width = 450;
                    img.Height = 450;
                    page.Children.Add(img);
                    page.Children[lineCursor].Focus();
                    lineCursor++;
                    Canvas.SetTop(img, page.Children.Count * 35);
                    Canvas.SetLeft(img, 50);
                }
            }
        }

        private void setPortraitOrientation(object sender, RoutedEventArgs e)
        {
            page.Height = 540;
            page.Width = 480;
        }

        private void setLandscapeOrientation(object sender, RoutedEventArgs e)
        {
            page.Height = 480;
            page.Width = 2500;
        }

        private void mustNumberOfStrokes(object sender, RoutedEventArgs e)
        {
            numberOfStrokes = true;
        }

        private void noneNumberOfStrokes(object sender, RoutedEventArgs e)
        {
            numberOfStrokes = false;
        }

        private void setZoomTwiHandrid(object sender, RoutedEventArgs e)
        {
            
            zoom.Width = initialWidth * 2;
            zoom.Height = initialHeight * 2;
            
        }

        private void setZoomOneHandrid(object sender, RoutedEventArgs e)
        {
            zoom.Width = initialWidth;
            zoom.Height = initialHeight;
        }

        private void setZoomSeventyFive(object sender, RoutedEventArgs e)
        {
            zoom.Width = initialWidth * 0.75;
            zoom.Height = initialHeight * 0.75;

             mainScroll.Content = pages;

        }

        private void newWindow(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Title = "Новый документ " + Application.Current.Windows.OfType<Window>().ToList().Count.ToString();
            newWindow.Show();
        }

        private void goToAnotherWindow(object sender, RoutedEventArgs e)
        {
            //Window otherWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => !x.IsActive);
            //Window otherWindow = Application.Current.Windows.OfType<Window>().ToList()[0];
            
            MenuItem currentMenuItem = (MenuItem)sender;
            //goToAnotherWindowMenuItem.Items.IndexOf(currentMenuItem);
            Window otherWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.Title.Contains(currentMenuItem.Header.ToString()));
            otherWindow.Focus();
        }

        private void showPossibleWindows(object sender, MouseEventArgs e)
        {
            goToAnotherWindowMenuItem.Items.Clear();
            foreach (Window window in Application.Current.Windows.OfType<Window>().Where(wndw => wndw.Title.Length >= 1))
            {
                MenuItem newMenuItem = new MenuItem();
                newMenuItem.Header = window.Title;
                goToAnotherWindowMenuItem.Items.Add(newMenuItem);
                newMenuItem.Click += goToAnotherWindow;
            }
        }

        private void TTS(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(fontWeightBolder.Text);
        }

        private void grammaticCheck(object sender, RoutedEventArgs e)
        {
            SpellCheck.SetIsEnabled(fontWeightBolder, true);
        }

        private void screenCaptureHandler(object sender, RoutedEventArgs e)
        {
            Bitmap bitmap;

            bitmap = new Bitmap((int)SystemParameters.PrimaryScreenWidth, (int)SystemParameters.PrimaryScreenHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            }
            IntPtr handle = IntPtr.Zero;
            try
            {
                handle = bitmap.GetHbitmap();
                System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                img.Source = Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
                page.Children.Add(img);
                page.Children[lineCursor].Focus();
                lineCursor++;
                Canvas.SetTop(img, page.Children.Count * 35);
                Canvas.SetLeft(img, 50);
                
                // сохранение в файл не нужно
                //bitmap.Save("C:\\officewaredocuments\\captures\\1.jpg");

            }
            catch (Exception)
            {

            }
        }

        private void createPageHandler(object sender, RoutedEventArgs e)
        {
            createNewPage();
        }

        public void createNewPage() {

            Canvas newPage = new Canvas();
            newPage.Width = 540;
            newPage.Height = 650;
            Thickness margins = new Thickness();
            margins.Top = 25;
            newPage.Margin = margins;
            pages.Children.Add(newPage);
            Canvas.SetTop(newPage, pages.Children.Count - 1 * 800);
            Canvas.SetLeft(newPage, 40);
            newPage.Background = System.Windows.Media.Brushes.White;
            page = newPage;
            TextBox textBox = new TextBox();
            textBox.Background = System.Windows.Media.Brushes.Transparent;
            newPage.Children.Add(textBox);
            Canvas.SetTop(textBox, 25);
            Canvas.SetLeft(textBox, 50);
            textBox.Width = 450;
            textBox.BorderThickness = new Thickness(0);
            textBox.MaxLines = 1;
            textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
            textBox.Focus();
            fontWeightBolder = textBox;
            textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
            textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
            textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
            lineCursor = 1;
            backdrop.Height += newPage.Height;

        }

        private void videoFromInternerHandler(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вставка видео", "Введите URL-адресс для видео из интернета", MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK:
                    MediaElement mediaElement = new MediaElement();
                    lineCursor++;
                    page.Children.Add(mediaElement);
                    mediaElement.Width = 200;
                    mediaElement.Height = 200;

                    //ниже ссылка не работает возможно не работает https
                    //mediaElement.Source = new Uri("https://r2---sn-4g5e6nzl.googlevideo.com/videoplayback?expire=1634501533&ei=PS9sYZa8F4TsW_mVksAJ&ip=5.154.174.53&id=o-ADtYJdmhuKQ3OC8BWFECJous-wC31ZZmjE9HSlTCj5cI&itag=243&aitags=133%2C134%2C135%2C136%2C137%2C160%2C242%2C243%2C244%2C247%2C248%2C271%2C278%2C313&source=youtube&requiressl=yes&vprv=1&mime=video%2Fwebm&ns=7e2yGJwl6ElunVoaQVoYOcAG&gir=yes&clen=8100960&dur=471.203&lmt=1626169534952244&keepalive=yes&fexp=24001373,24007246&c=WEB&txp=5316224&n=cTsn60Hl9d6kmXD6Z&sparams=expire%2Cei%2Cip%2Cid%2Caitags%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cns%2Cgir%2Cclen%2Cdur%2Clmt&sig=AOq0QJ8wRgIhAJEDcfHKdDqBfnjYXs34S06pyp2aSQdWT_QFsW7T-zC1AiEA6jf3NJ7BcK9zUJ27LkGns0mSYi1ugPx2y_mR_pTOFm4%3D&redirect_counter=1&cm2rm=sn-apnl7l&req_id=31a9c7e0777ca3ee&cms_redirect=yes&mh=23&mip=178.167.29.8&mm=34&mn=sn-4g5e6nzl&ms=ltu&mt=1634479483&mv=m&mvi=2&pl=20&lsparams=mh,mip,mm,mn,ms,mv,mvi,pl&lsig=AG3C_xAwRQIgVQkZgvHBKQeHxSYjesB3EOI4dViXfUHlnSUUpubzn-wCIQDYb_EqktWDHkgMmCXHOmF_744w9KBNvaFnSIGGlD9FdA%3D%3D");
                    //ниже ссылка работает
                    mediaElement.Source = new Uri("file:///C:/Users/%D0%A1%D0%95%D0%A0%D0%93%D0%95%D0%99/Documents/Bandicam/metaplatform(activeTab).mp4");
                    
                    Canvas.SetTop(mediaElement, page.Children.Count * 35);
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }

        }

        private void createLinkHandler(object sender, RoutedEventArgs e)
        {
        /*
            гиперссылки возможно работаю только с TextBlock, наверное нужно
            переделать все тексты с TextBox на TextBlock
            TextBlock textBlock = new TextBlock();
            textBlock.Width = 450;
            page.Children.Add(textBlock);

            page.Children[lineCursor].Focus();
            lineCursor++;
            Canvas.SetTop(textBlock, page.Children.Count * 35);
            Canvas.SetLeft(textBlock, 50);
            fontWeightBolder = (TextBlock)textBlock;
            textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
            textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
            textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
        */
        }

        private void textFromFileHandler(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            bool? res = ofd.ShowDialog();
            if (res != false)
            {
                Stream myStream;
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string file_name = ofd.FileName;
                    string file_text = File.ReadAllText(file_name);
                    
                    TextBox textBox = new TextBox();
                    textBox.Background = System.Windows.Media.Brushes.Transparent;
                    textBox.Width = 450;
                    textBox.BorderThickness = new Thickness(0);
                    textBox.MaxLines = 1;
                    textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                    page.Children.Add(textBox);
                    page.Children[lineCursor].Focus();
                    lineCursor++;
                    Canvas.SetTop(textBox, page.Children.Count * 35);
                    Canvas.SetLeft(textBox, 50);
                    fontWeightBolder = textBox;
                    textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                    textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                    textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);

                    fontWeightBolder.Text = file_text;
                }
            }
        }

        private void colorOfPageHandler(object sender, RoutedEventArgs e)
        {
            /*Dialogs.ColorDialog tableDialog = new Dialogs.ColorDialog();
            tableDialog.Show();*/
        }


        private void colorOfPageHandler(object sender, Syncfusion.Windows.Tools.Controls.SelectedBrushChangedEventArgs e)
        {
            page.Background = e.NewBrush;
        }

        private void noneIntervalBetweenParagraphsHandler(object sender, RoutedEventArgs e)
        {
            foreach (UIElement paragraph in page.Children)
            {
                TextBlock.SetLineHeight((TextBox)paragraph, (double)0);
            }
        }

        private void compressedIntervalBetweenParagraphsHandler(object sender, RoutedEventArgs e)
        {
            foreach (UIElement paragraph in page.Children)
            {
                TextBlock.SetLineHeight((TextBox)paragraph, (double)25);
            }
        }

        private void narrowIntervalBetweenParagraphsHandler(object sender, RoutedEventArgs e)
        {
            foreach (UIElement paragraph in page.Children)
            {
                TextBlock.SetLineHeight((TextBox)paragraph, (double)15);
            }
        }

        private void looseIntervalBetweenParagraphsHandler(object sender, RoutedEventArgs e)
        {
            foreach (UIElement paragraph in page.Children)
            {
                TextBlock.SetLineHeight((TextBox)paragraph, (double)5);
            }
        }

        private void freeIntervalBetweenParagraphsHandler(object sender, RoutedEventArgs e)
        {
            foreach (UIElement paragraph in page.Children)
            {
                TextBlock.SetLineHeight((TextBox)paragraph, (double)15);
            }
        }

        private void doubleIntervalBetweenParagraphsHandler(object sender, RoutedEventArgs e)
        {
            foreach (UIElement paragraph in page.Children)
            {
                TextBlock.SetLineHeight((TextBox)paragraph, (double)50);
            }
        }

        private void toggleAreaOfSelection(object sender, RoutedEventArgs e)
        {
            if (areaOfSelection.Visibility == Visibility.Collapsed)
            {
                areaOfSelection.Visibility = Visibility.Visible;
            } else if (areaOfSelection.Visibility == Visibility.Visible)
            {
                areaOfSelection.Visibility = Visibility.Collapsed;
            }
        }

        private void moveAreaOfSelectionHandler(object sender, RoutedEventArgs e)
        {
            areaOfSelection.Cursor = Cursors.SizeAll;
        }
    }
}