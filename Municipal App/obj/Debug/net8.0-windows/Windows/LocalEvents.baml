   M S B A M L   `   `   `  ����H  DMunicipal App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Municipal_App.WindowsMunicipal_App.Windows  5      '    !Municipal_App.Windows.LocalEvents   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Municipal_App.Windows     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  LocalEvents��5      $	��800��5	      $	��550��5
      $	��800��5      $	��550��5       � AllowsTransparency$ False��5       � 
ResizeMode$ 	CanResize=�5      ��5      �� 5   
    �� ImageSource$ ..\Images\background.jpg��6    j� Stretch$ UniformToFill=�6<   .��5      �  � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��2��6   ���#2D9CDB J� Opacity$	 0.8Q�67   �� 5    
   $��Local Events��6      InterVariable#��[  5!      $��50(�5"      $
��Bold"�6   
�������$��Center=�5#      $��Center=�6-   $��2��5$      �� 5&   
   $��1��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��10q�6O   .+�5'      �� -   5        	 ��Name$	 	txtSearch��5'      $	��195��6)   $��30��65   $��0,0,10,0q�6A   �� 5(      -   5        
 ��Name$
 	btnSearch��5(      $��Search��6(   #��[  5)      $��16(�6=   $
��10,5q�6K   �� 5*      -   5        $
 btnFilterCategory��5*      $��Filter Category:��60   #��[  5+      $��16(�6=   $
��10,0q�5,   1   �� 5-      -   5         ��Name$ cmbCategory��5-      $	��143��6,   $��8q�68   
����������#2D9CDB$��2q�5.   <   #��[  5/      $��16(�6?    �� Text$ Select a Category��50       � ToolTip$ Select Category��6,   51      �� 53   
   $��2��6   $��0��6$   $��10q�64   .��54      �� -   5         ��Name$ spEvents��54      
�������$	 0.8Q�6>   55      �� 57   
   $��2��6   $��1��6$   $��10q�64   .��58      �� -   5        $ spEventDetails��58      
�������$	 0.8Q�6D   59      �� 5;   
   $��3��6   $��2��6"   $ 
Horizontal=�66   $��Center=�5<      $
��0,10q�6.   .+�5=      �� -   5        $
 btnBack��5=      $
��Back��6&   ���#2D9CDB
������ 
�������#��[  5?      $��16(�6=   $
��Bold"�6K   $��88��5@      $��40��6   $��0,0,10,0q�6(    � 	Resources 5A       �� 
TargetType �� Property �� Value��%_   '��       �� 5B      " ��6   .�5C      ��  �@��CornerRadius$ 20��69   5D      5E      5F      �� 5G      -   5        $
 btnClear��5G      $��Clear��6'   ���#2D9CDB
������ 
�������#��[  5I      $��16(�6=   $
��Bold"�6K   $	��102��5J      $��40��6    5K      ��%_   '��       �� 5L      " ��6   .�5M      ��  �@��CornerRadius$ 20��69   5N      5O      5P      5Q      5R      5S      