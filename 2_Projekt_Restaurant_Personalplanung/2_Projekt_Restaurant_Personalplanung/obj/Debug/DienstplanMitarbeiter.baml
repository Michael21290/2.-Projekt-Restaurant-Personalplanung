   M S B A M L   `   `   `  ����_  [2_Projekt_Restaurant_Personalplanung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:_2_Projekt_Restaurant_Personalplanung%_2_Projekt_Restaurant_Personalplanung  5      A    ;_2_Projekt_Restaurant_Personalplanung.DienstplanMitarbeiter   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:_2_Projekt_Restaurant_Personalplanung     5      -   5        
�������.��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   � -   5         �Name$ MainGrid��5      $��Stretch=�6!    � ColumnDefinitions 5      �� 5      $	��100 �6#   61   �� 5      $��* �6#   6/     5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5       $
��auto �6    60   �� 5!      $
��auto �6    60   .+�5$      �� $��
Dienstplan��6   $
��Bold"�6)   $��20(�6;   $��4��6I   $��Center=�6]   $��Stretch=�6z   �� 5%      $��Angezeigte Dienstpläne:��6   $
��Wrap=�67   $��1��6K   &   System.Windows.Controls.DataGrid  5&      $��1��6   $��1��6$      AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6h   $	��150��6�   ��64   ��    Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID_Dienstplan+  5)      $
 Jahr��6)    68   �� *Jahr+  5*      $ Kallenderwoche��6)    6B   �� *Kallenderwoche+  5+      $ 	Wochentag��6)    6=   �� *	Wochentag+  5,      $ Datum��6)    69   �� *	FuerDatum+5.      �� 50      $	��ID:��6   $��2��6"   �� 51      -   5         ��Name$ DienstplanID��51   7   $��2��6M   $��1��6Z   $��3q�6j   ��6   �� */ID_Dienstplan+6j   �� 53      $��Jahr:��6   $��3��6$   �� 54      $��3��6-   $��1��6:   $��3q�6J   ��6   �� */Jahr+6J   �� 56      $��Kallenderwoche:��6   $��4��6.   �� 57      $��4��67   $��1��6D   $��3q�6T   ��6   �� */Kallenderwoche+6T   �� 59      $��
Wochentag:��6   $��5��6)   �� 5:      $��5��62   $��1��6?   $��3q�6O   ��6   �� *
/Wochentag+6O   �� 5<      $��Für Datum:��6   $��6��6)   �� 5=      $��6��6K   $��1��6X   $��3q�6h   ��6   �� *
/FuerDatum+	 �� StringFormat$	 
dd.MM.yyyy��6h   �� 5?      $��Erstellt am:��6   $��7��6+   �� 5@      $��7��6O   $��1��6\   $��3q�6l   ��6   �� */ErstelltDatum+$	 
dd.MM.yyyy��6l   �� 5B      $��Eingeteilte Mitarbeiter:��6   $��8��68   $
��Wrap=�6E   �� 5C      $��8��6   $��1��6$   $��50��6Y   $��3q�6e   ��64   �� */Mitarbeiter+��5D      �� 5E      .R�5F      �� 
 �� Orientation$
 
Horizontal=�6%   .+�5G      �� ��6(   �� *ID_Mitarbeiter+�� 5H      $	�� - ��6(   �� 5I      ��6(   �� *	Vorname+�� 5J      $�� ��6(   �� 5K      ��6(   �� *Name+5L      5M      5O      �� 5Q      $��Filtern nach Jahr:��6   $��9��62   $
��Wrap=�6?   �� 5R      -   5         ��Name$ TbFilterJahr��5R      $��9��6,   $��1��69   $��3q�6I   6T   �� 5T      $��Filtern nach KW:��6   $��10��60   $
��Wrap=�6>   �� 5U      -   5        $ 
TbFilterKW��5U      $��10��6*   $��1��68   $��3q�6H   6S   5W      �� 5Y   
   $��1��6   $
 
Horizontal=�6"   .+�5Z      �� -   5        $��3q�5Z      $��	Ausloggen��6    $
��Bold"�64   $	��200��6X   �� 5[      -   5        $��3q�5[      $��Drucken��6    $
��Bold"�62   $	��200��6T   5\      5^      5_      