   M S B A M L   `   `   `  ����E  AMONITORING, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MONITORING
MONITORING  5      %clr-namespace:IKriv.Wpf	IKriv.Wpf  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5	      1&clr-namespace:System;assembly=mscorlibSystem 5
          MONITORING.SelectListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MONITORING     5      &ikclr-namespace:IKriv.Wpf     5      Bcol2clr-namespace:System.Collections;assembly=mscorlib     5	      6sys&clr-namespace:System;assembly=mscorlib     5
      .��5      �� -   5          ��Name$  sv��5      
�������$
��Auto=�62   .��5   
   �� -   5         ��Name$ groupBox��5      $��Chart Settings��6&   $��6q�6>   .��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $��* �6$   �� 5      $
��auto �6$   .+�5      �� -   5         ��Name$ Activate��5      $��Activate/Deactivate Chart��6L   $��0��5      $��12, 12, 12, 6q�6(   $
��Left=�6?   $��Center=�6Z    d� 	IsChecked 5   -   �� *
Activate+5   Z   � 5      $��1��6   $��9,3,9,3q�6$   $
��auto��65   $
��auto��6C   $
��Left=�6P    5      �� 5      $
��auto �6(   �� 5       $
��auto �6(    � ColumnDefinitions 5"      �� 5#      $
��auto �6+   �� 5$      $
��auto �6+   �� 5%      $
��auto �6+   �� 5&      $��20 �6+   �� 5'      $
��auto �6+   �� 5(      $
��auto �6+   �� 5)      $
��auto �6+   .+�5,      �� $��Database Connection��6    $��0��6;   $��0��6H   $
��Left=�6X   $��3q�6s   �� 5-      $��0��6    $��1��6-   $��3q�6=   $	��120��6H   $��18��6T   �� 5.      -   5        $��Settings��5.      $��Settings��6K   $��0��6^   $��2��6k   $��	12,0,12,0q�6{   $��3q�6�   ��6-   �� *
Settings+6�   �� 5/      $��SQL Update Frequency��6    $��0��6<   $��4��6I   $
��Left=�6Y   $��3q�6t      MONITORING.NumericUpDown  50      -   5          Name$ SQLUpdateFrequency��50   P   $��50��6l   $��0��6w   $��5��6�   $��3q�6�      Minimum$ 0��6�      Maximum$	 100��6�   	   Value	 6*   �� *SQLUpdateFrequency+6�   �� 51      $	��sec��6    $��0��6+   $��6��68   $��3q�6H   �� 53      $��Time to show result��6    $��1��6;   $��4��6H   $
��Left=�6X   $��3q�6s     54      -   5        $ 
TimeToShow��54   {   $��50��6�   $��1��6�   $��5��6�   $��3q�6�   $ 0��6�   $	 100��6�   	 6*   �� *TimeToShowResult+{�6M   �� *TimeToShowResultEnabled+6�   �� 55      $	��sec��6    $��1��6+   $��6��68   $
��Left=�6H   $��3q�6c   56      � 58      $��2��6   $��9,3,9,3q�6$   $
��auto��65   $
��auto��6C    59      �� 5:      $
��auto �6(   �� 5;      $
��auto �6(   �� 5<      $
��auto �6(    5>      �� 5?      $
��auto �6+   �� 5@      $
��auto �6+   �� 5A      $
��auto �6+   �� 5B      $��* �6+   .+�5E      �� $��SQL Command��6    $��3q�63   $��0��6>   $��0��6K   $��4��6[   $
��Left=�6o   �� 5F      -   5        $��
SQLCommand��5F      $��3q�6�   $��1��6�   $��0��6�   $��4��6�   $��90��6�   "
 �� VerticalScrollBarVisibility$
 Visible=�6�    �� AcceptsReturn .  �� 
AcceptsTab . $ �� HorizontalScrollBarVisibility$
 Auto=�5G   �   $
��Left=�6�   ��5F   0   ��  �� Path$ ActualWidth� �� ElementName$ groupBox�� �� 	Converter    IKriv.Wpf.MathConverter   �� ConverterParameter$
 x-37����5G      �� $ ActualWidth�$ sv��   $
 x-65����5H      �� *
SQLCommand+�� 5I      -   5        $
��Exec��5I      $
��Exec��6)   $��3q�68   $��2��6C   $��0��6P   $��	12,0,12,0q�6`   �� 5J      -	   5        $��Template��5J      $��Template��6J   $��3q�6]   $��2��6h   $��1��6u   $��	12,0,12,0q�6�   ��6-   �� *
Template+6�   �� 5K      -
   5        $��SaveAsTemplate��5K      $��Save as template��6V   $��3q�6q   $��2��6|   $��2��6�   $��	12,0,12,0q�6�   ��63   �� *SaveAsTemplate+6�   5L      �� 5N      $��High water marker field��6   $��3��6=   $��	12,6,12,6q�6J   $
