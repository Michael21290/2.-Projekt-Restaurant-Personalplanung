   M S B A M L   `   `   `  ����_  [2_Projekt_Restaurant_Personalplanung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:_2_Projekt_Restaurant_Personalplanung%_2_Projekt_Restaurant_Personalplanung  5      A    ;_2_Projekt_Restaurant_Personalplanung.MitarbeiterBearbeiten   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:_2_Projekt_Restaurant_Personalplanung     5      -   5        
�������.��5	      � -   5        $��MainGrid��5	        � ColumnDefinitions  5
   
   �� 5      $
��auto �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��Mitarbeiter hinzufügen��6   $��2��61   $��Center=�6E   $
��Bold"�6b   $��20(�6t   �� 5   
   $	��ID:��6   $��1��6   $��Center=�6+   $��Center=�6O   $
��Bold"�6q   �� 5   
   $��1��64   $��2��6A   $��5q�6Q   ��6   �� */ID_Mitarbeiter+6Q   �� 5!   
   $��Name:��6   $��2��6    $��Center=�6-   $��Center=�6Q   $
��Bold"�6s   �� 5"   
   $��2��6)   $��2��66   $��Center=�6F   $��5q�6h   ��6   �� */Name+6h   �� 5$   
   $��Vorname:��6   $��3��6#   $��Center=�60   $��Center=�6T   $
��Bold"�6v   �� 5%   
   $��3��6,   $��2��69   $��Center=�6I   $��5q�6k   ��6   �� *
/Vorname+6k   �� 5'   
   $��Geburtsdatum:��6   $��4��6(   $��Center=�65   $��Center=�6Y   $
��Bold"�6{   �� 5(   
   $��4��6   $��1��6   $��Center=�6p   $��5q�6�   ��6/   �� */Geburtsdatum+ �� StringFormat$ dd.MM.yyyy HH:mm:ss��6�   �� 5*   
   $��Geburtsdatum:��6   $��5��6(   $��Center=�65   $��Center=�6Y   $
��Bold"�6{   �� 5+   
   $��5��6   $��1��6    $��Center=�6v   $��5q�6�   ��60   �� */Einstellungsdatum+$ dd.MM.yyyy HH:mm:ss��6�   �� 5-   
   $��Stellenbezeichnung:��6   $��6��6.   $��Center=�6;   $��Center=�6_   $
��Bold"�6�   �� 5.   
   $��6��67   $��2��6D   $��Center=�6T   $��5q�6v   ��6   �� */Stellenbezeichnung+6v   �� 50   
   $��E-Mail:��6   $��7��6"   $��Center=�6/   $��Center=�6S   $
��Bold"�6u   �� 51   
   $��7��6*   $��2��67   $��Center=�6G   $��5q�6i   ��6   �� */Email+6i   �� 53   
   $��Benutzeraccounts:��6   $��8��6,   $��Center=�69   $��Center=�6]   $
��Bold"�6   �� 54   
   $��8��6   $��1��6    $��50��6Y   $��5q�6e   ��60   �� */Benutzeraccount+��55      �� 56      .R�57      ��  �� Orientation$ 
Horizontal=�6!   .+�58      �� ��6$   �� *
ID_Account+�� 59      $	�� - ��6$   �� 5:      ��6$   �� *Benutzername+5;      5<      5>      �� 5@   
   $��10��6   $ 
Horizontal=�6#   $��2��6<   .+�5A      �� -   5        $��Vorheriger Mitarbeiter��5A      $	��150��66   $��5q�6B   $
��Bold"�6k   �� 5B      -   5        $��Nächster Mitarbeiter��5B      $	��150��64   $��5q�6@   $
��Bold"�6h   �� 5C      -   5        $��Änderungen speichern��5C      $	��150��64   $��5q�6@   $
��Bold"�6h   �� 5D      -   5        $��Zurück zum Menü��5D      $	��150��6/   $��5q�6;   $
��Bold"�6^   5E      5I      5J      