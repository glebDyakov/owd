   M S B A M L   `   `   `  ����E  Adocumenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:documenter.Dialogsdocumenter.Dialogs  5   	   -    'documenter.Dialogs.SortParametersDialog   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:documenter.Dialogs     5   	     � Title$-  'Параметры сортировки��5   	   $	��450��6&   $	��800��63   .��5	      �  � RowDefinitions 5
   
   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� .+�5      �� $��
0, 0, 0, 0q�6   $'��!Разделитель полей��6,   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      	�  d� 	IsChecked$
 trueY�6   �� 5      $!��знак табуляции��6   5      �� 5      $ 
Horizontal=�6   .+�5      	� $
 trueY�6   �� 5      $#��точка табуляции��6   5      �� 5      $ 
Horizontal=�6   .+�5      	� $
 trueY�6   �� 5      $��другой��6   �� 5      $��25, 0, 0, 0q�6   $��25��6/   5      �� 5      $��
0, 0, 0, 0q�6   $-��'Параметры сортировки��6,   �� 5       $ 
Horizontal=�6   .+�5!      �� $
 TrueY�6   �� 5"      $!��только столбцы��6   5#      �� 5$      $ 
Horizontal=�6   .+�5%      �� $
 TrueY�6   �� 5&      $'��!учитывать регистр��6   5'      �� 5(      $��
0, 0, 0, 0q�6   $��Язык��6,   �� 5)       �� SelectedIndex$ 1��6   $	��200��6)   $
��Left=�65   .@�5*      �� $#��английский (США)��6   �� 5+      $��русский��6   5,      5-      5.      5/      