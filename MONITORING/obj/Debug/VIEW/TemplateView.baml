   M S B A M L   `   `   `  ����E  AMONITORING, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MONITORING
MONITORING  5   	       MONITORING.TemplateView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MONITORING     5   	     � Title$  Template��5   	   $	��362��6   $	��594��6'    � WindowStartupLocation$ CenterOwner=�63   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ ListTag��5      $��0��6#   $��0��60   $	��150��6@   $��0q�6L   $��Visible=�5   Z   ��6   �� *	Templates+ �� SelectedItem 64   �� *SelectedItem+��5      �� 5      .R�5      �� .+�5      �� ��6$   ��  �� Path$ Title� �� Mode$ OneWay=�5      5      5      � 5   
   $��0��6   $��1��6   $��9q�6,    5       �� 5!      $��* �6    �� 5"      $
��auto �6     5$      �� 5%      $
��auto �6#   �� 5&      $��* �6#   .+�5*      �� -   5         ��Name$ 
SQLCommand��5*   ;   $��0��6e   $��1��6r   $��2��6�   $��3,3,3,9q�6�   	 �� AcceptsReturn	 . 
 �� 
AcceptsTab
 . $ �� HorizontalScrollBarVisibility$
 Auto=�6�   " �� VerticalScrollBarVisibility$ Visible=�6�    � DataContext 6   �� *SelectedItem+��6O   �� *Code+6�   � 5,      $��9��6   $��1��6    $��Right=�60   $��Bottom=�6L   $��RightToLeft=�6g    5-      �� 5.      $
��auto �6'   �� 5/      $
��auto �6'   .+�51      �� -   5         ��Name$ Delete��51   *   $��0��6   $��Delete��6:   $��3q�6K   $��	12,0,12,0q�6V   $��Right=�52   4   $��Bottom=�6P   ��6   �� *Delete+6P   �� 53      -   5        $
 Save��53   )   $��1��6   $
��Save��67   $��3q�6F   $��	12,0,12,0q�6Q   $��Right=�54   2   $��Bottom=�6N   ��6   �� *Save+6N   55      56      �� 57   
   $��1��6   $��0��6!   $��2��61   �� 59   
   -   5        $ OK��59      $��3��64   $��2��6A   $��12q�6Q   $��OK��6]   $��	12,0,12,0q�6k   $��Right=�6   $��Bottom=�6�   ��6   �� *OK+6�   5;      5<      