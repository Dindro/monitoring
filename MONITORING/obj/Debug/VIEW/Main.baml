   M S B A M L   `   `   `  ����E  AMONITORING, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MONITORING
MONITORING  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5          MONITORING.Main   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MONITORING     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5        � 	Resources  5
         StyleSelectedRight �� 
TargetType �� Property �� Value �� Mode  TemplateSelects �� ItemContainerStyle �� ItemsSource �� Orientation ��Name	 ��Name
 �� UpdateSourceTrigger J� InputBindings
 �� Key �� Command.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName.  (System.Windows.Interactivity.TriggerBase   Actions6  0System.Windows.Interactivity.InvokeCommandAction   Command �� ItemTemplate �� Triggers �� Value �� Binding �� 
TargetName  ContextMenuTreeView m� Command��%E	  &	        &	 }     7   &	     �� 5   
   " Q�6+   .�5      ��  �@Q�
IsSelected 6+   �� *
IsSelected+$ TwoWay=�-   5        5      �� 5   
   8    6;   �� *	Selects+.R�5      �� $ 
Horizontal=�6   .+�5      �� $ tb��6   ��6(   �� *Title+�� 5      $		 etb��6   -   5        $y�	Collapsed=�5   '   $	��100��5   B   ��5   >   �� *Title+$
 	LostFocus=�.��5   Q    5      �� 5      $ Enter��6%    61   �� *SwitchToEditingMode+.��5   -    5        5      $ 	LostFocus��6)   . 5         64   �� *SwitchToEditingMode+5      .��5   .   5      5        5#      �� 5$      .R�5%      �� $ 
Horizontal=�6!   .+�5&      �� $ tb��6$   ��60   �� *Title+�� 5'      $		 etb��6"   -   5        $y�	Collapsed=�5'   /   $	��100��5(   J   ��5'   F   �� *Title+$
 	LostFocus=�.��5(   Y    5)      �� 5*   "   $ Enter��6-    69   �� *SwitchToEditingMode+.��5+   5    5-        5.   "   $ 	LostFocus��61   . 5/   &      6<   �� *SwitchToEditingMode+50   #   .��51   6   52      53       55      �� 56      $
 True��6E    6&   �� *
IsSelected+.a�57      �� $ tb��6%    � ��$
 Bold"�6K   58      �� 59      $
 True��6H    6&   �� *IsEditingName+.a�5:      �� $ tb��6%    � y�$ 	Collapsed=�6K   �� 5;      $	 etb��6%    � y�$ Visible=�6L   5<      5>       5C      �� 5D      $
 True��6=    6   �� *
IsSelected+.a�5E      �� $ tb��6    � ��$
 Bold"�6C   5F      �� 5G      $
 True��6@    6   �� *IsEditingName+.a�5H      �� $ tb��6    � y�$ 	Collapsed=�6C   �� 5I      $	 etb��6    � y�$ Visible=�6D   5J      5L      �� 5N   
   .@�5O      m� $
��Copy��6    6%   �� *Copy+m� 5P      $��Paste��6    6&   �� *Paste+m� 5Q      $��Rename��6    6'   �� *Rename+�� 5R      m� 5S      $��Insert Folder��6    6.   �� *	AddFolder+m� 5T      $��Delete Folder��6    6.   �� *DeleteFolder+�� 5U      m� 5V      $��Insert Case��6    6,   �� *	AddSelect+m� 5W      $��Delete Case��6    6,   �� *DeleteSelect+�� 5X      m� 5Y      $	��Run��6   5Z      5[      .��5]      � 
������� � ColumnDefinitions 5^   
   �� 5_      $	��200 �6   �� 5`      $
��auto �6   �� 5a      $��* �6   .+�5d   
   R� -   5         R�Name$ treeView��5d      $��0��6E   $��6q�6U   #��[ 5e       � ContextMenu# [ 5f      #��[  5g      ��5d   %   �� *	Folders+ 5j        5k      $ SelectedItemChanged��6!   . 5l         6,   �� *
SelectItem+   CommandParameter 5m      ��  �� ElementName$ treeView�� �� Path$ SelectedItem�5n      5p      �� 5r   
   $��1��6   $��3��6'   $��Center=�61   $��Stretch=�6N   ���	#FFD1D1D16j   �� 5t   
   $��2��68   ��6   �� *
SelectView+68   5u      5v      