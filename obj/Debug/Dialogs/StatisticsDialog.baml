   M S B A M L   `   `   `  ����E  Adocumenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:documenter.Dialogsdocumenter.Dialogs  5   	   )    #documenter.Dialogs.StatisticsDialog   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:documenter.Dialogs     5   	     � Title$  Статистка��5   	   $	��450��6   $	��800��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!    � RowDefinitions 5   
   �� 5      6   .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Статистка:��6   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Страниц��6   �� 5      -   5         ��Name$ 
pagesCount��5      $��700, 0, 0, 0q�60   $��1��6F   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Слов��6   �� 5      -   5        $ 
wordsCount��5      $��700, 0, 0, 0q�60   $��1��6F   5      �� 5      $ 
Horizontal=�6   .+�5      �� $,��&Знаков (без пробелов)��6   �� 5      -   5        $ charsWithoutSpacesCount��5      $��600, 0, 0, 0q�6=   $��1��6S   5      �� 5       $ 
Horizontal=�6   .+�5!      �� $*��$Знаков (с пробелами)��6   �� 5"      -   5        $ charsWithSpacesCount��5"      $��600, 0, 0, 0q�6;   $��1��6Q   5#      �� 5$      $ 
Horizontal=�6   .+�5%      �� $��Абзацев��6   �� 5&      -   5        $ paragraphsCount��5&      $��700, 0, 0, 0q�66   $��1��6L   5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $��
Строк��6   �� 5*      -   5        $ 
linesCount��5*      $��700, 0, 0, 0q�60   $��1��6F   5+      �� 5,      $ 
Horizontal=�6   .+�5-      �� -   5        5-   7   �� 5.      $��25, 0, 0, 0q�6   $7��1Учитывать надписи и сноски��61   5/      �� 50      -   5        $��Закрыть��50   3   51      52      53      