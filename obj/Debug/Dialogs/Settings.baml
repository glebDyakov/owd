   M S B A M L   `   `   `  ����E  Adocumenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:documenter.Dialogsdocumenter.Dialogs  5   	   !    documenter.Dialogs.Settings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:documenter.Dialogs     5   	     � Title$  Параметры��5   	   $	��450��6   $	��800��6(   .��5	      �  � ShowGridLines .  � ColumnDefinitions 5
   
   �� 5      $	��250 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      6   .+�5   
   �� -   5         ��Name$
 tabs��5      $��0��6#   $��0��63   .+�5      �� -   5         �� Padding$ 10, 3, 0, 0q�5      $��25��6v   $��
Общие��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $��Отображение��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $��Правописание��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $��Сохранение��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $��Язык��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $3��-Специальные возможности��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $ ��Дополнительно��6�   6�   �� 5      -	   5        $ 10, 3, 0, 0q�5      $��25��6v   $#��Натсроить ленту��6�   6�   �� 5      -
   5        $ 10, 3, 0, 0q�5      $��25��6v   $2��,Панель быстрого доступа��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $��Надстройки��6�   6�   �� 5      -   5        $ 10, 3, 0, 0q�5      $��25��6v   $@��:Центр управления безопасностью��6�   6�   5      �� 5   
   $��1��6   $��0��6'   .��5      �� .+�5       �� $V��PОсновные параметры для работы с Office ware documents��6   6[   ]� 5!      $��25��6   
�������.+�5"      �� 
�������$
��Bold"�62   $��Center=�6D   $P��JПараметры Пользовательского интерфейса��6_   6�   5#      �� 5$      $N��HПри использовании нескольких дисплеев:��6   6L   �� 5%       �� Orientation$ 
Horizontal=�6   .+�5&      	�  d� 	IsChecked$
 TrueY�6"   65   �� 5'      $4��.Обеспечить наилучший вид��6    6B   5(      �� 5)      $ 
Horizontal=�6   .+�5*      	� $
 TrueY�6"   65   �� 5+      $����Обеспечить наилучшую совместимость (требуется перезапуск приложения)��6    6n   5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $
 TrueY�6   62   �� 5/      $`��ZПоказывать мини панельинструментов при выдлении��6    6Y   50      �� 51      $ 
Horizontal=�6   .+�52      �� $
 TrueY�6   62   �� 53      $@��:Включить динамический просмотр��6    6H   54      �� 55      $ 
