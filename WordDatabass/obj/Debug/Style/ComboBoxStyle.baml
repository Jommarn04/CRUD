   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxNormalBorderBrush  �� Color ! ComboBoxNormalBackgroundBrush # ComboBoxDisabledForegroundBrush # ComboBoxDisabledBackgroundBrush  ComboBoxDisabledBorderBrush �� 
TargetType   ComboBoxToggleButtonTemplate � ColumnDefinitions �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  ComboBoxFlatStyle
 �� 
TargetType �� 	ClickMode d� 	IsChecked �� Path �� RelativeSource �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name
 � Tag �� 
IsReadOnly �� 
IsReadOnly � AllowsTransparency �� IsDropDownOpen J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation ]� 
Conditions �� Property �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        &	 %     &	 F     &	 d     &	 �     &	 �     7   7  7  7  7  7  7  &	     7  7   7  �� 5      $  Transparent��68   �� 5      $  #DFCCFB��6<   �� 5      $
  #888��6>   �� 5      $  #DFCCFB��6>   �� 5	      $
  #888��6:   �� 5      " d�6   .R�5   
   �  5      �� 5      �� 5      $��20 �6#   .+�5      �� $��Border��6)   $��2��6   8��  $ 5��5      $��
1, 1, 1, 1q�6    8�� 5      �� 5      $��ButtonBorder��6E   $��1��6   $	��2.3q�6%   ���#444$ 5��5      $��
0, 0, 0, 0q�6    8�� 5      F� 5      $��Arrow��6   $��1��6    =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	$��Center=�5      ���#444$��Center=�5      5       5   
   P� 5       �@J�IsMouseOver . . �5       �� $ ButtonBorder��65    � ��	 �#DFCCFB6O   5!      P� 5"       �@d�	IsChecked$
 TrueY�68   . �5#      �� $ ButtonBorder��65    � ��	 �#DFCCFB6O   �� 5$      $ Arrow��6/    � ��	 �	#FF8D979E6B   5%      P� 5&       � {� .  . �5'      �� $ Border��65   8	   � ��6I   �� 5(      $ ButtonBorder��65   8	   � ��6O   �� 5)      $ ButtonBorder��67   8	   � ��6Q   �� 5*      8	   � ��6;   �� 5+      $ Arrow��6/    � ��	 �#9996B   5,      5.      �� 50      "
 ��6'   .�51   
   ��  �@J�SnapsToDevicePixels	 . 6:   �� 52   
    �@�OverridesDefaultStyle	 . 6C   �� 53   
    � ��$
	 Auto=�6G   �� 54   
    � ��$
	 Auto=�6E   �� 55   
    � ��	 . 6:   �� 56   
    � ��	 �#32265363   �� 57   
    �@�FocusVisualStyle	 6>   Z� �� 58   
    � ��	 59      �� 5:      " ��6"   .R�5;      � .+�5<      d� $��ToggleButton��6'   $��2��6;   $ Press=�5=   (   |�.  8��   5>      �� $ IsDropDownOpen� �� *TemplatedParent+$ TwoWay=�5?      �� 5A      $��ContentSite��6+   $��5, 3, 23, 3q�6>    .  $��Center=�5B      $��Center=�6<   #��z 5C      #��z 5D      #��z��5E      �� 5F      $ label1��6    $��Center=�5G       $��Center=�5H       ���#7D7C7C$��Medium"�5J       $y�	Collapsed=�5K       $��-5 0 0 0q�5L       #��z 5M       $��13(�5N       �� 5O      $��PART_EditableTextBox��6"   $��3, 3, 23, 3q�6>   # z 5P      $y�Hidden=�5Q      
������ $
��Left=�5R      $��Center=�61   |�. .��5S   (   ��5T      �� 5U   "   " ��62   .R�5V   &   �� $��PART_ContentHost��6-   |�.  6E   5W   #   .��5X   0   5Y      � 5[      $��Popup��6    $��Bottom=�6-   |�.   . #��z 5]      $��Slide=�5^      .��5_      � $��DropDown��6#    . #��z 5`      #��z 5a      .+�5b   "   �� $��DropDownBorder��6)   
�������$��
0, 1, 0, 0q�6R   $ 0��5c      $��1,1,1,1q�6*   8�� 5d      �� 5e   "   $��4q�6/    . .��5f   &   �� $ 	Contained=�65   5g   #   5h      5i      5j       5k      ]� 5l       5m      �� 5n   "    �@��Text$  ��6<   ./�5p      �� $ label1��6K    � y�$	 Visible=�6;   6K   5q      P� 5r       �@��HasItems .  . �5s      �� $ DropDownBorder��6K    � ��$	 95��6g   5t      P� 5u       � {� .  . �5v      �� 8	   � ��6G   5w      P� 5x       �@��
IsGrouping . . �5y      ��  � ��	 .  6N   5z      P� 5{       �@��
IsEditable . . �5|      ��  �@  	IsTabStop	 .  6M   �� 5}      $ PART_EditableTextBox��6E    � y�$	 Visible=�6g   �� 5~      $ ContentSite��6E    � y�$	 Hidden=�6^   5      5�      5�      5�      5�      