��auto��6]   $
��auto��6k   $
��Left=�6x   .��5O      � $��3q�6    5P      �� 5Q      $
��auto �6,   �� 5R      $
��auto �6,    5T      �� 5U      $
��auto �6/   �� 5V      $
��auto �6/   �� 5W      $
��auto �6/   .+�5Z      �� -   5        $ EnableHighWater��5Z   F   $��Enable��6_   $��0��6p   $��0��6~   $��2��6�   $��3q�6�   $
��Left=�6�    6#   �� *EnableMarker+6�   �� 5[      -   5        $ ClearResult��5[   m   $#��Clear result window restangle��6�   $��0��6�   $��3��6�   $��2��6�   $��3q�6�   $
��Left=�6�    6#   �� *ClearResult+{�6E   �� *ClearResultEnable+6�   �� 5]      $��High water marker��6$   $��1��6=   $��0��6J   $
��Left=�6Z   $��3q�6v   �� 5^      $��1��6P   $��1��6]   $��3q�6m   $	��150��6x   $��18��6�   ��6#   �� *SQLFieldsRules.Rules+6�   5_      5`      � 5b      $��4��6   $��9,3,9,3q�6$    5c      �� 5d      $
��auto �6(   �� 5e      $
��auto �6(   �� 5f      $
��auto �6(    5h      �� 5i      $
��auto �6+   �� 5j      $
��auto �6+   �� 5k      $��* �6+   .+�5n      �� $��SQL Fields Rules��6    $��0��68   $��0��6E   $��3��6U   $�� Left=�6i   $��3q�6�   &   System.Windows.Controls.DataGrid  5o      -   5          Name$ 	SQLFields��5o      $��1��62   $��0��6?   $��3��6O   $��3q�6c   $	��120��6n      AutoGenerateColumns .  "   VerticalScrollBarVisibility$ Visible=�5r   ;   $
��Left=�6a      SelectionMode$ Single=�5s         CanUserAddRows .     CanUserDeleteRows .  ��5p      �� $ ActualWidth�$ groupBox��   $
 x-37����5q      �� $ ActualWidth�$ sv��   $
 x-65�� �� SelectedItem 5t      �� *SelectedItem+ � DataContext 5u      �� *SQLFieldsRules+��6F   �� *Rules+   Columns 5w      0  *System.Windows.Controls.DataGridTextColumn  5x      ,  &System.Windows.Controls.DataGridColumn   Header$  ��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 12 6<     5y      $ Column Name��61   $
 auto 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *Name+6_   2  ,MONITORING.DataGridComboBoxColumnWithBinding  5{      $ 
Check Type��6F   $
 auto 6Z   4	  .System.Windows.Controls.DataGridComboBoxColumn 	  SelectedValuePath$ ID��5~   F    	  DisplayMemberPath$ Value��5   F     	  ItemsSource  5|   F   �� *
CheckTypes+! 	  SelectedValueBinding! 5}   F   �� *	CheckType+5   F     5�      $ Value��61   $
 auto 6@    6M   �� *Value+4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5�      $ Color Notification��65   $
 auto 6Q    6^   �� *Color+  5�      $ 
Color Type��6F   $
 auto 6Z   $ ID��5�   F   $ Value��5�   F     5�   6   �� *
ColorTypes+! 5�   F   �� *	ColorType+"   	CellStyle" 5�   "   �� 5�   &   # �� 
TargetType*  $System.Windows.Controls.DataGridCell"#  6,   .�5�   *   �� $ �� Property$ � {�% �� Value% 6F   �� *Color+5�   '   5�      
  5�      $ Sound Notification��65   $
 auto 6Q    6^   �� *Sound+  5�      $ 
Sound Type��6F   $
 auto 6Z   $ ID��5�   F   $ Value��5�   F     5�   F   �� *
SoundTypes+! 5�   F   �� *	SoundType+" 5�   "   �� 5�   &   "#  6,   .�5�   *   �� $ � {�% 6F   �� *Sound+5�   '   5�        5�      $ 
Alert Type��6F   $
 auto 6Z   $ ID��5�   F   $ Value��5�   F     5�   F   �� *
AlertTypes+! 5�   F   �� *	AlertType+5�   F   5�      �� 5�      -   5        $��AddRule��5�      $��Add Rule��6H   $��3q�6[   $��2��6f   $��0��6s   $��	12,0,12,0q�6�   ��6,   �� *	AddRule+6�   �� 5�      -   5        $��
DeleteRule��5�      $��Delete Rule��6N   $��3q�6d   $��2��6o   $��1��6|   $��	12,0,12,0q�6�   ��6/   �� *
DeleteRule+6�   5�         MONITORING.SaveCancel  5�      $��6��6#   5�      5�      5�      5�      