Horizontal=�6   .+�56      �� $
 TrueY�6   62   �� 57      $m��gОбновлять содержимое документа во время перетаскивания��6    6`   58      �� 59      $ 
Horizontal=�6   .+�5:      �� $ FalseY�6   63   �� 5;      $B��<Автоматически сворачивать ленту��6    6I   5<      �� 5=      $ 
Horizontal=�6   .+�5>      �� $:��4Стиль всплывающих подсказок��6    6E   �� 5?       �� SelectedIndex$ 0��6   .@�5@      �� $[��UПоказывать расширенные всплывающие подсказки��6'   6`   �� 5A      $`��ZНе показывать расширенные всплывающие подсказки��6'   6c   �� 5B      $I��CНе показывать всплывающие подсказки��6'   6W   5C      5D      ]� 5E      $��25��6   
�������.+�5F      �� 
�������$
��Bold"�62   $��Center=�6D   $1��+Личная настройка Office ware��6_   6�   5G      �� 5H      $ 
Horizontal=�6   .+�5I      �� $%��Имя пользователя��6    6:   �� 5J      $��Сергей��6   6.   5K      �� 5L      $ 
Horizontal=�6   .+�5M      �� $��Инициалы��6    62   �� 5N      $��С��6   6)   5O      �� 5P      $ 
Horizontal=�6   .+�5Q      �� $ FalseY�6   63   �� 5R      $����Всегда использовать эти значения независимо от состояния входа в Office ware documents��6    6�   5S      �� 5T      $ 
Horizontal=�6   .+�5U      �� $��Фон Office ware��6    69   �� 5V      $ 0��6   .@�5W      �� $��Разные цвета��6'   6@   �� 5X      $��Тёмно-серая��6'   6?   �� 5Y      $��Чёрная��6'   6:   �� 5Z      $��
Белая��6'   69   �� 5[      $D��>Использовать системные настройки��6'   6T   �� 5\      $��Разные цвета��6'   6@   �� 5]      $��Тёмно-серая��6'   6?   �� 5^      $��Чёрная��6'   6:   �� 5_      $��
Белая��6'   69   �� 5`      $D��>Использовать системные настройки��6'   6T   �� 5a      $��Разные цвета��6'   6@   �� 5b      $��Тёмно-серая��6'   6?   �� 5c      $��Чёрная��6'   6:   �� 5d      $��
Белая��6'   69   �� 5e      $D��>Использовать системные настройки��6'   6T   5f      5g      �� 5h      $ 
Horizontal=�6   .+�5i      �� $��Тема Office Ware��6    6:   �� 5j      $ 0��6   .@�5k      �� $��Разные цвета��6'   6@   �� 5l      $��Тёмно-серая��6'   6?   �� 5m      $��Чёрная��6'   6:   �� 5n      $��
Белая��6'   69   �� 5o      $D��>Использовать системные настройки��6'   6T   5p      �� 5q      $ FalseY�6   63   �� 5r      $0��*Отключить тёмный режим��6    6@   5s      ]� 5t      $��25��6   
�������.+�5u      �� 
�������$
��Bold"�62   $��Center=�6D   $1��+Личная настройка Office ware��6_   6�   5v      �� 5w      $
��Left=�6   $	��250��64   $@��:Параметры конфиденциальности...��6@   6l   ]� 5x      $��25��6   
�������.+�5y      �� 
�������$
��Bold"�62   $��Center=�6D   $��Функции LinkedIn��6_   6y   5z      �� 5{      $����Используйте функции LinkedIn в Office ware, чтобы поддерживать связь с коллегами и быть в курсе новостей вашей отрасли.��6   6�   �� 5|      $ 
Horizontal=�6   .+�5}      �� $ FalseY�6   63   �� 5~      $Z��TВключить возможности LinkedIn в приложении Office ware��6    6`   5      �� 5�      $ 
Horizontal=�6   .+�5�      �� 
����  �$"��О функциях LinkedIn��62   6O   �� 5�      
����  �$��        ��62   6D   �� 5�      
����  �$N��HУправление связями учетной записи LinkedIn��62   6f   5�      ]� 5�      $��25��6   
�������.+�5�      �� 
�������$
��Bold"�62   $��Center=�6D   $'��!Параметры запуска��6_   6z   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $+��%Выберите расширения��6    6=   �� 5�      $
��Left=�6   $	��250��68   $0��*Программы по умолчанию��6D   6g   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $ FalseY�6   63   �� 5�      $����Сообщения о том, что Office ware Documents не является программой по умолчанию для просмотра и редактирования документов��6    6�   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $ FalseY�6   63   �� 5�      $����Открывать вложения электронной почты и другие нередактируемые файлы в режиме чтения��6    6}   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $
 TrueY�6   62   �� 5�      $n��hПоказывать начальный экран при запуске этого приложения��6    6a   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $����При работе с другими пользователями необходимо автоматически передавать внесённые мной изменения: ��6    6�   �� 5�      $ 2��6   .@�5�      �� $��Всегда��6'   6:   �� 5�      $��Никогда��6'   6;   �� 5�      $��Спрашивать��6'   6>   5�      5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $ FalseY�6   63   �� 5�      $N��HОтображать имена на флагах присутствия��6    6P   5�      5�      5�      5�      5�      