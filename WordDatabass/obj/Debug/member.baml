   M S B A M L   `   `   `  ����G  CWordDatabass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WordDatabassWordDatabass  5   	       WordDatabass.member   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WordDatabass     5   	   -   5        $	��600��5   
   $	��800��5	   	     � WindowStartupLocation$  CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      ��  �� CornerRadius$ 10��6   ���#fff._�5   
   �  � ColumnDefinitions 5      �� 5      $
��383* �6#   �� 5      $
��417* �6#   .+�5      �� ���#000$��1q�5      $ 10��5      $	��200��5      $��35��5      $	��Top=�5      $��50,12,133,0q�5      ._�5       � .+�5!      �� -   5         ��Name$ 
txt_search��5#         TextboxSearch_Style#��[  5!      $
��Left=�5"      5#      5$      5%      �� 5'       �� Orientation$ 
Horizontal=�6   $
��Left=�5(      $	��Top=�5)      $��
265,13,0,0q�5*      .+�5+      �� -   5         ��Name$ delete��5,   1     
btn_delete#��[ 5+      5-   1   �� 5.      -   5        $
 Edit��5/   1     btn_edit#��[ 5.      50   1   51      �� 54      $
��Left=�6   $��2��64   .+�55      &   System.Windows.Controls.DataGrid  -   5          Name$ datashow��55      $	��750��56      $��20 60q�57        Datagrid#��[ 58      59      5:      �� 5;      -   5        $ 	btn_close��5;        	btn_close#��[ 5<      $��1��5=      $��0 5 5 0q�5>      5?      5A      5B      5C      