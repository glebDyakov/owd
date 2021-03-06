
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

        public int maxCharsInParagraph = 50;
        public Style dropShadowScrollViewerStyle = null;
        public TextBox textBox = null;
        public int lineCursor = 1;
        public bool numberOfStrokes = false;
        public double initialWidth = 0;
        public double initialHeight = 0;
        public int pageCursor = 1;
        public int countLinesInPage = 16;
        public int currentMargins = 50;
        public int currentWidth = 450;
        public UIElement currentControl;
        public int wrapHeight = 500;
        public bool showNumberOfPage = true;
        public SpeechSynthesizer speechSynthesizer;
        public MediaPlayer audio;

        public MainWindow()
        {
            InitializeComponent();

            initialWidth = page.Width;
            initialHeight = page.Height;

            //fontWeightBolder.Focus();
            currentControl = fontWeightBolder;
            ((TextBox)currentControl).Focus();

            speechSynthesizer = new SpeechSynthesizer();
            audio = new MediaPlayer();

        }

        private void fontWeightBolderHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontWeight = FontWeights.Bold;
            ((TextBox)currentControl).FontWeight = FontWeights.Bold;
        }

        private void fontStyleItalicHandler(object sender, RoutedEventArgs e)
        {
            ((TextBox)currentControl).FontStyle = FontStyles.Italic;
            //fontWeightBolder.FontStyle = FontStyles.Italic;
        }

        private void textDecorationUnderlineHandler(object sender, RoutedEventArgs e)
        {
            ((TextBox)currentControl).TextDecorations = TextDecorations.Underline;
            //fontWeightBolder.TextDecorations = TextDecorations.Underline;
        }

        private void textDecorationStrikethroughHandler(object sender, RoutedEventArgs e)
        {
            ((TextBox)currentControl).TextDecorations = TextDecorations.Strikethrough;
            //fontWeightBolder.TextDecorations = TextDecorations.Strikethrough;
        }

        private void textDecorationBackgroundHandler(object sender, RoutedEventArgs e)
        {
            ((TextBox)currentControl).Background = System.Windows.Media.Brushes.Red;
            //fontWeightBolder.Background = System.Windows.Media.Brushes.Red;
        }

        private void textDecorationForegroundHandler(object sender, RoutedEventArgs e)
        {
            ((TextBox)currentControl).Foreground = System.Windows.Media.Brushes.Red;
            //fontWeightBolder.Foreground = System.Windows.Media.Brushes.Red;
        }

        private void fontSizeHandler(object sender, RoutedEventArgs e)
        {
            ((TextBox)currentControl).FontSize = 34;
            //fontWeightBolder.FontSize = 34;
        }

        private void upperCaseHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text = fontWeightBolder.Text.ToUpper();

            
            //if (fontWeightBolder.FontSize < 72) {
            if (((TextBox)currentControl).FontSize < 72) {
                ((TextBox)currentControl).FontSize += 1;
                //fontWeightBolder.FontSize += 1;
            }
        }

        private void lowerCaseHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text = fontWeightBolder.Text.ToLower();

            //if (fontWeightBolder.FontSize > 10)
            if (((TextBox)currentControl).FontSize > 10)
            {
                //fontWeightBolder.FontSize -= 1;
                ((TextBox)currentControl).FontSize -= 1;
            }
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

            //fontWeightBolder.Resources.Add(typeof(ScrollViewer), dropShadowScrollViewerStyle);
            ((TextBox)currentControl).Resources.Add(typeof(ScrollViewer), dropShadowScrollViewerStyle);

        }

        private void textSubscriptHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Typography.Variants = FontVariants.Subscript;
            ((TextBox)currentControl).Typography.Variants = FontVariants.Subscript;
        }

        private void textSuperscriptHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Typography.Variants = FontVariants.Superscript;
            ((TextBox)currentControl).Typography.Variants = FontVariants.Superscript;
        }

        private void clearStylesHandler(object sender, RoutedEventArgs e)
        {
            /*fontWeightBolder.Typography.Variants = FontVariants.Normal;
            fontWeightBolder.FontSize = 14;
            fontWeightBolder.FontWeight = FontWeights.Normal;
            fontWeightBolder.FontStyle = FontStyles.Normal;
            fontWeightBolder.TextDecorations = null;
            fontWeightBolder.Background = System.Windows.Media.Brushes.Transparent;
            fontWeightBolder.Foreground = System.Windows.Media.Brushes.Black;
            fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            fontWeightBolder.Resources.Clear();*/

            ((TextBox)currentControl).Typography.Variants = FontVariants.Normal;
            ((TextBox)currentControl).FontSize = 14;
            ((TextBox)currentControl).FontWeight = FontWeights.Normal;
            ((TextBox)currentControl).FontStyle = FontStyles.Normal;
            ((TextBox)currentControl).TextDecorations = null;
            ((TextBox)currentControl).Background = System.Windows.Media.Brushes.Transparent;
            ((TextBox)currentControl).Foreground = System.Windows.Media.Brushes.Black;
            ((TextBox)currentControl).FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            ((TextBox)currentControl).Resources.Clear();
            
        }

        private void fontFamilyChangeToTimesNewRoman(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            ((TextBox)currentControl).FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
        }

        private void fontFamilyChangeToArial(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Arial");
            ((TextBox)currentControl).FontFamily = new System.Windows.Media.FontFamily("Arial");
            
        }

        private void fontFamilyChangeToCalibri(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Calibri");
            ((TextBox)currentControl).FontFamily = new System.Windows.Media.FontFamily("Calibri");
            
        }

        private void fontFamilyChangeToVerdana(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontFamily = new System.Windows.Media.FontFamily("Verdana");
            ((TextBox)currentControl).FontFamily = new System.Windows.Media.FontFamily("Verdana");
            
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

                    //fontWeightBolder.Text = file_text;
                    ((TextBox)currentControl).Text = file_text;
                    
                }
            }
        }

        private void insertSpecialCharEuro(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "€";
            ((TextBox)currentControl).Text += "€";
        }

        private void insertSpecialCharPoud(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "£";
            ((TextBox)currentControl).Text += "£";
            
        }

        private void insertSpecialCharYen(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "¥";
            ((TextBox)currentControl).Text += "¥";
            
        }

        private void insertSpecialCharCopyright(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "©";
            ((TextBox)currentControl).Text += "©";
            
        }

        private void insertSpecialCharRegistered(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "®";
            ((TextBox)currentControl).Text += "®";
            
        }
        private void insertSpecialCharTM(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "™";
            ((TextBox)currentControl).Text += "™";
            
        }
        private void insertSpecialCharPlusOrMinus(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "±";
            ((TextBox)currentControl).Text += "±";
            
        }
        private void insertSpecialCharNotEqual(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "≠";
            ((TextBox)currentControl).Text += "≠";
            
        }
        private void insertSpecialCharAll(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "∑";
            ((TextBox)currentControl).Text += "∑";
            
        }
        private void insertSpecialCharBeta(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "β";
            ((TextBox)currentControl).Text += "β";
            
        }
        private void insertSpecialCharPi(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "π";
            ((TextBox)currentControl).Text += "π";
            
        }
        private void insertSpecialCharInfinity(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "∞";
            ((TextBox)currentControl).Text += "∞";
            
        }
        private void insertSpecialCharLessAndEqual(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "≤";
            ((TextBox)currentControl).Text += "≤";
            
        }
        private void insertSpecialCharGratherAndEqual(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "≥";
            ((TextBox)currentControl).Text += "≥";
            
        }
        private void insertSpecialCharAlpha(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "α";
            ((TextBox)currentControl).Text += "α";
            
        }
        private void insertSpecialCharU(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "µ";
            ((TextBox)currentControl).Text += "µ";
            
        }
        private void insertSpecialCharFrequency(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "Ω";
            ((TextBox)currentControl).Text += "Ω";
            
        }
        private void insertSpecialCharMultiply(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "×";
            ((TextBox)currentControl).Text += "×";
            
        }
        private void insertSpecialCharDivide(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "÷";
            ((TextBox)currentControl).Text += "÷";
            
        }
        private void insertSpecialCharArrow(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.Text += "↑";
            ((TextBox)currentControl).Text += "↑";
            
        }

        private void openSettings(object sender, RoutedEventArgs e)
        {
            Dialogs.Settings settingsDialog = new Dialogs.Settings();
            settingsDialog.Show();
        }

        private void alignLeftHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Left;
            ((TextBox)currentControl).HorizontalAlignment = HorizontalAlignment.Left;
            
        }

        private void alignCenterHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Center;
            ((TextBox)currentControl).HorizontalAlignment = HorizontalAlignment.Center;
            
        }
        private void alignRightHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Right;
            ((TextBox)currentControl).HorizontalAlignment = HorizontalAlignment.Right;
            
        }
        private void alignJustifyHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.HorizontalAlignment = HorizontalAlignment.Stretch;
            ((TextBox)currentControl).HorizontalAlignment = HorizontalAlignment.Stretch;
        }

        private void intervalHandler(object sender, RoutedEventArgs e)
        {
            //TextBlock.SetLineHeight(fontWeightBolder, 25);
            TextBlock.SetLineHeight(((TextBox)currentControl), 25);
        }

        private void allBordersHandler(object sender, RoutedEventArgs e)
        {
            ((TextBox)currentControl).BorderThickness = new Thickness(5.0);
            //fontWeightBolder.BorderThickness = new Thickness(5.0);
        }

        private void noneBordersHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.BorderThickness = new Thickness(0);
            ((TextBox)currentControl).BorderThickness = new Thickness(0);
        }

        private void upBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Top = 5;

            //fontWeightBolder.BorderThickness = border;
            ((TextBox)currentControl).BorderThickness = border;

        }

        private void downBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Bottom = 5;

            //fontWeightBolder.BorderThickness = border;
            ((TextBox)currentControl).BorderThickness = border;

        }

        private void leftBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Left = 5;

            //fontWeightBolder.BorderThickness = border;
            ((TextBox)currentControl).BorderThickness = border;
            
        }

        private void rightBorderHandler(object sender, RoutedEventArgs e)
        {
            Thickness border = new Thickness();
            border.Right = 5;

            //fontWeightBolder.BorderThickness = border;
            ((TextBox)currentControl).BorderThickness = border;
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
            Dialogs.SortDialog sortDialog = new Dialogs.SortDialog();
            sortDialog.Show();
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
            if (((TextBox)currentControl).Text.Length >= maxCharsInParagraph && lineCursor == page.Children.Count)
            {

                TextBox textBox = new TextBox();
                StackPanel paragraph = new StackPanel();
                paragraph.Orientation = Orientation.Horizontal;
                TextBox strokeNumber = new TextBox();
                strokeNumber.BorderThickness = new Thickness();
                strokeNumber.Width = 50;
                strokeNumber.Text = (lineCursor + 1).ToString();
                paragraph.Children.Add(strokeNumber);
                paragraph.Children.Add(textBox);
                page.Children.Add(paragraph);
                Canvas.SetLeft(paragraph, currentMargins);
                Canvas.SetTop(paragraph, page.Children.Count * 35);
                
                textBox.AcceptsTab = false;
                textBox.IsTabStop = true;
                //textBox.TabIndex = 9999;
                textBox.Background = System.Windows.Media.Brushes.Transparent;
                textBox.Width = currentWidth;
                textBox.BorderThickness = new Thickness(0);
                textBox.MaxLines = 1;
                textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                ContextMenu contextMenu = new ContextMenu();
                MenuItem cutMenuItem = new MenuItem();
                cutMenuItem.Header = "Вырезать";
                contextMenu.Items.Add(cutMenuItem);
                cutMenuItem.Click += goToAnotherWindow;
                MenuItem copyMenuItem = new MenuItem();
                copyMenuItem.Header = "Копировать";
                contextMenu.Items.Add(copyMenuItem);
                copyMenuItem.Click += goToAnotherWindow;
                MenuItem insertMenuItem = new MenuItem();
                insertMenuItem.Header = "Вставить";
                contextMenu.Items.Add(insertMenuItem);
                insertMenuItem.Click += goToAnotherWindow;
                MenuItem fontMenuItem = new MenuItem();
                fontMenuItem.Header = "Шрифт";
                contextMenu.Items.Add(fontMenuItem);
                fontMenuItem.Click += goToAnotherWindow;
                MenuItem paragraphMenuItem = new MenuItem();
                paragraphMenuItem.Header = "Абзац";
                contextMenu.Items.Add(paragraphMenuItem);
                paragraphMenuItem.Click += openParagaphDialog;
                MenuItem searchMenuItem = new MenuItem();
                searchMenuItem.Header = "Поиск";
                contextMenu.Items.Add(searchMenuItem);
                searchMenuItem.Click += goToAnotherWindow;
                MenuItem synonymsMenuItem = new MenuItem();
                synonymsMenuItem.Header = "Вырезать";
                contextMenu.Items.Add(synonymsMenuItem);
                synonymsMenuItem.Click += goToAnotherWindow;
                MenuItem translateMenuItem = new MenuItem();
                translateMenuItem.Header = "Перевести";
                contextMenu.Items.Add(translateMenuItem);
                translateMenuItem.Click += goToAnotherWindow;
                MenuItem referenceMenuItem = new MenuItem();
                referenceMenuItem.Header = "Ссылка";
                contextMenu.Items.Add(referenceMenuItem);
                referenceMenuItem.Click += goToAnotherWindow;
                MenuItem createNoteMenuItem = new MenuItem();
                createNoteMenuItem.Header = "Создать примечание";
                contextMenu.Items.Add(createNoteMenuItem);
                createNoteMenuItem.Click += goToAnotherWindow;
                textBox.ContextMenu = contextMenu;

                ((StackPanel)page.Children[lineCursor]).Children[1].Focus();
                lineCursor++;
                Canvas.SetTop(textBox, page.Children.Count * 35);
                Canvas.SetLeft(textBox, currentMargins);

                //fontWeightBolder = textBox;
                currentControl = textBox;

                textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);

            }
            else if (((TextBox)currentControl).Text.Length >= maxCharsInParagraph && ((TextBox)currentControl).SelectionStart == maxCharsInParagraph && lineCursor < page.Children.Count)
            {
                lineCursor++;

                StackPanel paragraph = ((StackPanel)page.Children[lineCursor - 1]);
                ((TextBox)paragraph.Children[1]).Focus();

                //fontWeightBolder = ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]);
                currentControl = ((UIElement)((StackPanel)page.Children[lineCursor - 1]).Children[1]);

                //fontWeightBolder.SelectionStart = 0;
                ((TextBox)currentControl).SelectionStart = 0;

            }
            //else if (fontWeightBolder.Text.Length >= maxCharsInParagraph && fontWeightBolder.SelectionStart < fontWeightBolder.Text.Length && lineCursor < page.Children.Count)
            else if (((TextBox)currentControl).Text.Length >= maxCharsInParagraph && ((TextBox)currentControl).SelectionStart < ((TextBox)currentControl).Text.Length && lineCursor < page.Children.Count)
            {
                //if (((TextBox)page.Children[lineCursor]).Text.Length == maxCharsInParagraph) {
                if (((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]).Text.Length == maxCharsInParagraph) {

                    TextBox textBox = new TextBox();
                    textBox.AcceptsTab = false;
                    textBox.IsTabStop = true;
                    //textBox.TabIndex = 9999;
                    textBox.Background = System.Windows.Media.Brushes.Transparent;
                    textBox.Width = currentWidth;
                    textBox.BorderThickness = new Thickness(0);
                    textBox.MaxLines = 1;
                    textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                    ContextMenu contextMenu = new ContextMenu();
                    MenuItem cutMenuItem = new MenuItem();
                    cutMenuItem.Header = "Вырезать";
                    contextMenu.Items.Add(cutMenuItem);
                    cutMenuItem.Click += goToAnotherWindow;
                    MenuItem copyMenuItem = new MenuItem();
                    copyMenuItem.Header = "Копировать";
                    contextMenu.Items.Add(copyMenuItem);
                    copyMenuItem.Click += goToAnotherWindow;
                    MenuItem insertMenuItem = new MenuItem();
                    insertMenuItem.Header = "Вставить";
                    contextMenu.Items.Add(insertMenuItem);
                    insertMenuItem.Click += goToAnotherWindow;
                    MenuItem fontMenuItem = new MenuItem();
                    fontMenuItem.Header = "Шрифт";
                    contextMenu.Items.Add(fontMenuItem);
                    fontMenuItem.Click += goToAnotherWindow;
                    MenuItem paragraphMenuItem = new MenuItem();
                    paragraphMenuItem.Header = "Абзац";
                    contextMenu.Items.Add(paragraphMenuItem);
                    paragraphMenuItem.Click += openParagaphDialog;
                    MenuItem searchMenuItem = new MenuItem();
                    searchMenuItem.Header = "Поиск";
                    contextMenu.Items.Add(searchMenuItem);
                    searchMenuItem.Click += goToAnotherWindow;
                    MenuItem synonymsMenuItem = new MenuItem();
                    synonymsMenuItem.Header = "Вырезать";
                    contextMenu.Items.Add(synonymsMenuItem);
                    synonymsMenuItem.Click += goToAnotherWindow;
                    MenuItem translateMenuItem = new MenuItem();
                    translateMenuItem.Header = "Перевести";
                    contextMenu.Items.Add(translateMenuItem);
                    translateMenuItem.Click += goToAnotherWindow;
                    MenuItem referenceMenuItem = new MenuItem();
                    referenceMenuItem.Header = "Ссылка";
                    contextMenu.Items.Add(referenceMenuItem);
                    referenceMenuItem.Click += goToAnotherWindow;
                    MenuItem createNoteMenuItem = new MenuItem();
                    createNoteMenuItem.Header = "Создать примечание";
                    contextMenu.Items.Add(createNoteMenuItem);
                    createNoteMenuItem.Click += goToAnotherWindow;
                    textBox.ContextMenu = contextMenu;

                    page.Children.Insert(lineCursor, textBox);
                    Canvas.SetTop(textBox, (lineCursor) * 35);
                    Canvas.SetLeft(textBox, currentMargins);
                    textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                    textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                    textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
                    int paragraphsCursor = 0;
                    
                    //foreach (TextBox paragraph in page.Children)
                    foreach (UIElement paragraph in page.Children)
                    {
                        paragraphsCursor++;
                        if (paragraphsCursor > lineCursor)
                        {
                            Canvas.SetTop(paragraph, Canvas.GetTop(paragraph) + 35);
                        }
                    }
                }

                //int tempCursotPosition = ((TextBox)page.Children[lineCursor - 1]).SelectionStart;
                int tempCursotPosition = ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]).SelectionStart;

                
                //((TextBox)page.Children[lineCursor]).Text = ((TextBox)page.Children[lineCursor]).Text.Insert(0, fontWeightBolder.Text.Substring(fontWeightBolder.Text.Length - 1, 1));
                ((TextBox)page.Children[lineCursor]).Text = ((TextBox)page.Children[lineCursor]).Text.Insert(0, ((TextBox)currentControl).Text.Substring(((TextBox)currentControl).Text.Length - 1, 1));

                //((TextBox)page.Children[lineCursor - 1]).Text = ((TextBox)page.Children[lineCursor - 1]).Text.Substring(0, ((TextBox)page.Children[lineCursor - 1]).Text.Length - 1);
                ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]).Text = ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]).Text.Substring(0, ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]).Text.Length - 1);

                //((TextBox)page.Children[lineCursor - 1]).SelectionStart = tempCursotPosition;
                ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]).SelectionStart = tempCursotPosition;

            }

        }

        private void changeLineFromCursor(object sender, MouseButtonEventArgs e)
        {

            currentControl = (UIElement)sender;
            if (sender is TextBox)
            {
                pageCursor = pages.Children.IndexOf((UIElement)((TextBox)currentControl).Parent);
                StackPanel paragraph = ((StackPanel)((TextBox)currentControl).Parent);
                page = (Canvas)pages.Children[pages.Children.IndexOf((UIElement)paragraph.Parent)];
                lineCursor = page.Children.IndexOf((UIElement)((TextBox)currentControl).Parent) + 1;
            }
            else if (sender is System.Windows.Controls.Image)
            {
                pageCursor = pages.Children.IndexOf((UIElement)((System.Windows.Controls.Image)currentControl).Parent);
                StackPanel paragraph = ((StackPanel)((System.Windows.Controls.Image)currentControl).Parent);
                page = (Canvas)pages.Children[pages.Children.IndexOf((UIElement)paragraph.Parent)];
                lineCursor = page.Children.IndexOf((UIElement)((System.Windows.Controls.Image)currentControl).Parent) + 1;
            }

            if (sender is TextBox || sender is System.Windows.Controls.Image)
            {
                foreach (StackPanel container in page.Children)
                {
                    container.Background = System.Windows.Media.Brushes.Transparent;
                }
                if (sender is TextBox)
                {
                    ((StackPanel)((TextBox)sender).Parent).Background = System.Windows.Media.Brushes.Aquamarine;
                }
                else if (sender is System.Windows.Controls.Image)
                {
                    ((StackPanel)((System.Windows.Controls.Image)sender).Parent).Background = System.Windows.Media.Brushes.Aquamarine;
                }
            }

            /*if (sender is TextBox || sender is System.Windows.Controls.Image)
            {
                foreach (StackPanel container in page.Children)
                {
                    container.Background = System.Windows.Media.Brushes.Transparent;
                }
                if (sender is TextBox)
                {
                    ((StackPanel)((TextBox)sender).Parent).Background = System.Windows.Media.Brushes.Aquamarine;
                }
                else if (sender is System.Windows.Controls.Image)
                {
                    ((StackPanel)((System.Windows.Controls.Image)sender).Parent).Background = System.Windows.Media.Brushes.Aquamarine;
                }
            }*/


        }

        private void specialInputHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                if (((StackPanel)page.Children[lineCursor - 1]).Children[1] is TextBox)
                {
                    if (((TextBox)currentControl).SelectionStart <= 0 && lineCursor >= 2)
                    {
                        lineCursor--;
                        ((StackPanel)page.Children[lineCursor - 1]).Children[1].Focus();

                        if (((StackPanel)page.Children[lineCursor - 1]).Children[1] is System.Windows.Controls.Image)
                        {
                            currentControl = ((System.Windows.Controls.Image)((StackPanel)page.Children[lineCursor - 1]).Children[1]);
                        }
                        else if (((StackPanel)page.Children[lineCursor - 1]).Children[1] is TextBox)
                        {
                            currentControl = ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]);
                        }

                        page.Children.Remove((StackPanel)page.Children[lineCursor]);

                        int paragraphCursor = 0;
                        foreach (UIElement paragraph in page.Children)
                        {
                            paragraphCursor++;
                            if (paragraphCursor > lineCursor)
                            {
                                Canvas.SetTop(paragraph, Canvas.GetTop(paragraph) - 35);
                            }
                        }

                        /*foreach (StackPanel paragraphGroup in page.Children)
                        {
                            foreach (UIElement paragraph in paragraphGroup.Children)
                            {
                                paragraphCursor++;
                                if (paragraphCursor > lineCursor)
                                {
                                    Canvas.SetTop(paragraph, Canvas.GetTop(paragraph) - 35);
                                }
                            }
                        }*/

                        foreach (UIElement child in page.Children)
                        {
                            if (page.Children.IndexOf(child) >= lineCursor - 1)
                            {
                                ((TextBox)((StackPanel)child).Children[0]).Text = (page.Children.IndexOf(child) + 1).ToString();
                            }
                        }

                        e.Handled = true;
                    }
                    else if (((TextBox)currentControl).SelectionStart <= 0 && lineCursor == 1 && pages.Children.Count >= 2)
                    {
                        if (page.Children.Count == 1)
                        {
                            pages.Children.Remove((Canvas)pages.Children[pages.Children.Count - 1]);

                            page = (Canvas)pages.Children[pages.Children.Count - 1];

                            currentControl = ((UIElement)((StackPanel)page.Children[page.Children.Count - 1]).Children[1]);

                            ((StackPanel)page.Children[page.Children.Count - 1]).Children[1].Focus();
                            lineCursor = page.Children.Count;
                            backdrop.Height -= 650;
                        }
                        else if (page.Children.Count >= 2) {
                            page = ((Canvas)pages.Children[pages.Children.IndexOf(page) - 1]);
                            Keyboard.ClearFocus();
                            currentControl = ((StackPanel)page.Children[page.Children.Count - 1]).Children[1];
                            lineCursor = page.Children.Count;
                            currentControl.Focus();
                        }
                    }
                }
                else if (((StackPanel)page.Children[lineCursor - 1]).Children[1] is System.Windows.Controls.Image)
                {
                    lineCursor--;
                    ((StackPanel)page.Children[lineCursor - 1]).Children[1].Focus();
                    if (((StackPanel)page.Children[lineCursor - 1]).Children[1] is System.Windows.Controls.Image)
                    {
                        currentControl = ((System.Windows.Controls.Image)((StackPanel)page.Children[lineCursor - 1]).Children[1]);
                    }
                    else if (((StackPanel)page.Children[lineCursor - 1]).Children[1] is TextBox)
                    {
                        currentControl = ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]);
                    }

                    page.Children.Remove((StackPanel)page.Children[lineCursor]);

                    int paragraphCursor = 0;
                    foreach (UIElement paragraph in page.Children)
                    {
                        paragraphCursor++;
                        if (paragraphCursor > lineCursor)
                        {
                            Canvas.SetTop(paragraph, Canvas.GetTop(paragraph) - 150);
                        }
                    }

                    foreach (UIElement child in page.Children)
                    {
                        if (page.Children.IndexOf(child) >= lineCursor - 1)
                        {
                            ((TextBox)((StackPanel)child).Children[0]).Text = (page.Children.IndexOf(child) + 1).ToString();
                        }
                    }

                    currentControl = ((UIElement)((StackPanel)page.Children[page.Children.Count - 1]).Children[1]);

                    e.Handled = true;

                }

            }
            else if (e.Key == Key.Enter)
            {
                if (lineCursor == page.Children.Count)
                {
                    if (lineCursor <= countLinesInPage)
                    {
                        TextBox textBox = new TextBox();
                        StackPanel paragraph = new StackPanel();
                        paragraph.Orientation = Orientation.Horizontal;
                        TextBox strokeNumber = new TextBox();
                        strokeNumber.BorderThickness = new Thickness();
                        strokeNumber.Width = 50;
                        //strokeNumber.Text = ((pages.Children.Count - 1) * countLinesInPage + (lineCursor + 1)).ToString();
                        if (pages.Children.Count <= 1)
                        {
                            strokeNumber.Text = ((pages.Children.Count - 1) * countLinesInPage + (lineCursor + 1)).ToString();
                        }
                        else if (pages.Children.Count >= 3)
                        {
                            strokeNumber.Text = ((pages.Children.Count - 1) * countLinesInPage + (lineCursor + 3)).ToString();
                        }
                        else if (pages.Children.Count >= 2)
                        {
                            strokeNumber.Text = ((pages.Children.Count - 1) * countLinesInPage + (lineCursor + 2)).ToString();
                        }
                        paragraph.Children.Add(strokeNumber);
                        paragraph.Children.Add(textBox);
                        page.Children.Add(paragraph);

                        Canvas.SetLeft(paragraph, currentMargins);
                        
                        Canvas.SetTop(paragraph, page.Children.Count * 35);

                        textBox.AcceptsTab = false;
                        textBox.IsTabStop = true;
                        //textBox.TabIndex = 9999;
                        textBox.Background = System.Windows.Media.Brushes.Transparent;
                        textBox.Width = currentWidth;
                        textBox.BorderThickness = new Thickness(0);
                        textBox.MaxLines = 1;
                        textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                        ContextMenu contextMenu = new ContextMenu();
                        MenuItem cutMenuItem = new MenuItem();
                        cutMenuItem.Header = "Вырезать";
                        contextMenu.Items.Add(cutMenuItem);
                        cutMenuItem.Click += goToAnotherWindow;
                        MenuItem copyMenuItem = new MenuItem();
                        copyMenuItem.Header = "Копировать";
                        contextMenu.Items.Add(copyMenuItem);
                        copyMenuItem.Click += goToAnotherWindow;
                        MenuItem insertMenuItem = new MenuItem();
                        insertMenuItem.Header = "Вставить";
                        contextMenu.Items.Add(insertMenuItem);
                        insertMenuItem.Click += goToAnotherWindow;
                        MenuItem fontMenuItem = new MenuItem();
                        fontMenuItem.Header = "Шрифт";
                        contextMenu.Items.Add(fontMenuItem);
                        fontMenuItem.Click += goToAnotherWindow;
                        MenuItem paragraphMenuItem = new MenuItem();
                        paragraphMenuItem.Header = "Абзац";
                        contextMenu.Items.Add(paragraphMenuItem);
                        paragraphMenuItem.Click += openParagaphDialog;
                        MenuItem searchMenuItem = new MenuItem();
                        searchMenuItem.Header = "Поиск";
                        contextMenu.Items.Add(searchMenuItem);
                        searchMenuItem.Click += goToAnotherWindow;
                        MenuItem synonymsMenuItem = new MenuItem();
                        synonymsMenuItem.Header = "Вырезать";
                        contextMenu.Items.Add(synonymsMenuItem);
                        synonymsMenuItem.Click += goToAnotherWindow;
                        MenuItem translateMenuItem = new MenuItem();
                        translateMenuItem.Header = "Перевести";
                        contextMenu.Items.Add(translateMenuItem);
                        translateMenuItem.Click += goToAnotherWindow;
                        MenuItem referenceMenuItem = new MenuItem();
                        referenceMenuItem.Header = "Ссылка";
                        contextMenu.Items.Add(referenceMenuItem);
                        referenceMenuItem.Click += goToAnotherWindow;
                        MenuItem createNoteMenuItem = new MenuItem();
                        createNoteMenuItem.Header = "Создать примечание";
                        contextMenu.Items.Add(createNoteMenuItem);
                        createNoteMenuItem.Click += goToAnotherWindow;
                        textBox.ContextMenu = contextMenu;
                        
                        //page.Children.Add(paragraph);

                        ((StackPanel)page.Children[lineCursor]).Children[1].Focus();
                        lineCursor++;
                        Canvas.SetTop(textBox, page.Children.Count * 35);
                        Canvas.SetLeft(textBox, currentMargins);

                        //fontWeightBolder = textBox;
                        currentControl = textBox;

                        textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                        textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                        textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
                        strokeNumber.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);

                    }
                    else
                    {
                        createNewPage("paragraph", null, null, 0);
                    }
                }
                else
                {

                    int totalHeightOfPage = 0;
                    foreach (StackPanel container in page.Children)
                    {
                        if (container.Children[1] is TextBox)
                        {
                            totalHeightOfPage += 35;
                        }
                        else if (container.Children[1] is System.Windows.Controls.Image)
                        {
                            totalHeightOfPage += 150;
                        }
                        else if (container.Children[1] is MediaElement)
                        {
                            totalHeightOfPage += 200;
                        }
                    }
                    if (totalHeightOfPage >= wrapHeight)
                    {
                        foreach (Canvas currentPage in pages.Children) { 
                            foreach(StackPanel paragraph in currentPage.Children)
                            {
                                //if(currentPage.Children.IndexOf(paragraph) + 1 > lineCursor)
                                //{
                                    if (pages.Children.IndexOf(page) == pages.Children.IndexOf(currentPage) && page.Children.Count >= countLinesInPage && currentPage.Children.IndexOf(paragraph) + 1 > lineCursor) {
                                        Canvas nextPage = ((Canvas)pages.Children[pages.Children.IndexOf(page) + 1]);
                                        //page.Children.Remove(paragraph);
                                        TextBox textBox = new TextBox();
                                        StackPanel newParagraph = new StackPanel();
                                        nextPage.Children.Insert(0, newParagraph);
                                        newParagraph.Orientation = Orientation.Horizontal;
                                        TextBox strokeNumber = new TextBox();
                                        strokeNumber.BorderThickness = new Thickness();
                                        strokeNumber.Width = 50;
                                        strokeNumber.Text = (lineCursor + 1).ToString();
                                        newParagraph.Children.Add(strokeNumber);
                                        newParagraph.Children.Add(textBox);
                                        Canvas.SetLeft(newParagraph, currentMargins);
                                        //page.Children.Insert(page.Children.Count - 1, page.Children.IndexOf((()((TextBox)currentControl).Parent)) + 1);
                                        //Canvas.SetTop(paragraph, 35);
                                        Canvas.SetTop(paragraph, 50);
                                    }
                                    else if ((pages.Children.IndexOf(page) < pages.Children.IndexOf(currentPage)) || (pages.Children.IndexOf(page) == pages.Children.IndexOf(currentPage) && currentPage.Children.IndexOf(paragraph) >= lineCursor))
                                    {
                                        Canvas.SetTop(paragraph, Canvas.GetTop(paragraph) + 35);
                                    }
                                }
                            }
                        //}
                        //createNewPage("paragraph", null, null, 0);
                    } 
                    else
                    {
                        TextBox textBox = new TextBox();
                        StackPanel paragraph = new StackPanel();
                        paragraph.Orientation = Orientation.Horizontal;
                        TextBox strokeNumber = new TextBox();
                        strokeNumber.BorderThickness = new Thickness();
                        strokeNumber.Width = 50;
                        strokeNumber.Text = (lineCursor + 1).ToString();
                        paragraph.Children.Add(strokeNumber);
                        paragraph.Children.Add(textBox);
                        //page.Children.Add(paragraph);
                        Canvas.SetLeft(paragraph, currentMargins);

                        int rightImageYCoord = 0;
                        foreach (StackPanel container in page.Children)
                        {
                            if (page.Children.IndexOf(container) < lineCursor)
                            {
                                if (container.Children[1] is TextBox)
                                {
                                    rightImageYCoord += 35;
                                }
                                else if (container.Children[1] is System.Windows.Controls.Image)
                                {
                                    rightImageYCoord += 150;
                                }
                                else if (container.Children[1] is MediaElement)
                                {
                                    rightImageYCoord += 200;
                                }
                            }
                        }

                        Canvas.SetTop(paragraph, rightImageYCoord);

                        //textBox.TabIndex = 9999;
                        textBox.AcceptsTab = false;
                        textBox.IsTabStop = true;
                        textBox.Background = System.Windows.Media.Brushes.Transparent;
                        textBox.Width = currentWidth;
                        textBox.BorderThickness = new Thickness(0);
                        textBox.MaxLines = 1;
                        textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;

                        ContextMenu contextMenu = new ContextMenu();
                        MenuItem cutMenuItem = new MenuItem();
                        cutMenuItem.Header = "Вырезать";
                        contextMenu.Items.Add(cutMenuItem);
                        cutMenuItem.Click += goToAnotherWindow;
                        MenuItem copyMenuItem = new MenuItem();
                        copyMenuItem.Header = "Копировать";
                        contextMenu.Items.Add(copyMenuItem);
                        copyMenuItem.Click += goToAnotherWindow;
                        MenuItem insertMenuItem = new MenuItem();
                        insertMenuItem.Header = "Вставить";
                        contextMenu.Items.Add(insertMenuItem);
                        insertMenuItem.Click += goToAnotherWindow;
                        MenuItem fontMenuItem = new MenuItem();
                        fontMenuItem.Header = "Шрифт";
                        contextMenu.Items.Add(fontMenuItem);
                        fontMenuItem.Click += goToAnotherWindow;
                        MenuItem paragraphMenuItem = new MenuItem();
                        paragraphMenuItem.Header = "Абзац";
                        contextMenu.Items.Add(paragraphMenuItem);
                        paragraphMenuItem.Click += openParagaphDialog;
                        MenuItem searchMenuItem = new MenuItem();
                        searchMenuItem.Header = "Поиск";
                        contextMenu.Items.Add(searchMenuItem);
                        searchMenuItem.Click += goToAnotherWindow;
                        MenuItem synonymsMenuItem = new MenuItem();
                        synonymsMenuItem.Header = "Вырезать";
                        contextMenu.Items.Add(synonymsMenuItem);
                        synonymsMenuItem.Click += goToAnotherWindow;
                        MenuItem translateMenuItem = new MenuItem();
                        translateMenuItem.Header = "Перевести";
                        contextMenu.Items.Add(translateMenuItem);
                        translateMenuItem.Click += goToAnotherWindow;
                        MenuItem referenceMenuItem = new MenuItem();
                        referenceMenuItem.Header = "Ссылка";
                        contextMenu.Items.Add(referenceMenuItem);
                        referenceMenuItem.Click += goToAnotherWindow;
                        MenuItem createNoteMenuItem = new MenuItem();
                        createNoteMenuItem.Header = "Создать примечание";
                        contextMenu.Items.Add(createNoteMenuItem);
                        createNoteMenuItem.Click += goToAnotherWindow;
                        textBox.ContextMenu = contextMenu;

                        int caretIndex = ((TextBox)currentControl).SelectionStart;
                        string caretText = ((TextBox)currentControl).Text.Substring(caretIndex, ((TextBox)currentControl).Text.Length - ((TextBox)currentControl).Text.Substring(0, caretIndex).Length);
                        ((TextBox)currentControl).Text = ((TextBox)currentControl).Text.Substring(0, caretIndex);

                        textBox.Text = caretText;
                        lineCursor++;

                        page.Children.Insert(lineCursor - 1, paragraph);

                        ((StackPanel)page.Children[lineCursor - 1]).Children[1].Focus();
                        foreach (UIElement child in page.Children)
                        {
                            if (page.Children.IndexOf(child) >= lineCursor - 1)
                            {
                                if (((StackPanel)child).Children[1] is TextBox)
                                {
                                    //Canvas.SetTop(child, (page.Children.IndexOf(child) + 1) * 35);
                                    Canvas.SetTop(child, Canvas.GetTop(child) + 35);
                                }
                                else if (((StackPanel)child).Children[1] is System.Windows.Controls.Image)
                                {
                                    Canvas.SetTop(child, Canvas.GetTop(child) + 35);
                                }
                                ((TextBox)((StackPanel)child).Children[0]).Text = (page.Children.IndexOf(child) + 1).ToString();
                            }
                        }
                        Canvas.SetLeft(textBox, currentMargins);

                        currentControl = textBox;

                        textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                        textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                        textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);

                    }

                }
            }
            else if (e.Key == Key.Up)
            {
                if (lineCursor >= 2) {
                    lineCursor--;

                    currentControl = ((UIElement)((StackPanel)page.Children[lineCursor - 1]).Children[1]);

                    Keyboard.ClearFocus();
                    ((StackPanel)page.Children[lineCursor - 1]).Children[1].Focus();
                }
                else if (lineCursor == 1 && pages.Children.IndexOf(page) + 1 >= 2) {
                    Keyboard.ClearFocus();
                    page = ((Canvas)pages.Children[pages.Children.IndexOf(page) - 1]);
                    lineCursor = page.Children.Count;
                    currentControl = ((StackPanel)page.Children[page.Children.Count - 1]).Children[1];
                    currentControl.Focus();
                }
            }
            else if (e.Key == Key.Down)
            {
                if (lineCursor == page.Children.Count && pages.Children.IndexOf(page) + 1 < pages.Children.Count)
                {
                    Keyboard.ClearFocus();
                    page = ((Canvas)pages.Children[pages.Children.IndexOf(page) + 1]);
                    lineCursor = 1;
                    currentControl = ((StackPanel)page.Children[0]).Children[1];
                    currentControl.Focus();
                }
                else if (lineCursor < page.Children.Count)
                {
                    lineCursor++;
                    
                    currentControl = ((UIElement)((StackPanel)page.Children[lineCursor - 1]).Children[1]);

                    Keyboard.ClearFocus();
                    ((StackPanel)page.Children[lineCursor - 1]).Children[1].Focus();
                }

            }
            else if (e.Key == Key.Left)
            {
                if (lineCursor >= 2 && ((TextBox)currentControl).SelectionStart <= 0)
                {
                    lineCursor--;

                    currentControl = ((UIElement)((StackPanel)page.Children[lineCursor - 1]).Children[1]);

                    ((StackPanel)page.Children[lineCursor - 1]).Children[1].Focus();
                }
                else if (lineCursor == 1 && pages.Children.IndexOf(page) + 1 >= 2 && ((TextBox)currentControl).SelectionStart <= 0) { 
                    Keyboard.ClearFocus();
                    page = ((Canvas)pages.Children[pages.Children.IndexOf(page) - 1]);
                    lineCursor = page.Children.Count;
                    currentControl = ((StackPanel)page.Children[page.Children.Count - 1]).Children[1];
                    (currentControl).Focus();
                }
            }
            else if (e.Key == Key.Right)
            {
                if (lineCursor < page.Children.Count && ((TextBox)currentControl).SelectionStart > ((TextBox)currentControl).Text.Length - 1)
                {
                    lineCursor++;

                    //fontWeightBolder = ((TextBox)((StackPanel)page.Children[lineCursor - 1]).Children[1]);
                    currentControl = ((UIElement)((StackPanel)page.Children[lineCursor - 1]).Children[1]);

                    ((StackPanel)page.Children[lineCursor - 1]).Children[1].Focus();
                }
                else if (lineCursor == page.Children.Count && ((TextBox)currentControl).SelectionStart > ((TextBox)currentControl).Text.Length - 1 && pages.Children.IndexOf(page) + 1 < pages.Children.Count)
                {
                    Keyboard.ClearFocus();
                    page = ((Canvas)pages.Children[pages.Children.IndexOf(page) + 1]);
                    lineCursor = 1;
                    currentControl = ((StackPanel)page.Children[0]).Children[1];
                    currentControl.Focus();
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
                    Keyboard.ClearFocus();
                    System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                    int rightImageYCoord = 0;
                    int paragraphsCursor = 0;
                    foreach (StackPanel container in page.Children)
                    {
                        paragraphsCursor++;
                        if (paragraphsCursor <= lineCursor) {
                            if (container.Children[1] is TextBox)
                            {
                                rightImageYCoord += 35;
                            }
                            else if (container.Children[1] is System.Windows.Controls.Image)
                            {
                                rightImageYCoord += 150;
                            }
                            else if (container.Children[1] is MediaElement)
                            {
                                rightImageYCoord += 200;
                            }
                        }
                    }
                    if (rightImageYCoord >= wrapHeight) {
                        createNewPage("img", img, ofd, rightImageYCoord);
                    }
                    else
                    {
                        StackPanel paragraph = new StackPanel();
                        paragraph.Orientation = Orientation.Horizontal;
                        TextBox strokeNumber = new TextBox();
                        strokeNumber.BorderThickness = new Thickness(0);
                        strokeNumber.Width = 50;
                        strokeNumber.Text = (lineCursor + 1).ToString();
                        paragraph.Children.Add(strokeNumber);
                        paragraph.Children.Add(img);
                        
                        //page.Children.Add(paragraph);

                        Canvas.SetLeft(paragraph, currentMargins);
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.UriSource = new Uri(ofd.FileName, UriKind.Absolute);
                        bitmapImage.EndInit();
                        img.Source = bitmapImage;
                        img.Width = 150;
                        img.Height = 150;
                        Canvas.SetTop(paragraph, rightImageYCoord);
                        
                        lineCursor++;

                        /*Canvas.SetTop(img, page.Children.Count * 35);
                        Canvas.SetLeft(img, currentMargins);*/

                        if (lineCursor >= page.Children.Count)
                        {
                            page.Children.Add(paragraph);
                        }
                        else
                        {
                            page.Children.Insert(lineCursor - 1, paragraph);
                        }

                        int elementCursor = 0;
                        speechSynthesizer.Speak(lineCursor.ToString());
                        foreach (StackPanel container in page.Children)
                        {
                            elementCursor++;
                            if (elementCursor > lineCursor)
                            {
                                Canvas.SetTop(container, Canvas.GetTop(container) + 150);
                                
                                ((TextBox)((StackPanel)container).Children[0]).Text = (page.Children.IndexOf(container) + 1).ToString(); 
                            }
                        }

                        Canvas.SetTop(paragraph, Canvas.GetTop(paragraph) + 25);

                        img.Loaded += Img_Loaded;

                        //img.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                        img.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                        img.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
                    }
                    
                }
            }
        }

        private void Img_Loaded(object sender, RoutedEventArgs e)
        {
            ((UIElement)sender).Focus();
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
            foreach (StackPanel paragraph in page.Children) {
                paragraph.Children[0].Visibility = Visibility.Visible;
            }
        }

        private void noneNumberOfStrokes(object sender, RoutedEventArgs e)
        {
            numberOfStrokes = false;
            foreach (StackPanel paragraph in page.Children)
            {
                paragraph.Children[0].Visibility = Visibility.Hidden;
            }
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
            //speechSynthesizer.Speak(fontWeightBolder.Text);
            speechSynthesizer.Speak(((TextBox)currentControl).Text);
        }

        private void grammaticCheck(object sender, RoutedEventArgs e)
        {
            //SpellCheck.SetIsEnabled(fontWeightBolder, true);
            SpellCheck.SetIsEnabled(((TextBox)currentControl), true);
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

                StackPanel paragraph = new StackPanel();
                paragraph.Orientation = Orientation.Horizontal;
                TextBox strokeNumber = new TextBox();
                strokeNumber.Text = (lineCursor + 1).ToString();
                paragraph.Children.Add(strokeNumber);
                paragraph.Children.Add(img);
                page.Children.Add(paragraph);
                Canvas.SetLeft(paragraph, currentMargins);
                Canvas.SetTop(paragraph, page.Children.Count * 35);

                //page.Children.Add(img);
                page.Children.Add(paragraph);

                ((StackPanel)page.Children[lineCursor]).Children[1].Focus();
                lineCursor++;
                Canvas.SetTop(img, page.Children.Count * 35);
                Canvas.SetLeft(img, currentMargins);
                
                // сохранение в файл не нужно
                //bitmap.Save("C:\\officewaredocuments\\captures\\1.jpg");

            }
            catch (Exception)
            {

            }
        }

        private void createPageHandler(object sender, RoutedEventArgs e)
        {
            createNewPage("paragraph", null, null, 0);
        }

        public void createNewPage(string newContol, UIElement img, OpenFileDialog ofd, int rightImageYCoord) {

            pageCursor++;
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
            if (newContol.Contains("paragraph")) {
                TextBox textBox = new TextBox();
                StackPanel paragraph = new StackPanel();
                paragraph.Orientation = Orientation.Horizontal;
                TextBox strokeNumber = new TextBox();
                strokeNumber.BorderThickness = new Thickness();
                strokeNumber.Width = 50;
                //strokeNumber.Text = (lineCursor + 1).ToString();
                //strokeNumber.Text = ((pages.Children.Count - 1) * countLinesInPage + 2).ToString();
                if (pages.Children.Count <= 2)
                {
                    strokeNumber.Text = ((pages.Children.Count - 1) * countLinesInPage + 2).ToString();
                }
                else if (pages.Children.Count >= 3)
                {
                    strokeNumber.Text = ((pages.Children.Count - 1) * countLinesInPage + 3).ToString();
                }
                paragraph.Children.Add(strokeNumber);
                paragraph.Children.Add(textBox);
                Canvas.SetLeft(paragraph, currentMargins);

                /*pageCursor++;
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
                page = newPage;*/

                //textBox.TabIndex = 9999;
                textBox.AcceptsTab = false;
                textBox.IsTabStop = true;
                textBox.Background = System.Windows.Media.Brushes.Transparent;

                //newPage.Children.Add(textBox);
                newPage.Children.Add(paragraph);

                //Canvas.SetTop(textBox, 25);
                //Canvas.SetLeft(textBox, 50);

                Canvas.SetTop(paragraph, page.Children.Count * 35);

                textBox.Width = currentWidth;
                textBox.BorderThickness = new Thickness(0);
                textBox.MaxLines = 1;
                textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                ContextMenu contextMenu = new ContextMenu();
                MenuItem cutMenuItem = new MenuItem();
                cutMenuItem.Header = "Вырезать";
                contextMenu.Items.Add(cutMenuItem);
                cutMenuItem.Click += goToAnotherWindow;
                MenuItem copyMenuItem = new MenuItem();
                copyMenuItem.Header = "Копировать";
                contextMenu.Items.Add(copyMenuItem);
                copyMenuItem.Click += goToAnotherWindow;
                MenuItem insertMenuItem = new MenuItem();
                insertMenuItem.Header = "Вставить";
                contextMenu.Items.Add(insertMenuItem);
                insertMenuItem.Click += goToAnotherWindow;
                MenuItem fontMenuItem = new MenuItem();
                fontMenuItem.Header = "Шрифт";
                contextMenu.Items.Add(fontMenuItem);
                fontMenuItem.Click += goToAnotherWindow;
                MenuItem paragraphMenuItem = new MenuItem();
                paragraphMenuItem.Header = "Абзац";
                contextMenu.Items.Add(paragraphMenuItem);
                paragraphMenuItem.Click += openParagaphDialog;
                MenuItem searchMenuItem = new MenuItem();
                searchMenuItem.Header = "Поиск";
                contextMenu.Items.Add(searchMenuItem);
                searchMenuItem.Click += goToAnotherWindow;
                MenuItem synonymsMenuItem = new MenuItem();
                synonymsMenuItem.Header = "Вырезать";
                contextMenu.Items.Add(synonymsMenuItem);
                synonymsMenuItem.Click += goToAnotherWindow;
                MenuItem translateMenuItem = new MenuItem();
                translateMenuItem.Header = "Перевести";
                contextMenu.Items.Add(translateMenuItem);
                translateMenuItem.Click += goToAnotherWindow;
                MenuItem referenceMenuItem = new MenuItem();
                referenceMenuItem.Header = "Ссылка";
                contextMenu.Items.Add(referenceMenuItem);
                referenceMenuItem.Click += goToAnotherWindow;
                MenuItem createNoteMenuItem = new MenuItem();
                createNoteMenuItem.Header = "Создать примечание";
                contextMenu.Items.Add(createNoteMenuItem);
                createNoteMenuItem.Click += goToAnotherWindow;
                textBox.ContextMenu = contextMenu;

                textBox.Focus();

                //fontWeightBolder = textBox;
                currentControl = textBox;

                textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
            } else if (newContol.Contains("img")) {
                StackPanel paragraph = new StackPanel();
                paragraph.Orientation = Orientation.Horizontal;
                TextBox strokeNumber = new TextBox();
                strokeNumber.BorderThickness = new Thickness(0);
                strokeNumber.Width = 50;
                strokeNumber.Text = (lineCursor + 1).ToString();
                paragraph.Children.Add(strokeNumber);
                paragraph.Children.Add(img);
                page.Children.Add(paragraph);
                Canvas.SetLeft(paragraph, currentMargins);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(ofd.FileName, UriKind.Absolute);
                bitmapImage.EndInit();
                ((System.Windows.Controls.Image)img).Source = bitmapImage;
                ((System.Windows.Controls.Image)img).Width = 150;
                ((System.Windows.Controls.Image)img).Height = 150;
                Canvas.SetTop(paragraph, 35);
                ((StackPanel)page.Children[0]).Children[1].Focus();
                /*Canvas.SetTop(img, page.Children.Count * 35);
                Canvas.SetLeft(img, currentMargins);*/

                img.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                img.PreviewKeyDown += new KeyEventHandler(specialInputHandler);

            } else if (newContol.Contains("video")) {
                StackPanel paragraph = new StackPanel();
                paragraph.Orientation = Orientation.Horizontal;
                TextBox strokeNumber = new TextBox();
                strokeNumber.BorderThickness = new Thickness(0);
                strokeNumber.Width = 50;
                strokeNumber.Text = (lineCursor + 1).ToString();
                paragraph.Children.Add(strokeNumber);
                paragraph.Children.Add(img);
                page.Children.Add(paragraph);
                Canvas.SetLeft(paragraph, currentMargins);
                
                Canvas.SetTop(paragraph, 35);
                ((StackPanel)page.Children[0]).Children[1].Focus();

                img.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                img.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                img.PreviewKeyDown += new KeyEventHandler(specialInputHandler);
            }
            lineCursor = 1;
            backdrop.Height += newPage.Height;

            if (pages.Children.Count >= 2) {
            
                TextBlock pageNumber = new TextBlock();
                backdrop.Children.Add(pageNumber);
                int auxOffset = 25;
                if (pages.Children.Count <= 2)
                {
                    auxOffset = 40;
                }
                //int pageNumberTop = (auxOffset + (int)margins.Top + (int)newPage.Height) * (pages.Children.Count - 1);
                //int pageNumberTop = ((int)margins.Top - 3) * (pages.Children.Count - 1) + (int)newPage.Height * (pages.Children.Count - 1);
                int pageNumberTop = ((int)margins.Top - 3) * (pages.Children.Count) + (int)newPage.Height * (pages.Children.Count);

                Canvas.SetTop(pageNumber, pageNumberTop);
            
                Canvas.SetLeft(pageNumber, 300);
            
                pageNumber.Text = pages.Children.Count.ToString();
                //pageNumber.Text = (pages.Children.Count - 1).ToString();
            }
        }

        private void videoFromInternerHandler(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вставка видео", "Введите URL-адресс для видео из интернета", MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK:
                    MediaElement mediaElement = new MediaElement();
                    lineCursor++;

                    mediaElement.Width = 200;
                    mediaElement.Height = 200;

                    //ниже ссылка не работает возможно не работает https
                    //mediaElement.Source = new Uri("https://r2---sn-4g5e6nzl.googlevideo.com/videoplayback?expire=1634501533&ei=PS9sYZa8F4TsW_mVksAJ&ip=5.154.174.53&id=o-ADtYJdmhuKQ3OC8BWFECJous-wC31ZZmjE9HSlTCj5cI&itag=243&aitags=133%2C134%2C135%2C136%2C137%2C160%2C242%2C243%2C244%2C247%2C248%2C271%2C278%2C313&source=youtube&requiressl=yes&vprv=1&mime=video%2Fwebm&ns=7e2yGJwl6ElunVoaQVoYOcAG&gir=yes&clen=8100960&dur=471.203&lmt=1626169534952244&keepalive=yes&fexp=24001373,24007246&c=WEB&txp=5316224&n=cTsn60Hl9d6kmXD6Z&sparams=expire%2Cei%2Cip%2Cid%2Caitags%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cns%2Cgir%2Cclen%2Cdur%2Clmt&sig=AOq0QJ8wRgIhAJEDcfHKdDqBfnjYXs34S06pyp2aSQdWT_QFsW7T-zC1AiEA6jf3NJ7BcK9zUJ27LkGns0mSYi1ugPx2y_mR_pTOFm4%3D&redirect_counter=1&cm2rm=sn-apnl7l&req_id=31a9c7e0777ca3ee&cms_redirect=yes&mh=23&mip=178.167.29.8&mm=34&mn=sn-4g5e6nzl&ms=ltu&mt=1634479483&mv=m&mvi=2&pl=20&lsparams=mh,mip,mm,mn,ms,mv,mvi,pl&lsig=AG3C_xAwRQIgVQkZgvHBKQeHxSYjesB3EOI4dViXfUHlnSUUpubzn-wCIQDYb_EqktWDHkgMmCXHOmF_744w9KBNvaFnSIGGlD9FdA%3D%3D");
                    //ниже ссылка работает
                    mediaElement.Source = new Uri("file:///C:/Users/%D0%A1%D0%95%D0%A0%D0%93%D0%95%D0%99/Documents/Bandicam/metaplatform(activeTab).mp4");

                    int rightImageYCoord = 0;
                    int paragraphsCursor = 0;
                    foreach (StackPanel container in page.Children)
                    {
                        paragraphsCursor++;
                        if (paragraphsCursor < lineCursor)
                        {
                            if (container.Children[1] is TextBox)
                            {
                                rightImageYCoord += 35;
                            }
                            else if (container.Children[1] is System.Windows.Controls.Image)
                            {
                                rightImageYCoord += 150;
                            }
                            else if (container.Children[1] is System.Windows.Controls.MediaElement)
                            {
                                rightImageYCoord += 200;
                            }
                        }
                    }

                    if (rightImageYCoord >= wrapHeight)
                    {
                        createNewPage("video", mediaElement, null, 0);
                    }
                    else
                    {

                        StackPanel paragraph = new StackPanel();
                        paragraph.Orientation = Orientation.Horizontal;
                        TextBox strokeNumber = new TextBox();
                        strokeNumber.BorderThickness = new Thickness();
                        strokeNumber.Width = 50;
                        strokeNumber.Text = (lineCursor + 1).ToString();
                        paragraph.Children.Add(strokeNumber);
                        paragraph.Children.Add(mediaElement);

                        //page.Children.Add(paragraph);
                        if (lineCursor >= page.Children.Count)
                        {
                            page.Children.Add(paragraph);
                        }
                        else
                        {
                            page.Children.Insert(lineCursor, paragraph);
                        }

                        Canvas.SetLeft(paragraph, currentMargins);

                        Canvas.SetTop(paragraph, rightImageYCoord);

                        int elementCursor = 0;
                        foreach (StackPanel container in page.Children)
                        {
                            elementCursor++;
                            if (elementCursor > lineCursor + 1)
                            {
                                Canvas.SetTop(container, Canvas.GetTop(container) + 200);
                            }
                        }

                    }
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
                    textBox.AcceptsTab = false;
                    textBox.IsTabStop = true;
                    //textBox.TabIndex = 9999;
                    textBox.Background = System.Windows.Media.Brushes.Transparent;
                    textBox.Width = currentWidth;
                    textBox.BorderThickness = new Thickness(0);
                    textBox.MaxLines = 1;
                    textBox.BorderBrush = System.Windows.Media.Brushes.Transparent;
                    ContextMenu contextMenu = new ContextMenu();
                    MenuItem cutMenuItem = new MenuItem();
                    cutMenuItem.Header = "Вырезать";
                    contextMenu.Items.Add(cutMenuItem);
                    cutMenuItem.Click += goToAnotherWindow;
                    MenuItem copyMenuItem = new MenuItem();
                    copyMenuItem.Header = "Копировать";
                    contextMenu.Items.Add(copyMenuItem);
                    copyMenuItem.Click += goToAnotherWindow;
                    MenuItem insertMenuItem = new MenuItem();
                    insertMenuItem.Header = "Вставить";
                    contextMenu.Items.Add(insertMenuItem);
                    insertMenuItem.Click += goToAnotherWindow;
                    MenuItem fontMenuItem = new MenuItem();
                    fontMenuItem.Header = "Шрифт";
                    contextMenu.Items.Add(fontMenuItem);
                    fontMenuItem.Click += goToAnotherWindow;
                    MenuItem paragraphMenuItem = new MenuItem();
                    paragraphMenuItem.Header = "Абзац";
                    contextMenu.Items.Add(paragraphMenuItem);
                    paragraphMenuItem.Click += openParagaphDialog;
                    MenuItem searchMenuItem = new MenuItem();
                    searchMenuItem.Header = "Поиск";
                    contextMenu.Items.Add(searchMenuItem);
                    searchMenuItem.Click += goToAnotherWindow;
                    MenuItem synonymsMenuItem = new MenuItem();
                    synonymsMenuItem.Header = "Вырезать";
                    contextMenu.Items.Add(synonymsMenuItem);
                    synonymsMenuItem.Click += goToAnotherWindow;
                    MenuItem translateMenuItem = new MenuItem();
                    translateMenuItem.Header = "Перевести";
                    contextMenu.Items.Add(translateMenuItem);
                    translateMenuItem.Click += goToAnotherWindow;
                    MenuItem referenceMenuItem = new MenuItem();
                    referenceMenuItem.Header = "Ссылка";
                    contextMenu.Items.Add(referenceMenuItem);
                    referenceMenuItem.Click += goToAnotherWindow;
                    MenuItem createNoteMenuItem = new MenuItem();
                    createNoteMenuItem.Header = "Создать примечание";
                    contextMenu.Items.Add(createNoteMenuItem);
                    createNoteMenuItem.Click += goToAnotherWindow;
                    page.Children.Add(textBox);
                    ((StackPanel)page.Children[lineCursor]).Children[1].Focus();
                    lineCursor++;
                    Canvas.SetTop(textBox, page.Children.Count * 35);
                    Canvas.SetLeft(textBox, currentMargins);
                    //fontWeightBolder = textBox;
                    currentControl = textBox;
                    textBox.PreviewTextInput += new TextCompositionEventHandler(inputHandler);
                    textBox.PreviewMouseUp += new MouseButtonEventHandler(changeLineFromCursor);
                    textBox.PreviewKeyDown += new KeyEventHandler(specialInputHandler);

                    //fontWeightBolder.Text = file_text;
                    ((TextBox)currentControl).Text = file_text;
                    

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

        private void openEmployersAndStickers(object sender, RoutedEventArgs e)
        {
            MenuItem selectedMenuItem = (MenuItem)sender;
            Dialogs.EnvelopesAndStickers envelopesAndStickers = new Dialogs.EnvelopesAndStickers(selectedMenuItem.DataContext.ToString());
            envelopesAndStickers.Show();
        }

        private void openStatistics(object sender, RoutedEventArgs e)
        {
            int countPages = 0;
            int words = 0;
            int charsWithoutSpaces = 0;
            int charsWithSpaces = 0;
            int paragraphs = 0;
            int lines = 0;
            foreach (Canvas page in pages.Children) {
                countPages++;
                foreach (TextBox paragraph in page.Children) {
                    words += paragraph.Text.Split(new char[] { ' ', '/' }).Length;
                    foreach (char charWithSpace in paragraph.Text.ToCharArray()) {
                        charsWithSpaces++;
                        if (charWithSpace != ' ') {
                            charsWithoutSpaces++;
                        }
                    }
                    lines++;
                    paragraphs++;
                }
            }
            Dialogs.StatisticsDialog statisticsDialog = new Dialogs.StatisticsDialog(countPages, words, charsWithoutSpaces, charsWithSpaces, paragraphs, lines);
            statisticsDialog.Show();
        }

        private void shortcutHotkeyHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F && (Keyboard.Modifiers & ModifierKeys.Control) > 0)
            {
                Dialogs.FindAndReplace findAndReplace = new Dialogs.FindAndReplace("find");
                findAndReplace.Show();
            }
            else if (e.Key == Key.G && (Keyboard.Modifiers & ModifierKeys.Control) > 0)
            {
                Dialogs.FindAndReplace findAndReplace = new Dialogs.FindAndReplace("goto");
                findAndReplace.Show();
            }
            else if (e.Key == Key.H && (Keyboard.Modifiers & ModifierKeys.Control) > 0)
            {
                Dialogs.FindAndReplace findAndReplace = new Dialogs.FindAndReplace("replace");
                findAndReplace.Show();
            }
            else if (e.Key == Key.A && (Keyboard.Modifiers & ModifierKeys.Control) > 0)
            {
                foreach (TextBox uiElement in page.Children) {
                    //uiElement.SelectAll();
                    uiElement.SelectionStart = 0;
                    uiElement.SelectionLength = uiElement.Text.Length;
                }
            }
        }

        private void openDataAndTime(object sender, RoutedEventArgs e)
        {
            Dialogs.DateAndTimeDialog dateAndTimeDialog = new Dialogs.DateAndTimeDialog();
            dateAndTimeDialog.Show();
        }

        private void selectHAllHandler(object sender, RoutedEventArgs e)
        {

        }

        private void selectAllFragmentsHandler(object sender, RoutedEventArgs e)
        {

        }

        private void acceptCorrections(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Документ не содержит ни примечаний, ни исправлений.", "Office ware Documents", MessageBoxButton.OK);
        }

        private void rejectAndNextCorrectionHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Документ не содержит ни примечаний, ни исправлений.", "Office ware Documents", MessageBoxButton.OK);
        }

        private void previousCorrectionHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Документ не содержит ни примечаний, ни исправлений.", "Office ware Documents", MessageBoxButton.OK);
        }

        private void nextCorrectionHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Документ не содержит ни примечаний, ни исправлений.", "Office ware Documents", MessageBoxButton.OK);
        }

        private void refreshTableHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В документе нет оглавления, которое можно было бы обновить. Вы можете вставить его на вкладке ''Ссылки''.", "Office ware Documents", MessageBoxButton.OK);
        }

        private void levelOneHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontSize = 24;
            ((TextBox)currentControl).FontSize = 24;
            
        }

        private void notIncldeInTableOfContentsHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontSize = 14;
            ((TextBox)currentControl).FontSize = 14;
            
        }

        private void levelTwoHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontSize = 18;
            ((TextBox)currentControl).FontSize = 18;
            
        }

        private void levelThreeHandler(object sender, RoutedEventArgs e)
        {
            //fontWeightBolder.FontSize = 14;
            ((TextBox)currentControl).FontSize = 14;
            
        }

        private void openTableOfReferenses(object sender, RoutedEventArgs e)
        {
            Dialogs.TableOfReferenses tableOfReferenses = new Dialogs.TableOfReferenses();
            tableOfReferenses.Show();
        }

        private void markReferenseHandler(object sender, RoutedEventArgs e)
        {
            Dialogs.ReferenseDialog referenseDialog = new Dialogs.ReferenseDialog();
            referenseDialog.Show();
        }

        private void crossReferencesHandler(object sender, RoutedEventArgs e)
        {
            Dialogs.CrossReferencesDialog crossReferencesDialog = new Dialogs.CrossReferencesDialog();
            crossReferencesDialog.Show();
        }
         private void insertTitleHandler(object sender, RoutedEventArgs e)
        {
            Dialogs.TitleDialog titleDialog = new Dialogs.TitleDialog();
            titleDialog.Show();
        }

        private void listOfIllustrationsHandler(object sender, RoutedEventArgs e)
        {
            Dialogs.ListOfIllustrationsDialog listOfIllustrationsDialog = new Dialogs.ListOfIllustrationsDialog();
            listOfIllustrationsDialog.Show();
        }

        private void openParagaphDialog(object sender, RoutedEventArgs e) {
            Dialogs.ParagraphDialog paragraphDialog = new Dialogs.ParagraphDialog();
            paragraphDialog.Show();
        }

        private void setNormalMarginsHandler(object sender, RoutedEventArgs e)
        {
            currentWidth = 450;
            currentMargins = 50;
            foreach (Canvas currentPage in pages.Children)
            {
                foreach (UIElement paragraph in currentPage.Children)
                {
                    ((StackPanel)paragraph).Width = currentWidth;
                    Canvas.SetLeft(paragraph, currentMargins);
                }
            }
        }

        private void setShrinkMarginsHandler(object sender, RoutedEventArgs e)
        {
            currentWidth = 435;
            currentMargins = 65;
            foreach (Canvas currentPage in pages.Children)
            {
                foreach (UIElement paragraph in currentPage.Children)
                {
                    ((StackPanel)paragraph).Width = currentWidth;
                    Canvas.SetLeft(paragraph, currentMargins);
                }
            }
        }

        private void setMiddleMarginsHandler(object sender, RoutedEventArgs e)
        {
            currentWidth = 460;
            currentMargins = 40;
            foreach (Canvas currentPage in pages.Children)
            {
                foreach (UIElement paragraph in currentPage.Children)
                {
                    ((StackPanel)paragraph).Width = currentWidth;
                    Canvas.SetLeft(paragraph, currentMargins);
                }
            }
        }

        private void setWeightMarginsHandler(object sender, RoutedEventArgs e)
        {
            currentWidth = 465;
            currentMargins = 35;
            foreach (Canvas currentPage in pages.Children)
            {
                foreach (UIElement paragraph in currentPage.Children)
                {
                    ((StackPanel)paragraph).Width = currentWidth;
                    Canvas.SetLeft(paragraph, currentMargins);
                }
            }
        }

        private void setReflectMarginsHandler(object sender, RoutedEventArgs e)
        {
            currentWidth = 450;
            currentMargins = 50;
            foreach (Canvas currentPage in pages.Children)
            {
                foreach (UIElement paragraph in currentPage.Children)
                {
                    ((StackPanel)paragraph).Width = currentWidth;
                    Canvas.SetLeft(paragraph, currentMargins);
                }
            }
        }

        private void setNumberOfPageHandler(object sender, RoutedEventArgs e)
        {
            showNumberOfPage = !showNumberOfPage;
            if (!showNumberOfPage) {
                foreach (UIElement possilbleNumberOfPage in backdrop.Children) {
                    if (possilbleNumberOfPage is TextBlock)
                    {
                        possilbleNumberOfPage.Visibility = Visibility.Hidden;
                    }
                }
            } else
            {
                foreach (UIElement possilbleNumberOfPage in backdrop.Children)
                {
                    if (possilbleNumberOfPage is TextBlock)
                    {
                        possilbleNumberOfPage.Visibility = Visibility.Visible;
                    }
                }
            }
        }

        private void sendFeedback(object sender, RoutedEventArgs e)
        {
            // запрос в бд
        }

        private void generatePDF(object sender, RoutedEventArgs e)
        {
            // экспорт в pdf
        }

        private void showPrintDialog(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                //printDialog.PrintVisual(canvas, "Распечатываем элемент Canvas");
            }
        }
    }
}