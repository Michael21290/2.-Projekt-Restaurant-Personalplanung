   M S B A M L   `   `   `  ����_  [2_Projekt_Restaurant_Personalplanung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:_2_Projekt_Restaurant_Personalplanung%_2_Projekt_Restaurant_Personalplanung  5      <    6_2_Projekt_Restaurant_Personalplanung.NeuerMitarbeiter   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:_2_Projekt_Restaurant_Personalplanung     5      -   5        
�������.��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Mitarbeiter hinzufügen��6   $��2��61   $��Center=�6E   $
��Bold"�6b   $��20(�6t   �� 5   
   $��Name:��6   $��1��6    $��Center=�6-   $��Center=�6Q   $
��Bold"�6s   �� 5   
   -   5        $��tbName��5      $��1��6    $��2��6-   $��Center=�6=   $��5q�6_   �� 5!   
   $��Vorname:��6   $��2��6#   $��Center=�60   $��Center=�6T   $
��Bold"�6v   �� 5"   
   -   5        $��	tbVorname��5"      $��2��6#   $��2��60   $��Center=�6@   $��5q�6b   �� 5$   
   $��Geburtsdatum:��6   $��3��6(   $��Center=�65   $��Center=�6Y   $
��Bold"�6{   (  "System.Windows.Controls.DatePicker  5%   
   -   5        $��dpGeburtsdatum��5%      $��3��6+   $��2��68   $��Center=�6H   $��5q�6j   �� 5'   
   $��Stellenbezeichnung:��6   $��4��6.   $��Center=�6;   $��Center=�6_   $
��Bold"�6�   �� 5(   
   -   5        $��tbStellenbezeichnung��5(      $��4��6.   $��2��6;   $��Center=�6K   $��5q�6m   �� 5*   
   $��E-Mail:��6   $��5��6"   $��Center=�6/   $��Center=�6S   $
��Bold"�6u   �� 5+   
   -   5        $��tbEmail��5+      $��5��6!   $��2��6.   $��Center=�6>   $��5q�6`   �� 5-   
   $!��Benutzeraccount hinzufügen��6   $��6��65   $��2��6B   $��Center=�6V   $
��Bold"�6s   $��20(�6�   �� 5/   
   $��Benutzername:��6   $��7��6(   $��Center=�65   $��Center=�6Y   $
��Bold"�6{   �� 50   
   -   5        $��tbBenutzername��50      $��7��6(   $��2��65   $��Center=�6E   $��5q�6g   �� 52   
   $��	Passwort:��6   $��8��6$   $��Center=�61   $��Center=�6U   $
��Bold"�6w   �� 53   
   -   5        $��
tbPasswort��53      $��8��6$   $��2��61   $��Center=�6A   $��5q�6c   �� 55   
   $��Admin Account:��6   $��9��6)   $��Center=�66   $��Center=�6Z   $
��Bold"�6|   �� 56   
   -	   5        $��
cbIstAdmin��56      $��9��6%   $��2��62   $��Center=�6B   $��5q�6d   �� 58   
   $��10��6    �� Orientation$ 
Horizontal=�6#   $��2��6<   .+�59      �� -
   5        $��Mitarbeiter hinzufügen��59      $��5q�66   $	��300��6A   $
��Bold"�6l   �� 5:      -   5        $��Zurück zum Menü��5:      $��5q�6/   $	��300��6:   $
��Bold"�6^   5;      5?      5@      