   M S B A M L   `   `   `  ����E  AMONITORING, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MONITORING
MONITORING  5          MONITORING.FolderListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MONITORING     5      .��5	      �� 
�������$
��Auto=�6&   .��5
   
   �� -   5          ��Name$  groupBox��5
      $��Windows Settings��6%   $��6q�6?   .��5      �  +� IsFocusScope .   � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $��* �6$   �� 5      $
��auto �6$   .+�5      �� -   5         ��Name$ Activate��5      $ ��Activate/Deactivate Window��6L   $��0��6q   $��12, 12, 12, 6q�6~   $
��Left=�6�    d� 	IsChecked 6-   �� *
Activate+6�   �� 5      $��Output mode��6   $��1��62   $��	12,6,12,6q�6?   $
��auto��6R   $
��auto��6`   $
��Left=�6m   $	��Top=�6�   .��5      � $��3q�6    5      �� 5      $
��auto �6,   �� 5      $
��auto �6,   �� 5      $
��auto �6,   .+�5      	� -   5         	�Name$ ByTurns��5   &    	� 	GroupName$ 
OutputMode��6U   $��by turns��6l   $��0��6   $��3q�6�    67   �� *	ByTurns+6�   	� 5       -   5        $ Mosaic��5    '   $ 
OutputMode��6T   $��mosaic��6k   $��1��6|   $��3q�6�    67   �� *Mosaic+6�   	� 5!      -   5        $ Cascade��5!   '   $ 
OutputMode��6V   $��cascade��6m   $��2��6   $��3q�6�    68   �� *	Cascade+6�   5"      5#      �� 5&      $��Rotation��6   $��2��6.   $��	12,6,12,6q�6;   $
��auto��6N   $
��auto��6\   $
��Left=�6i   $	��Top=�6�   .��5'      �� -   5        $ 
AutoRotate��5'      $&�� Auto rotate "SQL Command" result��5(      $��0��6T   $��6q�6a   $��Center=�6l    5'   3   �� *
AutoRotate+{�6T   �� *AutoRotateEnabled+5(   l   5)          MONITORING.WindowRestangle  5+      $��3��6(   �� 5-      -   5        $��ForcedToDisplay��5-      $<��6Forced to display SQL command window contents on error��6X   $��4��6�   $��12, 6, 12, 6q�6�   $
��Left=�6�   $��Center=�6�    62   �� *ForcedToDisplay+6�      MONITORING.SaveCancel  5/      $��6��6#   50      51      52      53      