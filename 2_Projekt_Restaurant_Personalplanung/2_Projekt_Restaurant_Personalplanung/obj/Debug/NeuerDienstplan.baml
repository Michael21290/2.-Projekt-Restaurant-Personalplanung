   M S B A M L   `   `   `  ����_  [2_Projekt_Restaurant_Personalplanung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:_2_Projekt_Restaurant_Personalplanung%_2_Projekt_Restaurant_Personalplanung  5      ;    5_2_Projekt_Restaurant_Personalplanung.NeuerDienstplan   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:_2_Projekt_Restaurant_Personalplanung     5      -   5        
�������.��5	      � -   5          �Name$  MainGrid��5	      $��Stretch=�6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $ ��Neuen Dienstplan erstellen��6   $
��Bold"�65   $��20(�6G   $��4��6U   $��Center=�6i   $��Stretch=�6�   �� 5   
   $��Jahr:��6   $��1��6    �� 5   
   -   5         ��Name$ TbJahr��5      $��1��6"   $��1��6/   $��3q�6?   �� 5    
   $��Kallenderwoche:��6   $��2��6*   �� 5!   
   -   5        $
 TbKW��5!      $��2��6    $��1��6-   $��3q�6=   �� 5#   
   $��
Wochentag:��6   $��3��6%   �� 5$   
   -   5        $ TbWochentag��5$      $��3��6'   $��1��64   $��3q�6D   �� 5&   
   $��Für Datum:��6   $��4��6%   (  "System.Windows.Controls.DatePicker  5'   
   -   5          Name$ TbDatum��5'      $��4��6&   $��1��63   $��3q�6C   � 5)   
   $��5��6   $��2��6    5*      �� 5+      6%   �� 5,      6%    5.      �� 5/      6"   �� 50      6"   .+�52      �� $��Mitarbeiterliste:��6   �� 53      -   5        $��Angestellte��53      $	��200��6C   $��5q�6P   $��1��6[   $��0��6h   ��6*   �� ��54      �� 55      .R�56      ��  �� Orientation$ 
Horizontal=�6%   .+�57      �� ��6(   �� *	Vorname+�� 58      $�� ��6(   �� 59      ��6(   �� *Name+�� 5:      $	�� - ��6(   �� 5;      ��6(   �� *Stellenbezeichnung+5<      5=      5?      �� 5A      $��Eingeteilte Mitarbeiter:��6   $��1��67   �� 5B      -   5        $��EingeteilteMitarbeiter��5B      $	��200��6M   $��5q�6Z   $��1��6e   $��1��6r   ��65   �� ��5C      �� 5D      .R�5E      �� $ 
Horizontal=�6%   .+�5F      �� ��6(   �� *	Vorname+�� 5G      $�� ��6(   �� 5H      ��6(   �� *Name+�� 5I      $	�� - ��6(   �� 5J      ��6(   �� *Stellenbezeichnung+5K      5L      5N      5O      �� 5Q   
   $��6��6   $��2��6"   $ 
Horizontal=�66   .+�5R      �� -	   5        $��3q�5R      $��Dienstplan Speichern��6    $
��Bold"�6?   $	��200��6c   �� 5S      -
   5        $��3q�5S      $��Zurück zum Menü��6    $
��Bold"�6:   $	��200��6d   5T      5U      5V      