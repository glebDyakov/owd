﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F6790DC1B820C79F741E52D997D099A15D5EB0D4A2E838E02A8A5E5B147B8383"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.Windows;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Xceed.Wpf.Toolkit;
using documenter;


namespace documenter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 195 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ColorPickerPalette colorPickerPalette;
        
        #line default
        #line hidden
        
        
        #line 325 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem goToAnotherWindowMenuItem;
        
        #line default
        #line hidden
        
        
        #line 345 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer mainScroll;
        
        #line default
        #line hidden
        
        
        #line 347 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel areaOfSelection;
        
        #line default
        #line hidden
        
        
        #line 353 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu cm;
        
        #line default
        #line hidden
        
        
        #line 370 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas backdrop;
        
        #line default
        #line hidden
        
        
        #line 371 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox zoom;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pages;
        
        #line default
        #line hidden
        
        
        #line 373 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas page;
        
        #line default
        #line hidden
        
        
        #line 376 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fontWeightBolder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/documenter;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\MainWindow.xaml"
            ((documenter.MainWindow)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.shortcutHotkeyHandler);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.createOWDHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.openOWDHandler);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 39 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.openSettings);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fontFamilyChangeToTimesNewRoman);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fontFamilyChangeToArial);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 49 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fontFamilyChangeToCalibri);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 50 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fontFamilyChangeToVerdana);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 52 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fontSizeHandler);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 53 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.upperCaseHandler);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 54 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.lowerCaseHandler);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 56 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.clearStylesHandler);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 57 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fontWeightBolderHandler);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 58 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fontStyleItalicHandler);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textDecorationUnderlineHandler);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textDecorationStrikethroughHandler);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 61 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textSubscriptHandler);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 62 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textSuperscriptHandler);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 63 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textShadowHandler);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 64 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textDecorationBackgroundHandler);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 65 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textDecorationForegroundHandler);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.markersHandler);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 67 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.numberHandler);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 68 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.multiLevelListHandler);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 69 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.decreaseIndentHandler);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 70 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.increaseIndentHandler);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 71 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.sortHandler);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 72 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.showAllCharsHandler);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 73 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.alignLeftHandler);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 74 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.alignCenterHandler);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 75 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.alignRightHandler);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 76 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.alignJustifyHandler);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 77 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.intervalHandler);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 78 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.fillHandler);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 80 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.downBorderHandler);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 81 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.upBorderHandler);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 82 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.leftBorderHandler);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 83 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.rightBorderHandler);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 84 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.noneBordersHandler);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 85 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.allBordersHandler);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 94 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.findHandler);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 95 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.replaceHandler);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 96 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.selectHandler);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 100 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.createPageHandler);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 102 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertTable);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 104 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.openImage);
            
            #line default
            #line hidden
            return;
            case 47:
            
            #line 107 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.drawFigureLine);
            
            #line default
            #line hidden
            return;
            case 48:
            
            #line 109 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.drawFigureCircle);
            
            #line default
            #line hidden
            return;
            case 49:
            
            #line 111 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.drawFigureRect);
            
            #line default
            #line hidden
            return;
            case 50:
            
            #line 118 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.screenCaptureHandler);
            
            #line default
            #line hidden
            return;
            case 51:
            
            #line 122 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.videoFromInternerHandler);
            
            #line default
            #line hidden
            return;
            case 52:
            
            #line 124 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.createLinkHandler);
            
            #line default
            #line hidden
            return;
            case 53:
            
            #line 125 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.videoFromInternerHandler);
            
            #line default
            #line hidden
            return;
            case 54:
            
            #line 126 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.videoFromInternerHandler);
            
            #line default
            #line hidden
            return;
            case 55:
            
            #line 136 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.openDataAndTime);
            
            #line default
            #line hidden
            return;
            case 56:
            
            #line 139 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textFromFileHandler);
            
            #line default
            #line hidden
            return;
            case 57:
            
            #line 144 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharEuro);
            
            #line default
            #line hidden
            return;
            case 58:
            
            #line 145 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharPoud);
            
            #line default
            #line hidden
            return;
            case 59:
            
            #line 146 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharYen);
            
            #line default
            #line hidden
            return;
            case 60:
            
            #line 147 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharCopyright);
            
            #line default
            #line hidden
            return;
            case 61:
            
            #line 148 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharRegistered);
            
            #line default
            #line hidden
            return;
            case 62:
            
            #line 149 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharTM);
            
            #line default
            #line hidden
            return;
            case 63:
            
            #line 150 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharPlusOrMinus);
            
            #line default
            #line hidden
            return;
            case 64:
            
            #line 151 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharNotEqual);
            
            #line default
            #line hidden
            return;
            case 65:
            
            #line 152 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharAll);
            
            #line default
            #line hidden
            return;
            case 66:
            
            #line 153 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharPoud);
            
            #line default
            #line hidden
            return;
            case 67:
            
            #line 154 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharBeta);
            
            #line default
            #line hidden
            return;
            case 68:
            
            #line 155 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharPi);
            
            #line default
            #line hidden
            return;
            case 69:
            
            #line 156 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharInfinity);
            
            #line default
            #line hidden
            return;
            case 70:
            
            #line 157 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharLessAndEqual);
            
            #line default
            #line hidden
            return;
            case 71:
            
            #line 158 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharGratherAndEqual);
            
            #line default
            #line hidden
            return;
            case 72:
            
            #line 159 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharAlpha);
            
            #line default
            #line hidden
            return;
            case 73:
            
            #line 160 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharU);
            
            #line default
            #line hidden
            return;
            case 74:
            
            #line 161 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharFrequency);
            
            #line default
            #line hidden
            return;
            case 75:
            
            #line 162 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharMultiply);
            
            #line default
            #line hidden
            return;
            case 76:
            
            #line 163 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharDivide);
            
            #line default
            #line hidden
            return;
            case 77:
            
            #line 164 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.insertSpecialCharArrow);
            
            #line default
            #line hidden
            return;
            case 78:
            
            #line 184 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.noneIntervalBetweenParagraphsHandler);
            
            #line default
            #line hidden
            return;
            case 79:
            
            #line 185 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.compressedIntervalBetweenParagraphsHandler);
            
            #line default
            #line hidden
            return;
            case 80:
            
            #line 186 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.narrowIntervalBetweenParagraphsHandler);
            
            #line default
            #line hidden
            return;
            case 81:
            
            #line 187 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.looseIntervalBetweenParagraphsHandler);
            
            #line default
            #line hidden
            return;
            case 82:
            
            #line 188 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.freeIntervalBetweenParagraphsHandler);
            
            #line default
            #line hidden
            return;
            case 83:
            
            #line 189 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.doubleIntervalBetweenParagraphsHandler);
            
            #line default
            #line hidden
            return;
            case 84:
            this.colorPickerPalette = ((Syncfusion.Windows.Tools.Controls.ColorPickerPalette)(target));
            
            #line 196 "..\..\MainWindow.xaml"
            this.colorPickerPalette.SelectedBrushChanged += new System.EventHandler<Syncfusion.Windows.Tools.Controls.SelectedBrushChangedEventArgs>(this.colorOfPageHandler);
            
            #line default
            #line hidden
            return;
            case 85:
            
            #line 205 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setLandscapeOrientation);
            
            #line default
            #line hidden
            return;
            case 86:
            
            #line 206 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setPortraitOrientation);
            
            #line default
            #line hidden
            return;
            case 87:
            
            #line 212 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.noneNumberOfStrokes);
            
            #line default
            #line hidden
            return;
            case 88:
            
            #line 213 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.mustNumberOfStrokes);
            
            #line default
            #line hidden
            return;
            case 89:
            
            #line 224 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.toggleAreaOfSelection);
            
            #line default
            #line hidden
            return;
            case 90:
            
            #line 255 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.openEmployersAndStickers);
            
            #line default
            #line hidden
            return;
            case 91:
            
            #line 256 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.openEmployersAndStickers);
            
            #line default
            #line hidden
            return;
            case 92:
            
            #line 278 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.grammaticCheck);
            
            #line default
            #line hidden
            return;
            case 93:
            
            #line 280 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.openStatistics);
            
            #line default
            #line hidden
            return;
            case 94:
            
            #line 281 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.TTS);
            
            #line default
            #line hidden
            return;
            case 95:
            
            #line 311 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setZoomTwiHandrid);
            
            #line default
            #line hidden
            return;
            case 96:
            
            #line 312 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setZoomOneHandrid);
            
            #line default
            #line hidden
            return;
            case 97:
            
            #line 313 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setZoomSeventyFive);
            
            #line default
            #line hidden
            return;
            case 98:
            
            #line 319 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.newWindow);
            
            #line default
            #line hidden
            return;
            case 99:
            this.goToAnotherWindowMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 325 "..\..\MainWindow.xaml"
            this.goToAnotherWindowMenuItem.MouseEnter += new System.Windows.Input.MouseEventHandler(this.showPossibleWindows);
            
            #line default
            #line hidden
            return;
            case 100:
            this.mainScroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 101:
            this.areaOfSelection = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 102:
            this.cm = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 103:
            
            #line 354 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.moveAreaOfSelectionHandler);
            
            #line default
            #line hidden
            return;
            case 104:
            
            #line 356 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.toggleAreaOfSelection);
            
            #line default
            #line hidden
            return;
            case 105:
            
            #line 360 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.toggleAreaOfSelection);
            
            #line default
            #line hidden
            return;
            case 106:
            this.backdrop = ((System.Windows.Controls.Canvas)(target));
            return;
            case 107:
            this.zoom = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 108:
            this.pages = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 109:
            this.page = ((System.Windows.Controls.Canvas)(target));
            return;
            case 110:
            this.fontWeightBolder = ((System.Windows.Controls.TextBox)(target));
            
            #line 376 "..\..\MainWindow.xaml"
            this.fontWeightBolder.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.changeLineFromCursor);
            
            #line default
            #line hidden
            
            #line 376 "..\..\MainWindow.xaml"
            this.fontWeightBolder.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.specialInputHandler);
            
            #line default
            #line hidden
            
            #line 376 "..\..\MainWindow.xaml"
            this.fontWeightBolder.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.inputHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

